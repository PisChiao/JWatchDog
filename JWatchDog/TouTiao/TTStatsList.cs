using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWatchDog.TouTiao
{
#pragma warning disable CS8618
    public class Pagination
    {
        /// <summary>
        /// 
        /// </summary>
        public int total_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int total_page { get; set; }

    }



    public class Total_metrics
    {
        /// <summary>
        /// 
        /// </summary>
        public string deep_convert_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string cpm_platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ctr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string conversion_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string click_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string advertiser_valid_balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string deep_convert_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string conversion_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string stat_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string advertiser_balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string cpc_platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string show_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string convert_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string deep_convert_cnt { get; set; }

    }



    public class Metrics
    {
        public float attribution_next_day_open_cnt { get; set; }
        public float attribution_next_day_open_rate { get; set; }
        public float active { get; set; }
        public float active_cost { get; set; }
        public int active_pay { get; set; }
        public float stat_pay_amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float deep_convert_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float cpm_platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float ctr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float conversion_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float click_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float deep_convert_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float conversion_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float stat_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float cpc_platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float show_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float convert_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float deep_convert_cnt { get; set; }

    }



    public class Quota_infoItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string water_level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string used { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string quota_type { get; set; }

    }



    public class Stats_listItem
    {
        /// <summary>
        /// 
        /// </summary>
        public Metrics metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string advertiser_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int advertiser_role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string advertiser_balance { get; set; }

        /// <summary>
        /// 按日预算
        /// </summary>
        public string advertiser_budget_mode_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int advertiser_status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string advertiser_valid_balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string advertiser_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool advertiser_followed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int advertiser_budget_mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string advertiser_budget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string group_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Quota_infoItem> quota_info { get; set; }

    }



    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public Pagination pagination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Total_metrics total_metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Stats_listItem> stats_list { get; set; }

    }



    public class Extra
    {
    }



    public class TTStatsList
    {
        /// <summary>
        /// 
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Extra extra { get; set; }
        public void Add(TTStatsList aDStatsList)
        {
            data.pagination = aDStatsList.data.pagination;
            foreach (Stats_listItem aDStats in aDStatsList.data.stats_list)
            {
                data.stats_list.Add(aDStats);
            }
        }
    }
}
