using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWatchDog.KuaiShou
{
    #pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
    
    public class SearchParam
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> accountIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string accountName { get; set; }
    }

    public class Identity
    {
        /// <summary>
        /// 
        /// </summary>
        public List<decimal> corporationIds { get; set; }
    }

    public class KSRequestPayload
    {
        /// <summary>
        /// 
        /// </summary>
        public PageInfo pageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SearchParam searchParam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> selectColumns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal startTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal endTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Identity identity { get; set; }
    }
}
