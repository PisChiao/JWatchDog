using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWatchDog
{
    public class Logger
    {
        private static Logger? instance = null;
        public Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

        private string _logDir = System.Environment.CurrentDirectory + "\\Logs";
        /// <summary>
        /// 日志文件存储目录，默认为./Logs
        /// </summary>
        public string LogDir
        {
            get { return _logDir; }
            set { _logDir = value; }
        }
        /// <summary>
        /// 写入一条日志
        /// </summary>
        /// <param name="s">日志内容</param>
        public void Write(string s, LogLevel level = LogLevel.Info)
        {
            string logFile = LogDir + "\\" + DateTime.Now.Date.ToString("yyyy-MM-dd") + ".txt";
            if (OnLogWrite != null) { OnLogWrite(DateTime.Now.ToString() + " : " + s + "\r\n",level); }
            WriteFile(logFile,level.ToString() +"\t" + DateTime.Now.ToString() + "\t:\t" + s + "\r\n");
        }
        /// <summary>
        /// 写入文件内容
        /// </summary>
        /// <param name="filePath">要写入的文件</param>
        /// <param name="content">要写入的内容</param>
        public void WriteFile(string filePath, string content)
        {
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Encoding encoding = Encoding.GetEncoding("GB2312");
            FileInfo file = new FileInfo(filePath);
            if (!file.Directory!.Exists)
            {
                file.Directory.Create();
            }
            FileStream fs = new(filePath, FileMode.Append, FileAccess.Write);

            byte[] buffer = encoding.GetBytes(content);
            fs.Write(buffer, 0, buffer.Length);
            fs.Flush();
            fs.Close();
        }

        public enum LogLevel{
            Info = 0,
            Warn = 1,
            Error = 2,
            Fatal = 3
        }

        // 定义写日志事件方便更新控件
        /// <summary>
        /// 更新日志代理
        /// </summary>
        /// <param name="str">日志内容字符串，已包含换行符</param>
        public delegate void LogWritedDelegate(string str,LogLevel level);
        /// <summary>
        /// 当写入一条新日志的时候会触发此事件
        /// </summary>
        public event LogWritedDelegate? OnLogWrite;
    }
}
