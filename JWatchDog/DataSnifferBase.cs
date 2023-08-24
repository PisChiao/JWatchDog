using JWatchDog.TouTiao;
using JWatchDog.TouTiao.StatsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWatchDog
{
    public abstract class DataSnifferBase
    {
        public Logger logger = new Logger().Instance;
        /// <summary>
        /// 浏览器插件缓存目录，默认为./Cache
        /// </summary>
        public string CacheDir { get; set; } = System.Environment.CurrentDirectory + "\\Cache\\";
        /// <summary>
        /// 浏览器插件所用通讯端口，默认0为随机
        /// </summary>
        public int BrowerPort { get; set; } = 0;

        /// <summary>
        /// 构建一个新的DataSnifer对象
        /// </summary>
        /// <param name="cacheDir">浏览器缓存目录</param>
        /// <param name="browerPort">通讯端口</param>
        public DataSnifferBase(string cacheDir, int browerPort)
        {
            CacheDir = cacheDir;
            BrowerPort = browerPort;
        }
        public DataSnifferBase()
        {
            CacheDir = System.Environment.CurrentDirectory + "\\Cache\\";
            BrowerPort = 0;
        }

    }
}
