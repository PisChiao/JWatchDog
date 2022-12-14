using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JWatchDog
{
    public static class IniFile
    {
        // Windows API 参考手册
        // http://www.office-cn.net/t/api/index.html?writeprivateprofilestring.htm

        [DllImport("kernel32")]
        private static extern byte WritePrivateProfileString(string section, string? key, string? val, string filePath);
       
        [DllImport("kernel32")]
        private static extern uint GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, uint size, string filePath);
        
        [DllImport("kernel32")]
        private static extern uint GetPrivateProfileStringA(string? section, string? key, string defVal, byte[] retVal, uint size, string filePath);



        /// <summary>
        /// 写
        /// </summary>
        /// <param name="filePath">ini文件的路径。示例：H:\学习\C#\示例\Demo.ini</param>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <returns>true表示写入成功，false表示写入失败</returns>
        public static bool Write(string filePath, string section, string key, string? val)
        {
            var value = WritePrivateProfileString(section, key, val, filePath);

            if (value != 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 删键
        /// </summary>
        /// <param name="filePath">ini文件的路径。示例：H:\学习\C#\示例\Demo.ini</param>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns>true表示写入成功，false表示写入失败</returns>
        public static bool DeleteKey(string filePath, string section, string key)
        {
            var value = WritePrivateProfileString(section, key, null, filePath);

            if (value != 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 删段
        /// </summary>
        /// <param name="filePath">ini文件的路径。示例：H:\学习\C#\示例\Demo.ini</param>
        /// <param name="section"></param>
        /// <returns>true表示写入成功，false表示写入失败</returns>
        public static bool DeleteSection(string filePath, string section)
        {
            var value = WritePrivateProfileString(section, null, null, filePath);

            if (value != 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 读值
        /// </summary>
        /// <param name="filePath">ini文件的路径。示例：H:\学习\C#\示例\Demo.ini</param>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string ReadValue(string filePath, string section, string key)
        {
            StringBuilder str = new StringBuilder(256);
            var charLength = GetPrivateProfileString(section, key, "", str, 256, filePath);
            return str.ToString();
        }

        /// <summary>
        /// 读段
        /// </summary>
        /// <param name="filePath">ini文件的路径。示例：H:\学习\C#\示例\Demo.ini</param>
        /// <returns></returns>
        public static List<string> ReadSections(string filePath)
        {
            List<string> sections = new List<string>();
            byte[] buf = new byte[65535];
            var charLength = GetPrivateProfileStringA(null, null, "", buf, 65535, filePath);

            int j = 0;
            for (int i = 0; i < charLength; i++)
            {
                if (buf[i] == 0)
                {
                    sections.Add(Encoding.Default.GetString(buf, j, i - j));
                    j = i + 1;
                }
            }

            return sections;
        }

        /// <summary>
        /// 读键
        /// </summary>
        /// <param name="filePath">ini文件的路径。</param>
        /// <param name="section"></param>
        /// <returns></returns>
        public static List<string> ReadKeys(string filePath, string section)
        {
            List<string> keys = new List<string>();
            byte[] buf = new byte[65535];
            var charLength = GetPrivateProfileStringA(section, null, "", buf, 65535, filePath);

            int j = 0;
            for (int i = 0; i < charLength; i++)
            {
                if (buf[i] == 0)
                {
                    keys.Add(Encoding.Default.GetString(buf, j, i - j));
                    j = i + 1;
                }
            }

            return keys;
        }

    }
}
