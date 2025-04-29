# JWatchDog

一个方便获取广告后台数据的工具，使用Selenium浏览器插件，目前支持今日头条巨量引擎管家账号推广页面数据和快手磁力智投看板及跨账户报表数据。

免责声明：本工具只能在用户已经登录的情况下获取可以看到的数据，方便对看到的数据进行再次处理，本程序不干扰也不参与数据后台的自身运行，相应的数据后台没有声明禁止获取数据，且所有数据均须使用人的登录后才可获取。

## 更新内容

### 1.1.2
调整了.NET版本号，当前包含了.NET8和.NET9
增加了Browser中的public static void InstallBrowserDriver()方法用于安装浏览器驱动

### 1.1.1
调整了.NET版本号，当前为 .NET 9

### 1.1.0
增加了对快手磁力智投后台的支持，可以获取“账户数据概览”页面的数据（JWatchDog.KuaiShou.DataSniffer）。

对于同账户下面有多个主体的情况，也增加了对“跨账户报表”的数据获取。

跨账户报表的列需要自行在报表设计时设置，不支持needCols参数（JWatchDog.KuaiShou.DataSnifferN）。

由于需求的数据不同，后台返回时的字段也不同，所以使用时请根据自己的需求修改KSStatsList.cs和KSReportDetail.cs文件的字段以适合你的需求。

### 1.0.5
由于头条后台页面接口修改，新版本的DataSnifferN也跟随进行了修改。

对于无头参数的修改，调整了 --headless=new 参数，以便在无头模式下能顺利获取数据。


### 1.0.3

增加了对巨量引擎新版本的数据支持，如果后台为新版本，会自动选择“全部”选项以获取完整数据。

使用新版后台时，将DataSniffer类改为DataSnifferN，OptCols类改为OptColsN，TTStatsList类改为TTStatsListN。

数据结构可查看TTStatsListN的结构，或参考https://business.oceanengine.com/nbs/api/bm/promotion/ad/get_bidding_account_list接口的返回内容。

## 使用方法
-----
### 获取一个Selenium浏览器驱动实例

注意：系统中需要安装Chrome浏览器。

如果你需要打开一个浏览器并手动操作，可以使用下面的代码：
```C#
JWatchDog.Browser browser = new JWatchDog.Browser();
browser.CacheDir = "D:\\Chrome\\1";
browser.BrowerPort = 0;
ChromeDriver chromeDriver= browser.SetupBrower(false,false,true);
```

CacheDir 参数用以指定Chrome浏览器的缓存目录，方便在登录后记录用户的登录状态避免采集数据时再次登录，默认是当前程序运行目录下的Cache子目录。

BrowerPort 参数用以指定程序与浏览器通讯用的端口，默认用0由系统控制。

注意：同时打开多个浏览器窗口可能造成Selenium无法通讯。

-----
### 打开巨量引擎登录页面

```C#
JWatchDog.Browser browser = new JWatchDog.Browser();
ChromeDriver driver = browser.SetupBrower(false);
driver.Navigate().GoToUrl("https://business.oceanengine.com/site/login");
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); //设置浏览器等待加载的时间
IWebElement email_input = driver.FindElement(By.Name("email"));
email_input.SendKeys("账号");
IWebElement password_input = driver.FindElement(By.Name("password"));
password_input.SendKeys("密码");
IWebElement checkBox = driver.FindElement(By.ClassName("account-center-agreement-check"));
driver.ExecuteScript("arguments[0].click();", checkBox);
IWebElement submitButton = driver.FindElement(By.ClassName("account-center-action-button"));
driver.ExecuteScript("arguments[0].click();", submitButton);
//此时会弹出人机验证界面，需要手动操作验证
//循环检测是否已经完成人机验证（3秒一次，共尝试10次）
for (int i = 0; i < 10; i++)
{
    string pageUrl = driver.Url;
    if (pageUrl.StartsWith("https://business.oceanengine.com/site/dashboard"))
    {
        break;
    }
    Thread.Sleep(3 * 1000);
}
driver.Quit();
```
-----
### 使用内置的日志记录器
```C#
JWatchDog.Logger logger = new JWatchDog.Logger();
logger.Write("This is a test log", Logger.LogLevel.Info);
```
Logger对象的LogDir参数为日志文件存储路径，不设置时默认为当前程序目录下的Logs子目录。

LogLevel共有4个等级，分别为Info,Warn,Error,Fatal。

注意：Logger使用了单例模式。

日志记录器还提供了OnLogWrite事件，方便WinForm应用在写入日志是获取日志信息用于显示。

```C#
static void Main()
{
    Logger logger = new Logger();
    logger.OnLogWrite += log;
    logger.Write("info test");
    logger.Write("warn test", Logger.LogLevel.Warn);
    logger.Write("error test", Logger.LogLevel.Error);
}

static void log(string str,JWatchDog.Logger.LogLevel level)
{
    if(level > Logger.LogLevel.Warn)
    {
        Console.WriteLine(str);
    }
}
```

-----
### 获取数据
```C#
JWatchDog.TouTiao.DataSniffer dataSniffer = new JWatchDog.TouTiao.DataSniffer();
dataSniffer.CacheDir = "C:\\Chrome\\1";
string[] addCols = new string[6] { "激活数", "激活成本", "次留数", "次留率", "首次付费数", "付费成本" };
TTStatsList tTStatsList = dataSniffer.GetData(0, addCols);
Console.Write(tTStatsList.ToString());
```
CacheDir 参数用以指定Chrome浏览器的缓存目录，方便在登录后记录用户的登录状态避免采集数据时再次登录，默认是当前程序运行目录下的Cache子目录。

BrowerPort 参数用以指定程序与浏览器通讯用的端口，默认用0由系统控制。

TTStatsList 类是获取到的数据内容，其结构可参考 https://business.oceanengine.com/platform/api/v1/bp/statistics/promote/advertiser/stats_list/ 接口的返回内容。

TTStatsList的ToString()方法将会返回对应的Json字符串。

TTStatsList的Add()方法可以将另一个TTStatsList对象的stats_list合并到当前的对象中。

获取数据时会自动翻页。

-----
### 操控数据列表页面中的列

```C#
JWatchDog.TouTiao.OptCols.NeedCol(ref ChromeDriver driver, string colName)
JWatchDog.TouTiao.OptCols.TryAddCol(ref ChromeDriver driver, string colName)
```

通过NeedCol方法可以自动检测列是否存在，如果不存在则会调用TryAddCol尝试增加指定的列。

-----
### 支持操作ini文件便于存储配置信息

```C#
//写入
public static bool Write(string filePath, string section, string key, string? val);
//删除键
public static bool DeleteKey(string filePath, string section, string key);
//删除区段
public static bool DeleteSection(string filePath, string section);
//读取值
public static string ReadValue(string filePath, string section, string key);
//读取区段
public static List<string> ReadSections(string filePath);
//读取所有键
public static List<string> ReadKeys(string filePath, string section);
```

调用实例
```c#
JWatchDog.IniFile.Write("D:\\Config\\c.ini", "Account", "Name", "张三");
```