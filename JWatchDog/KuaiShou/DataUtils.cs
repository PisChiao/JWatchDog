using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using JWatchDog.TouTiao.StatsList;
using JWatchDog.TouTiao;

namespace JWatchDog.KuaiShou
{
    internal static class DataUtils
    {
        public static Dictionary<string, string> ColNameToCode = new Dictionary<string, string> 
        {
            {"素材曝光数","click"},
            {"行为数","actionbarClick" },
            {"激活数","conversion" },
            {"激活单价","conversionCost" },
            {"关键行为数","keyAction" },
            {"关键行为成本","keyActionCost" },
            {"关键行为率","keyActionRatio" }
        };
        /// <summary>
        /// 在网络通讯日志中查询有用的那一条
        /// </summary>
        /// <param name="driver">已经打开数据页面的浏览器实例</param>
        /// <param name="needCols">所需的额外列，据此判定日志是否有用</param>
        /// <returns>对应日志的response</returns>
        public static string FindUsefulRequest(ref EdgeDriver driver, string[] needCols)
        {
            string[] needColsCode = TranslateCols(needCols);
            for(int i=0;i<10;i++)
            {
                IEnumerable<LogEntry>? logs = driver.Manage().Logs.GetLog("performance")?.Where(o => o.Message.Contains("rest/dsp/watch/home/account/search") && o.Message.Contains("\"method\":\"Network.responseReceived\""));
                if (logs == null || logs.Count() <= 0)
                {
                    Thread.Sleep(2000);
                    logs = driver.Manage().Logs.GetLog("performance")?.Where(o => o.Message.Contains("rest/dsp/watch/home/account/search") && o.Message.Contains("\"method\":\"Network.responseReceived\""));
                    continue;
                }
                logs = logs.Reverse();
                string requestId = "";
                foreach (LogEntry log in logs)
                {
                    JObject json = JObject.Parse(log.Message);
                    requestId = json!["message"]!["params"]!["requestId"]!.ToString();
                    var request = driver.ExecuteCdpCommand("Network.getRequestPostData", new Dictionary<string, object>() { { "requestId", requestId } }) as Dictionary<string, object>;
                    if (request is null)
                    {
                        Thread.Sleep(1000);
                        continue;
                    }
#pragma warning disable CS8604 // 引用类型参数可能为 null。
                    KSRequestPayload? payload = JsonConvert.DeserializeObject<KSRequestPayload>(request["postData"].ToString());
#pragma warning restore CS8604 // 引用类型参数可能为 null。
                    if (payload != null)
                    {

                        IEnumerable<string> needColsCount = needColsCode.Where((e) =>
                        {
                            if (payload.selectColumns.Contains(e))
                            {
                                return true;
                            }
                            else
                            { return false; }
                        });
                        if (needColsCount.Count() < needColsCode.Count())
                        {
                            requestId = "";
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (requestId == "")
                {
                    //requestId等于空表示没有获取到符合条件的log
                    Thread.Sleep(1000);
                    continue;
                }
                var response = driver.ExecuteCdpCommand("Network.getResponseBody", new Dictionary<string, object>() { { "requestId", requestId } }) as Dictionary<string, object>;
                if (response!.TryGetValue("body", out object? bodyObj))
                {
                    if (bodyObj is null || bodyObj.ToString() == "")
                    {
                        //返回值为空，表示请求还没有返回完成
                        Thread.Sleep(1000);
                        continue;
                    }
                    else
                    {
#pragma warning disable CS8603 // 可能返回 null 引用。
                        return bodyObj.ToString();
#pragma warning restore CS8603 // 可能返回 null 引用。
                    }
                }else
                {
                    //内容为空，表示请求还没收到返回
                    Thread.Sleep(1000);
                    continue;
                }
            }
            return "";
        }
        private static string[] TranslateCols(string[] colsName)
        {
            List<string> colsCode = new List<string>();
            foreach (string colName in colsName)
            {
                colsCode.Add(ColNameToCode[colName]);
            }
            return colsCode.ToArray();
        }
    }
}
