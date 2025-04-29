using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWatchDog.KuaiShou
{
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。

    public class SumItem
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal targetId { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public string dataId { get; set; }
        /// <summary>
        /// 全部
        /// </summary>
        public string targetLevelName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal reportHour { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal viewStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string viewStatusReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal totalCharge { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal click { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal actionbarClick { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal conversion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string eventPayPurchaseAmountFirstDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string eventPayPurchaseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double actionCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double conversionCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventPayWeightedPurchaseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventPayWeightedPurchaseAmountFirstDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventPayWeightedRoi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventPayFirstDayWeightedRoi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal keyAction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double keyActionCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double keyActionRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal adItemClick { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adLiveShare { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string conversionCostLower { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string conversionCostUpper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string backflowPrompt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adPlayedUv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adRewardCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adToProfileCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string addecimaleractiveCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adLivePlayedTotal60sCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adLivePlayed5sCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kuaishouComponentImpressionCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kuaishouComponentClickCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string addecimaleractiveCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string orderLiveRecoFansRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string photoRecoFansRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kuaishouComponentClickRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kuaishouComponentClickCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adPlayedCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adLivePlayed5sCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mcbLeftTimePerfCpaBid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mcbLeftTimePerfRoiRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mcbAllDayPerfCpaBid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mcbAllDayPerfRoiRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string privateMessageSentCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string leadsSubmitCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string leadsSubmit1dCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string leadsSubmit30dCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string leadSubmitConversionCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal playedNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string localStoreOrderPaidCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string localStoreOrderPaid1dCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string localStoreOrderPaid30dCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string localStoreOrderConversionCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adScene { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string placementType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string perspective { get; set; }
        /// <summary>
        /// 全部
        /// </summary>
        public string chargeMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal chargeModeNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reportDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reportDateHour { get; set; }
    }

    public class ResultListItem
    {
        public string accountName { get; set; }
        public string productName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal targetId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dataId { get; set; }
        /// <summary>
        /// 全部
        /// </summary>
        public string targetLevelName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal reportHour { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal viewStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string viewStatusReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal totalCharge { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal click { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal actionbarClick { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal conversion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string eventPayPurchaseAmountFirstDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double eventPayPurchaseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double actionCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double conversionCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double eventPayRoi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventNewUserPay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double eventNewUserPayCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double eventNewUserPayRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventAppInvoked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventPayWeightedPurchaseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventPayWeightedPurchaseAmountFirstDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventPayWeightedRoi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventPayFirstDayWeightedRoi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal keyAction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double keyActionCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double keyActionRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal adItemClick { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adLiveShare { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string conversionCostLower { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string conversionCostUpper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string backflowPrompt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adPlayedUv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adRewardCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adToProfileCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string addecimaleractiveCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adLivePlayedTotal60sCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adLivePlayed5sCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kuaishouComponentImpressionCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kuaishouComponentClickCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string addecimaleractiveCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string orderLiveRecoFansRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string photoRecoFansRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kuaishouComponentClickRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kuaishouComponentClickCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adPlayedCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adLivePlayed5sCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mcbLeftTimePerfCpaBid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mcbLeftTimePerfRoiRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mcbAllDayPerfCpaBid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mcbAllDayPerfRoiRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string privateMessageSentCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string leadsSubmitCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string leadsSubmit1dCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string leadsSubmit30dCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string leadSubmitConversionCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal playedNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string localStoreOrderPaidCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string localStoreOrderPaid1dCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string localStoreOrderPaid30dCnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string localStoreOrderConversionCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal adLandingPageFromSubmitted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventJs3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventFormSubmit { get; set; }
        /// <summary>
        /// 全部
        /// </summary>
        public string adScene { get; set; }
        /// <summary>
        /// 全部
        /// </summary>
        public string placementType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string perspective { get; set; }
        /// <summary>
        /// 全部
        /// </summary>
        public string chargeMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal chargeModeNew { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal accountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal campaignId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string campaignName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal unitId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unitName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal creativeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string creativeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string creativeMaterialType { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string creativeMaterialTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unitType { get; set; }
        /// <summary>
        /// 程序化创意
        /// </summary>
        public string unitTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string campaignType { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string campaignTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string queryAdType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string queryAdTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal adPutType { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string adPutTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal adCreateSource { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string adCreateSourceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string materialContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string materialName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string materialSignature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string bidType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string createSourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ocpxActionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ocpxActionTypeName { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string ocpcActionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ocpcActionTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string deepConversionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string deepConversionTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string picId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string photoId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string aigcMaterial { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string customCity { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string gender { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string customGender { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string ageSegment { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string customAgeSegment { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string platform { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string jingleBellId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string jingleBellName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string liveStreamId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string liveStartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string liveEndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal winfoId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string word { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string matchType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string query { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pageId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pageName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string groupId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string groupType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string groupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string imgCoverUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dpaProductId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dpaProductName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string libraryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string libraryName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dpaType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dpaTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string putStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string putStatusName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dpaCreateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dpaUpDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string theme { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string subIndustryName { get; set; }
        /// <summary>
        /// 全部
        /// </summary>
        public string resourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kolUserType { get; set; }
        /// <summary>
        /// 其他
        /// </summary>
        public string kolUserTypeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string authorId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reportDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reportDateHour { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reportDateDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reportDateWeek { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reportDateMonth { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public PageInfo pageInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SumItem> sum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ResultListItem> resultList { get; set; }
    }

    public class KSReportDetail
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hostName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string traceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }

        public void Add(KSReportDetail aReport)
        {
            data.pageInfo = aReport.data.pageInfo;
            foreach (ResultListItem aData in aReport.data.resultList!)
            {
                data.resultList!.Add(aData);
            }
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
