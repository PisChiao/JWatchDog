using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace JWatchDog
{
    public class Browser
    {
        /// <summary>
        /// 浏览器插件缓存目录，默认为./Cache
        /// </summary>
        public string CacheDir { get; set; }

        /// <summary>
        /// 浏览器插件所用通讯端口，默认0为随机
        /// </summary>
        public int BrowerPort { get; set; }

        public Browser(string cacheDir, int browerPort)
        {
            CacheDir = cacheDir;
            BrowerPort = browerPort;
        }
        public Browser()
        {
            CacheDir = Environment.CurrentDirectory + "\\Cache\\";
            BrowerPort = 0;
        }
        /// <summary>
        /// 设置一个可用的浏览器对象
        /// </summary>
        /// <param name="headless">是否无头模式</param>
        /// <param name="performance">是否抓取网络通讯日志，默认为true</param>
        /// <param name="hideCommandPromptWindow">是否隐藏命令行窗口，默认为true</param>
        /// <returns>Chrome浏览器对象</returns>
        public ChromeDriver SetupBrower(bool headless, bool performance = true, bool hideCommandPromptWindow = true)
        {
#if DEBUG
            headless = false;
            performance = true;
            hideCommandPromptWindow = false;
#endif
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(System.Environment.CurrentDirectory.ToString());
            if(hideCommandPromptWindow)
            {
                service.HideCommandPromptWindow = true;
            }
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-error");
            options.AddArgument("--ignore-ssl-errors");
            options.AddArgument("--no-sandbox");
            if (headless)
            {
                options.AddArgument("--headless");
            }
            if (BrowerPort > 0)
            {
                options.AddArgument("--remote-debugging-port=" + BrowerPort.ToString());
            }
            options.AddArgument("--user-data-dir=" + CacheDir);
            if (performance)
            {
                options.SetLoggingPreference("performance", OpenQA.Selenium.LogLevel.Info);
                options.PerformanceLoggingPreferences = new ChromiumPerformanceLoggingPreferences()
                {
                    IsCollectingNetworkEvents = true
                };
            }
            return new ChromeDriver(service, options);
        }
    }
}
