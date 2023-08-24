using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using OpenQA.Selenium.Chromium;
using JWatchDog.TouTiao.StatsList;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Edge;

namespace JWatchDog.TouTiao
{
    public class DataSnifferN : DataSnifferBase
    {
     
        public DataSnifferN(string cacheDir, int browerPort):base(cacheDir, browerPort) { }
        /// <summary>
        /// 获取指定日期的数据
        /// </summary>
        /// <param name="daysBeforeToday">向前查询天数，0为当天，1为昨天</param>
        /// <param name="needCols">需要额外添加的列名称数组</param>
        /// <param name="isDebug">是否debug模式</param>
        /// <param name="isMonthlyData">是否读取月度数据，为true时忽略天数</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public TTStatsListN GetData(int daysBeforeToday, string[] needCols,bool isDebug = false,bool isMonthlyData = false)
        {
            TTStatsListN nowStats = new TTStatsListN();
            Browser browser = new Browser(CacheDir, BrowerPort);
            EdgeDriver driver = browser.SetupBrowser(!isDebug, true, !isDebug);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            try
            {
                driver.Navigate().GoToUrl("https://business.oceanengine.com/site/promotion/ad/all/account");
               
                // 打开自定义列界面
                IWebElement colConfig = driver.FindElements(By.ClassName("ovui-button--default-fill")).Where(o => o.Text == "自定义列").First();
                driver.ExecuteScript("arguments[0].click();", colConfig);


                // 核对并添加所需的列
                foreach (string col in needCols)
                {
                    IWebElement colSelect = driver.FindElements(By.ClassName("ovui-checkbox--md")).Where(o => o.Text == col).First();
                    if (!colSelect.GetDomAttribute("class").Contains("ovui-checkbox--checked"))
                    {
                        driver.ExecuteScript("arguments[0].click();", colSelect);
                        logger.Write("添加不存在的列：" + col);
                    }
                }
                IWebElement confirmBtn = driver.FindElements(By.ClassName("ovui-button--primary-fill")).Where(o => o.Text == "保存").First();
                driver.ExecuteScript("arguments[0].click();", confirmBtn);

                IsLoading(ref driver);
                
                //选择所需的日期
                if (isMonthlyData)
                {
                    IWebElement calendarButton = driver.FindElement(By.ClassName("ovui-range-picker__calendar-icon"));
                    driver.ExecuteScript("arguments[0].click();", calendarButton);
                    string startDay = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-01");
                    IReadOnlyCollection<IWebElement> calendar = driver.FindElements(By.ClassName("ovui-shortcut"));
                    IWebElement lastMonthButton = calendar.Where(o => o.GetAttribute("innerText") == "上月").First();
                    driver.ExecuteScript("arguments[0].click();", lastMonthButton);
                    ReadOnlyCollection<IWebElement> dateArea = driver.FindElement(By.ClassName("ovui-custom-input__content")).FindElements(By.ClassName("ovui-input"));
                    if(!dateArea.First().GetAttribute("value").Contains(startDay))
                    {
                        driver.Quit();
                        throw new Exception("无法选择指定的日期");
                    }
                }
                else if (daysBeforeToday > 0)
                {
                    IWebElement calendarButton = driver.FindElement(By.ClassName("ovui-range-picker__calendar-icon"));
                    driver.ExecuteScript("arguments[0].click();", calendarButton);
                    string needDay = DateTime.Now.AddDays(daysBeforeToday * -1).ToString("yyyy-MM-dd");
                    IReadOnlyCollection<IWebElement> calendar = driver.FindElements(By.ClassName("ovui-panel-date"));
                    foreach (IWebElement calendarElement in calendar)
                    {
                        try
                        {
                            IWebElement dayButton = calendarElement.FindElements(By.TagName("td")).Where(o => o.GetAttribute("title") == needDay).First();
                            driver.ExecuteScript("arguments[0].click();", dayButton);
                            driver.ExecuteScript("arguments[0].click();", dayButton);
                            break;
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    // 检查日期选择是否正确
                    ReadOnlyCollection<IWebElement> dateArea = driver.FindElement(By.ClassName("ovui-custom-input__content")).FindElements(By.ClassName("ovui-input"));
                    foreach (IWebElement dateAreaElement in dateArea)
                    {
                        if (!dateAreaElement.GetAttribute("value").Contains(needDay))
                        {
                            driver.Quit();
                            throw new Exception("无法选择指定的日期");
                        }
                    }
                }
                


                IsLoading(ref driver);

                // 获取数据
                nowStats = ReadAllData(ref driver);
                driver.Quit();
                return nowStats;
            }
            catch
            {
                driver.Quit();
                throw;
            }

        }
        /// <summary>
        /// 从当前页开始，依次读取所有页的数据
        /// </summary>
        /// <param name="driver">当前操作用的浏览器</param>
        /// <returns>读取到的头条数据对象，page部分为最后一页，数据部分为全部</returns>
        private static TTStatsListN ReadAllData(ref EdgeDriver driver)
        {
            TTStatsListN aStatsList = new TTStatsListN();
            aStatsList = ReadData(ref driver);
            while (aStatsList.data.pagination.hasMore)
            {
                IWebElement nextButton = driver.FindElement(By.ClassName("ovui-page-turner__next-icon"));
                driver.ExecuteScript("arguments[0].click();", nextButton);
                IsLoading(ref driver);
                TTStatsListN newStatsList = ReadData(ref driver);
                aStatsList.Add(newStatsList);
            }
            return aStatsList;
        }
        /// <summary>
        /// 读取当前页面已加载的数据
        /// </summary>
        /// <param name="driver">当前操作用的浏览器</param>
        /// <returns>读取到的头条数据对象</returns>
        /// <exception cref="Exception">无法读取数据时抛出异常，可能为登录失效或读取不到数据</exception>
        private static TTStatsListN ReadData(ref EdgeDriver driver)
        {
            TTStatsListN aDStatsList = new TTStatsListN();

            // 获取数据
            var logs = driver.Manage().Logs.GetLog("performance")?.Where(o => o.Message.Contains("promotion/ad/get_account_list") && o.Message.Contains("\"method\":\"Network.responseReceived\""));
            if (logs == null || logs.Count() <= 0)
            {
                driver.Quit();
                throw new Exception("无法获取网络请求日志");
            }
            JObject json = JObject.Parse(logs.Last().Message);
            string url = json["message"]!["params"]!["response"]!["url"]!.ToString();
            string requestId = json!["message"]!["params"]!["requestId"]!.ToString();
            var response = driver.ExecuteCdpCommand("Network.getResponseBody", new Dictionary<string, object>() { { "requestId", requestId } }) as Dictionary<string, object>;
            if (response!.TryGetValue("body", out object? bodyObj))
            {
                aDStatsList = JsonConvert.DeserializeObject<TTStatsListN>(bodyObj.ToString()!)!;
            }
            return aDStatsList;
        }

        private static void IsLoading(ref EdgeDriver driver)
        {
            //检测是否处于loading状态
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    IWebElement loading = driver.FindElement(By.ClassName("ovui-icon__loading"));
                    if (loading.GetCssValue("display") == "none")
                    {
                        return;
                    }
                }
                catch
                {
                    return;
                }
                Thread.Sleep(3000);
            }
        }

    }
}