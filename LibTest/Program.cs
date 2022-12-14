using JWatchDog;
using static System.Net.Mime.MediaTypeNames;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        JWatchDog.Logger logger = new JWatchDog.Logger();
        logger.Write("test info", Logger.LogLevel.Info);
        logger.Write("test warn", Logger.LogLevel.Warn);
        Console.WriteLine("finish");
        Console.ReadLine();
    }
}
