using JWatchDog.TouTiao.StatsList;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace JWatchDog.KuaiShou
{
    public class DataSniffer :DataSnifferBase
    {
        public DataSniffer(string cacheDir, int browerPort):base(cacheDir, browerPort) { }
        public KSStatsList GetData(int daysBeforeToday, string[] needCols, bool isDebug = false, bool isMonthlyData = false)
        {
            Browser browser = new Browser(CacheDir, BrowerPort);
            EdgeDriver driver = browser.SetupBrowser(!isDebug, true, !isDebug);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            try
            {
                //获取客户的信息，里面含有账户列表
                KSOwnerInfo ownerInfo = ReadOwnerInfo(ref driver);
                //选第一个账户，进入到账户详情页面
                if (ownerInfo is null || ownerInfo.accountInfos!.Count<=0) {
                    throw new Exception("无法获取到用户下属账户列表");
                }
                //进入数据看板页面
                driver.Navigate().GoToUrl("https://ad.e.kuaishou.com/monitor?__accountId__=" + ownerInfo.accountInfos[0].accountId.ToString());
                IsLoading(ref driver);
                // 关闭广告窗口
                CloseAdLayer(ref driver);
                // 添加自定义列
                AddNeedCols(ref driver, needCols);
                IsLoading(ref driver);
                // 选择指定日期
                ChooseDate(ref driver, daysBeforeToday, isMonthlyData);
                IsLoading(ref driver);
                // 逐页全部数据
                KSStatsList? sStatsList = ReadAllData(ref driver,needCols);
                driver.Quit();
                if(sStatsList is null)
                {
                    throw new Exception("GetData无法读取到数据");
                }else
                {
                    return sStatsList;
                }   
            }
            catch
            {
                driver.Quit();
                throw;
            }

        }
        private void CloseAdLayer(ref EdgeDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            while(true)
            {
                IsLoading(ref driver);
                try
                {
                    ReadOnlyCollection<IWebElement> closeButtons = wait.Until(e => e.FindElements(By.TagName("button")));
                    IWebElement closeButton = closeButtons.Where(o => o.GetAttribute("class").Contains("ant-modal-close")).FirstOrDefault()!;
                    if (closeButton is null)
                    {
                        break;
                    }
                    driver.ExecuteScript("arguments[0].click();", closeButton);
                }
                catch(NoSuchElementException)
                {
                    break;
                }catch(WebDriverTimeoutException) { break; }
            }
        }
        private KSStatsList? ReadAllData(ref EdgeDriver driver, string[] needCols)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            KSStatsList? kSStatsList = ReadData(ref driver, needCols);
            if (kSStatsList is null)
            {
                throw new Exception("ReadAllData获取到的数据为空");
            }
            while(kSStatsList.pageInfo!.currentPage < (kSStatsList.pageInfo.totalCount/kSStatsList.pageInfo.pageSize)) 
            {
                IWebElement nextPage = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"monitorAccountOverview\"]/div[3]/div[1]/ul/li[3]/button")));
                if (nextPage != null && nextPage.GetAttribute("disabled")=="false")
                {
                    driver.ExecuteScript("arguments[0].click()", nextPage);
                    IsLoading(ref driver);
                    kSStatsList.Add(ReadData(ref driver, needCols)!);
                }else
                { break; }
            }
            return kSStatsList;
        }
        private KSStatsList? ReadData(ref EdgeDriver driver, string[] needCols)
        {
            string statsListStr = DataUtils.FindUsefulRequest(ref driver, needCols);
            KSStatsList? kSStatsList = JsonConvert.DeserializeObject<KSStatsList>(statsListStr);
            return kSStatsList;
        }

        private KSOwnerInfo ReadOwnerInfo(ref EdgeDriver driver) 
        {
            driver.Navigate().GoToUrl("https://ad.e.kuaishou.com/monitor");
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
                }catch(Exception ex)
                {
                    logger.Write(ex.Message + "\r\nReadOwnerInfo错误，继续尝试中...");
                    continue;
                }
                
            }
            throw new Exception("ReadOwnerInfo无法获取用户账号列表，可能是登录已过期");
        }

        private void AddNeedCols(ref EdgeDriver driver, string[] needCols)
        {
            // 打开自定义列界面
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement configButton1 = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"monitorAccountOverview\"]/div[3]/div[1]/div[3]/button")));
            IWebElement kefuButton = wait.Until(e => e.FindElement(By.CssSelector(".anticon.anticon-normal-dialogue-minus-line")));
            Actions action = new Actions(driver);
            action.MoveToElement(kefuButton);
            Thread.Sleep(500);
            action.MoveToElement(configButton1).Perform();
            Thread.Sleep(500);
            ReadOnlyCollection<IWebElement> buttons = wait.Until(e => e.FindElements(By.TagName("button")));
            IWebElement? configButton2 = buttons.Where(e=>e.Text == "自定义指标").FirstOrDefault();
            if(configButton2 is null) 
            {
                throw new Exception("找不到自定义指标按钮");
            }
            driver.ExecuteScript("arguments[0].click();", configButton2);
            IsLoading(ref driver);
            // 核对并添加所需的列
            ReadOnlyCollection<IWebElement> cols = wait.Until(e => e.FindElements(By.ClassName("ant-checkbox-wrapper")));
            foreach (string col in needCols)
            {
                IWebElement? colSelect = cols.Where(o => o.Text == col).FirstOrDefault();
                if(colSelect is null)
                {
                    throw new Exception("AddNeedCols无法找到需要添加的列");
                }
                if (!colSelect.GetDomAttribute("class").Contains("ant-checkbox-wrapper-checked"))
                {
                    IWebElement colCheckBox = colSelect.FindElement(By.TagName("input"));
                    driver.ExecuteScript("arguments[0].click();", colCheckBox);
                    logger.Write("添加不存在的列：" + col);
                }
            }
            ReadOnlyCollection<IWebElement> mainButtons = wait.Until(e => e.FindElements(By.ClassName("ant-btn-primary")));
            IWebElement? confirmBtn = mainButtons.Where(o=>o.Text == "确 定").FirstOrDefault();
            if (confirmBtn is null)
            {
                throw new Exception("找不到确定按钮");
            }
            driver.ExecuteScript("arguments[0].click();", confirmBtn);
        }
        private void ChooseDate(ref EdgeDriver driver, int daysBeforeToday,bool isMonthlyData = false)
        {
            if(daysBeforeToday == 0) { return; }
            //定位输入框
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement startDay = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"monitorAccountOverview\"]/div[3]/div[1]/div[2]/div[1]/input")));
            IWebElement endDay = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"monitorAccountOverview\"]/div[3]/div[1]/div[2]/div[3]/input")));
            endDay.SendKeys(Keys.Enter);
            //打开日期选择器
            IsLoading(ref driver);
            ReadOnlyCollection<IWebElement> datePicker = wait.Until(e => e.FindElement(By.ClassName("ant-picker-panel-container")).FindElements(By.TagName("td")));

            if (isMonthlyData)
            {
                string startStr = Convert.ToDateTime(DateTime.Now.AddDays(1 - DateTime.Now.Day).AddMonths(-1).ToLongDateString()).ToString("yyyy-MM-dd");
                string endStr = Convert.ToDateTime(DateTime.Now.AddDays(1 - DateTime.Now.Day).AddDays(-1).ToLongDateString()).ToString("yyyy-MM-dd");
                IWebElement? startButton = datePicker.Where(o => o.GetAttribute("title") == startStr).FirstOrDefault();
                IWebElement? endButton = datePicker.Where(o => o.GetAttribute("title") == endStr).FirstOrDefault();
                if(startButton is null || endButton is null)
                {
                    throw new Exception("无法定位日期选择器");
                }
                driver.ExecuteScript("arguments[0].click()", startDay);
                driver.ExecuteScript("arguments[0].click()", endDay);
                endDay.SendKeys(Keys.Enter);
            }
            else if(daysBeforeToday > 0)
            {
                //修改数值
                string needDay = DateTime.Now.AddDays(daysBeforeToday * -1).ToString("yyyy-MM-dd");
                IWebElement? dayButton = datePicker.Where(o=>o.GetAttribute("title")==needDay).FirstOrDefault();
                if (dayButton is null)
                {
                    throw new Exception("无法定位日期选择器");
                }
                driver.ExecuteScript("arguments[0].click()", dayButton);
                driver.ExecuteScript("arguments[0].click()", dayButton);
            }
        }
        private void IsLoading(ref EdgeDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            for (int i = 0;i<10;i++)
            {
                Thread.Sleep(1000);
                try
                {
                    IReadOnlyCollection<IWebElement> loadingIcon = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"monitorAccountOverview\"]/div[3]/div[2]/div")).FindElements(By.TagName("i")));
                    if (loadingIcon.Count() > 0) { continue; } else { return; }
                }catch(WebDriverTimeoutException)
                { 
                    return; 
                }catch(NoSuchElementException) {
                    return;
                }
            }
            throw new Exception("数据加载超时");
        }
    }
}
