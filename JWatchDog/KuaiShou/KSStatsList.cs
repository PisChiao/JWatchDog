using JWatchDog.TouTiao;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWatchDog.KuaiShou
{
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
    public class PageInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal currentPage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal pageSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal totalCount { get; set; }
    }

    public class AccountBalance
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal totalBalance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal cashBalance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal contractRebate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal preRebate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal postRebate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal directRebate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal creditBalance { get; set; }
    }

    public class HourChargedItem
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal hourTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal charged { get; set; }
    }

    public class AdDspPhotoQuotaView
    {
        /// <summary>
        /// 
        /// </summary>
        public string showStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal availableCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal quotaCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isInQuotaScope { get; set; }
    }

    public class AdjustPriceCaliber
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal firstDayRoi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal miniAppRoi { get; set; }
    }

    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal reportDate { get; set; }
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
        public decimal secondaryIndustryId { get; set; }
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
        public decimal eventPayPurchaseAmountFirstDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventPayPurchaseAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal conversionCost { get; set; }
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
        public decimal keyActionCost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal keyActionRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventPayPurchaseAmountOneDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal eventPayPurchaseAmountOneDayRoi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string adLiveShare { get; set; }
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
        public decimal userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string overDeliverControl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal accountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal corporationId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string accountName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string productName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal budget { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal totalBalance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public AccountBalance accountBalance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal onCampaignNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal onUnitNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal onCreativeNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal balanceStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal avgCharged { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<HourChargedItem> hourCharged { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string currentAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal dupPhotoRatio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal todayNewCampaignNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal todayNewUnitNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal todayNewCreativeNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unitReviewStats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string creativeReviewStats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string proCreativeReviewStats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string chargedYoy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string chargedYoyByWeek { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string conversionNumDoD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string conversionNumCostDoD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public AdDspPhotoQuotaView adDspPhotoQuotaView { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string priorityEffectAccountSwitch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string overBudgetControlSwitch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal deliveryType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public AdjustPriceCaliber adjustPriceCaliber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string miniRoiAdjustPriceCaliber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string firstDayRoiAdjustPriceCaliber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ocpmMinCostUser { get; set; }
    }

    public class KSStatsList
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PageInfo? pageInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<DataItem>? data { get; set; }

        public void Add(KSStatsList aStatsList)
        {
            pageInfo = aStatsList.pageInfo;
            foreach (DataItem aDStats in aStatsList.data!)
            {
                data!.Add(aDStats);
            }
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
