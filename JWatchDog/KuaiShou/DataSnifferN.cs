using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWatchDog.KuaiShou
{
    public class DataSnifferN : DataSnifferBase
    {
        public DataSnifferN(string cacheDir, int browerPort) : base(cacheDir, browerPort) { }
        public KSReportDetail GetData(int daysBeforeToday, string[] needCols, bool isDebug = false, bool isMonthlyData = false)
        {
            Browser browser = new Browser(CacheDir, BrowerPort);
            EdgeDriver driver = browser.SetupBrowser(!isDebug, true, !isDebug);
            try
            {
                //获取客户的信息，里面含有账户列表
                KSOwnerInfo ownerInfo = ReadOwnerInfo(ref driver);
                //选第一个账户，进入到账户详情页面
                if (ownerInfo is null || ownerInfo.accountInfos!.Count <= 0)
                {
                    throw new Exception("无法获取到用户下属账户列表");
                }
                //进入跨账户报表页面
                driver.Navigate().GoToUrl("https://ad.e.kuaishou.com/custom-report/preview/9157?crossAccount=true&__accountId__=" + ownerInfo.accountInfos[0].accountId.ToString());
                Thread.Sleep(1000);
                ChooseDate(ref driver, daysBeforeToday, isMonthlyData);
                Thread.Sleep(1000);
                KSReportDetail reportDetail = ReadAllReport(ref driver);
                foreach(ResultListItem item in reportDetail.data.resultList)
                {
                    //给报表信息添加账户名和产品名备用，这里的代码不适合其他项目
                    item.accountName = ownerInfo.accountInfos.Where(o => o.accountId == item.accountId).FirstOrDefault()!.accountName!;
                    string[] accountNameSplit = item.accountName.Split('-');
                    if(accountNameSplit.Length > 2)
                    {
                        item.productName = accountNameSplit[0];
                    }
                    
                }
                driver.Quit();
                return reportDetail;
            }
            catch
            {
                driver.Quit();
                throw;
            }

        }
        private KSOwnerInfo ReadOwnerInfo(ref EdgeDriver driver)
        {
            driver.Navigate().GoToUrl("https://ad.e.kuaishou.com/monitor");
            driver.Navigate().Refresh();
            IEnumerable<LogEntry>? logs = driver.Manage().Logs.GetLog("performance")?.Where(o => o.Message.Contains("rest/dsp/owner/info") && o.Message.Contains("\"method\":\"Network.responseReceived\""));
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Thread.Sleep(2000);
                    logs = driver.Manage().Logs.GetLog("performance")?.Where(o => o.Message.Contains("rest/dsp/owner/info") && o.Message.Contains("\"method\":\"Network.responseReceived\""));
                    if (logs == null || logs.Count() <= 0)
                    {
                        continue;
                    }
                    JObject json = JObject.Parse(logs.Last().Message);
                    string url = json["message"]!["params"]!["response"]!["url"]!.ToString();
                    string requestId = json!["message"]!["params"]!["requestId"]!.ToString();
                    var response = driver.ExecuteCdpCommand("Network.getResponseBody", new Dictionary<string, object>() { { "requestId", requestId } }) as Dictionary<string, object>;
                    if (response!.TryGetValue("body", out object? bodyObj))
                    {
                        if (bodyObj == null || bodyObj.ToString() == "")
                        {
                            continue;
                        }
                        KSOwnerInfo ownerInfo = JsonConvert.DeserializeObject<KSOwnerInfo>(bodyObj.ToString()!)!;
                        if (ownerInfo.accountInfos is null || ownerInfo.accountInfos.Count <= 0)
                        {
                            continue;
                        }
                        return ownerInfo;
                    }
                }
                catch (Exception ex)
                {
                    logger.Write(ex.Message + "\r\nReadOwnerInfo错误，继续尝试中...");
                    continue;
                }

            }
            throw new Exception("ReadOwnerInfo无法获取用户账号列表，可能是登录已过期");
        }

        private KSReportDetail ReadAllReport(ref EdgeDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            KSReportDetail reportDetail = ReadReport(ref driver);
            int retryTimes = 0;
            while((reportDetail.data.pageInfo.currentPage < (reportDetail.data.pageInfo.totalCount/reportDetail.data.pageInfo.pageSize)) && (retryTimes < 10))
            {
                try
                {
                    //点击下一页按钮
                    ReadOnlyCollection<IWebElement> buttons = wait.Until(e => e.FindElements(By.ClassName("MUI__ufwphwd")));
                    IWebElement nextPage = buttons.Where(o=>o.GetDomAttribute("aria-label")== "next page").FirstOrDefault()!;
                    if (nextPage is null) { 
                        retryTimes++;
                        Thread.Sleep(1000);
                        continue;
                    }
                    else
                    {
                        driver.ExecuteScript("arguments[0].click()", nextPage);
                        reportDetail.Add(ReadReport(ref driver));
                    }
                }
                catch (WebDriverTimeoutException)
                {
                    retryTimes++;
                    Thread.Sleep(1000);
                    continue;
                }
                catch (NoSuchElementException)
                {
                    retryTimes++;
                    Thread.Sleep(1000);
                    continue;
                }
            }
            return reportDetail;
        }

        private KSReportDetail ReadReport(ref EdgeDriver driver)
        {
            driver.Navigate().Refresh();
            IEnumerable<LogEntry>? logs = driver.Manage().Logs.GetLog("performance")?.Where(o => o.Message.Contains("rest/dsp/portal/report/getDetail") && o.Message.Contains("\"method\":\"Network.responseReceived\""));
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Thread.Sleep(1000);
                    logs = driver.Manage().Logs.GetLog("performance")?.Where(o => o.Message.Contains("rest/dsp/portal/report/getDetail") && o.Message.Contains("\"method\":\"Network.responseReceived\""));
                    if (logs == null || logs.Count() <= 0)
                    {
                        continue;
                    }
                    JObject json = JObject.Parse(logs.Last().Message);
                    string url = json["message"]!["params"]!["response"]!["url"]!.ToString();
                    string requestId = json!["message"]!["params"]!["requestId"]!.ToString();
                    var response = driver.ExecuteCdpCommand("Network.getResponseBody", new Dictionary<string, object>() { { "requestId", requestId } }) as Dictionary<string, object>;
                    if (response!.TryGetValue("body", out object? bodyObj))
                    {
                        if (bodyObj == null || bodyObj.ToString() == "")
                        {
                            continue;
                        }
                        KSReportDetail reportData = JsonConvert.DeserializeObject<KSReportDetail>(bodyObj.ToString()!)!;
                        if (reportData.data is null || reportData.data.resultList.Count <= 0)
                        {
                            continue;
                        }
                        return reportData;
                    }
                }
                catch (Exception ex)
                {
                    logger.Write(ex.Message + "\r\nReadReport错误，继续尝试中...");
                    continue;
                }
            }
            throw new Exception("ReadReport无法获取报表，可能是登录已过期");
        }

        private void ChooseDate(ref EdgeDriver driver, int daysBeforeToday, bool isMonthlyData = false)
        {
            
            for(int i = 0;i <10;i++)
            {
                try
                {
                    //定位输入框
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    IWebElement datePicker = wait.Until(e => e.FindElement(By.ClassName("ant-picker-input-active")));
                    driver.ExecuteScript("arguments[0].click()", datePicker);
                    Thread.Sleep(1000);
                    ReadOnlyCollection<IWebElement> presetDate = wait.Until(e => e.FindElements(By.ClassName("ant-picker-preset")));
                    //打开日期选择器
                    if (isMonthlyData)
                    {
                        IWebElement lastMonth = presetDate.Where(o => o.Text == "上月").FirstOrDefault()!.FindElement(By.TagName("span"))!;
                        driver.ExecuteScript("arguments[0].click()", lastMonth);
                        break;
                    }
                    else if (daysBeforeToday == 1)
                    {
                        IWebElement lastDay = presetDate.Where(o => o.Text == "昨天").FirstOrDefault()!.FindElement(By.TagName("span"))!;
                        driver.ExecuteScript("arguments[0].click()", lastDay);
                        break;
                    }else if(daysBeforeToday == 0)
                    {
                        IWebElement lastDay = presetDate.Where(o => o.Text == "今天").FirstOrDefault()!.FindElement(By.TagName("span"))!;
                        driver.ExecuteScript("arguments[0].click()", lastDay);
                        break;
                    }
                    else
                    {
                        throw new Exception("快手尚未实现其他日期选择");
                    }
                }catch(NoSuchElementException)
                {
                    Thread.Sleep(1000);
                    continue;
                }
            }
            
        }
    }
}
