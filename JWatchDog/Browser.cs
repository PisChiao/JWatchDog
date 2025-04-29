using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.Edge;
using System.Diagnostics;

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
        public EdgeDriver SetupBrowser(bool headless = true, bool performance = true, bool hideCommandPromptWindow = true,bool isEager = false)
        {
            string path = Encoding.UTF8.GetString( Encoding.Default.GetBytes(System.Environment.CurrentDirectory.ToString()));
            EdgeDriverService service = EdgeDriverService.CreateDefaultService(path);
            if(hideCommandPromptWindow)
            {
                service.HideCommandPromptWindow = true;
            }
            EdgeOptions options = new EdgeOptions();
            if(isEager)
            {
                options.PageLoadStrategy = OpenQA.Selenium.PageLoadStrategy.Eager;
            }
            options.AddArgument("--ignore-certificate-error");
            options.AddArgument("--ignore-ssl-errors");
            options.AddArgument("--no-sandbox");
            if (headless)
            {
                options.AddArgument("--headless=new");
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
            try
            {
                EdgeDriver driver = new EdgeDriver(service, options);
                //var _ = driver.ExecuteCdpCommand("Network.setCacheDisabled", new Dictionary<string, object>() { { "cacheDisabled", true } }) as Dictionary<string, object>;
                return driver;
            }catch(Exception ex) 
            {
                throw new Exception("启动浏览器失败，请点击关于->重置浏览器后重试\r\n"+ex.Message);
            }
            
        }

        public static void InstallBrowserDriver()
        {
            try
            {
                string path = new DriverManager().SetUpDriver(new EdgeConfig());
                FileInfo file = new FileInfo(path);
                file.CopyTo(Encoding.UTF8.GetString(Encoding.Default.GetBytes(System.Environment.CurrentDirectory.ToString())) + "\\" + file.Name);
                var driver = new EdgeDriver();
                driver.Quit();
            }
            catch
            {
                throw;
            }
        }
    }
}
