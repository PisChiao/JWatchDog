using JWatchDog;
using JWatchDog.TouTiao;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.Mime.MediaTypeNames;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
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
}
