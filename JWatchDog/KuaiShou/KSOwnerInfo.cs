﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWatchDog.KuaiShou
{
    public class AccountInfosItem
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal accountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? accountName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal agentUserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? agentName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int accessMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int appId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int createSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int reviewStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? reviewDetail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal registerTime { get; set; }
    }

    public class KSOwnerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public int result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<AccountInfosItem>? accountInfos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? url { get; set; }
    }
}
