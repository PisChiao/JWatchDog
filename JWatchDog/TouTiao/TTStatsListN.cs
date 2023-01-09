using JWatchDog.TouTiao.StatsList;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWatchDog.TouTiao
{
#pragma warning disable CS8618
    public class Quota_infoItem
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal water_level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal sum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal used { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string quota_type { get; set; }

    }



    public class Data_listItem
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal advertiser_id { get; set; }

        /// <summary>
        /// 在投-麦迪克-ios-02户-02mdk
        /// </summary>
        public string advertiser_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal advertiser_status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string advertiser_budget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal advertiser_budget_mode { get; set; }

        /// <summary>
        /// 不限
        /// </summary>
        public string advertiser_budget_mode_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string advertiser_agent_id { get; set; }

        /// <summary>
        /// 麦芽成长-其它行业
        /// </summary>
        public string advertiser_agent_name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double advertiser_balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double advertiser_valid_balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double advertiser_grant_balance_valid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal advertiser_not_grant_balance_valid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string advertiser_followed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal group_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Quota_infoItem> quota_info { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal form_submit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_decimalerflow_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_7days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal pre_loan_credit_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_gift_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal pre_convert_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_share_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal valid_play_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal live_pay_order_cost_per_order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal convert_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal wechat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal redirect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_order_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal valid_play { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_click_product_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_2days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_count_by_author_30days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_uv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_pay_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attach_creative_click_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_pay_succeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_register_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_credit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_enter_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal pay_amount_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal total_play { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_active_pay_7d_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_5days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal first_order_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_credit_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_count_by_author_15days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_start_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_comment_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal pre_convert_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_pay_amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal oto_stay_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal qq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal button { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_confirm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal submit_certification_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_cart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_pay_7d_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal shake_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_deep_convert_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_high_decimalention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal next_day_open { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal view { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal game_addiction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_6days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_customer_effective_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal game_addiction_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_completion_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_pay_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal poi_address_click { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_50_feed_break { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_count_by_author_3days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_duration_3s { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_4days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_start_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal install_finish_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal oto_pay_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_75_feed_break { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal conversion_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_call_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal coupon_addition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal redirect_to_shop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal install_finish_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_gift_amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal customer_effective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal ad_report_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_customer_effective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_order_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_next_day_open_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_over_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal download_start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal cpm_platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_call_dy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal dy_like { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_8days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal average_play_time_per_play { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_conversion_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal ies_challenge_click { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal commute_first_pay_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_confirm_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_start_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_next_day_open_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal show_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_completion_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_pay_gmv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal dy_share { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal ctr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_deep_convert_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal game_pay_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_3days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal deep_convert_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal live_valid_duration_average { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_4days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal dy_home_visited { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal card_show { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_convert_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal consult_effective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal coupon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_1day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_register_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_landing_page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal conversion_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal download_finish_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal vote { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal poi_collect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_stat_cost_by_author_15days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_high_decimalention_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal lottery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_7d_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_active_pay_7d_per_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal message_action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_stat_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal download_finish_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_day_acitve_pay_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_cash_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_credit_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal phone_connect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal shopping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal form { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_convert_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_slidecart_click_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal ad_dislike_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal wifi_play_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_decimalerflow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal consult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal union_roi_0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal union_roi_3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_7d_ltv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal game_addiction_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal union_roi_7 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_pay_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_stat_cost_by_author_7days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_pay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_day_acitve_pay_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal dy_comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_5days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_0d_ltv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal dy_follow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_count_by_author_7days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_pay_7d_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_download { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal pre_loan_credit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_3d_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal form_click_button { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_pay_succeed_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_0d_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_8days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attach_creative_show_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal valid_play_of_mille { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal deep_convert_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal install_finish_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_3d_ltv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal cpc_platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal live_fans_club_join_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal first_rental_order_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal ies_music_click { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_day_acitve_pay_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal coupon_single_page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_order_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_stat_cost_by_author_30days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal approval_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal pre_convert_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal valid_play_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal live_watch_one_minute_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_order_stat_amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_next_day_open_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_99_feed_break { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_grant_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal download_finish_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal phone_effective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_detail_uv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal map { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_7days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_order_gmv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_counsel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_2days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal phone_confirm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal location_click { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal game_pay_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_active_pay_7d_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_shopwindow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_6days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal valid_play_cost_of_mille { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_1day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_25_feed_break { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_pay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_3days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_follow_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_active_pay_7d_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_stat_cost_by_author_3days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_union_ltv_0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_register { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_union_ltv_3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal consult_clue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal deep_convert_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_union_ltv_7 { get; set; }

    }



    public class Total_metrics
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal form_submit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_decimalerflow_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double advertiser_valid_balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_7days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal pre_loan_credit_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_gift_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double pre_convert_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_share_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double valid_play_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal live_pay_order_cost_per_order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal convert_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal wechat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal redirect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_order_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal valid_play { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_click_product_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_2days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_count_by_author_30days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_uv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_pay_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attach_creative_click_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_pay_succeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_register_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_credit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_enter_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal pay_amount_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal total_play { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_active_pay_7d_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_5days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal first_order_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_credit_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_count_by_author_15days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double click_start_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double advertiser_balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_comment_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal pre_convert_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_pay_amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal oto_stay_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal qq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double active_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal button { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double advertiser_grant_balance_valid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_confirm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal submit_certification_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_cart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double attribution_game_pay_7d_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal shake_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double attribution_deep_convert_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_high_decimalention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal next_day_open { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal view { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal game_addiction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_6days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_customer_effective_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal game_addiction_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double active_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_completion_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double active_pay_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal poi_address_click { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_50_feed_break { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_count_by_author_3days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_duration_3s { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_4days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_start_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double install_finish_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal oto_pay_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_75_feed_break { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double conversion_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_call_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal coupon_addition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal redirect_to_shop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double install_finish_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_gift_amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal customer_effective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal ad_report_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_customer_effective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_order_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double attribution_next_day_open_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_over_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal download_start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double cpm_platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_call_dy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal dy_like { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_8days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double average_play_time_per_play { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double attribution_conversion_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal ies_challenge_click { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal commute_first_pay_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_confirm_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double click_start_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_next_day_open_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal show_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_completion_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_pay_gmv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal dy_share { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double ctr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_deep_convert_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double game_pay_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_3days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double deep_convert_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal live_valid_duration_average { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_4days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal dy_home_visited { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal card_show { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double attribution_convert_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal consult_effective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double advertiser_not_grant_balance_valid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal coupon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_1day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_register_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_landing_page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double conversion_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double download_finish_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal vote { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal poi_collect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_stat_cost_by_author_15days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_high_decimalention_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal lottery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_7d_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double attribution_active_pay_7d_per_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal message_action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_stat_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double download_finish_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double attribution_day_acitve_pay_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double stat_cash_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_credit_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal phone_connect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal shopping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal form { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_convert_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_slidecart_click_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal ad_dislike_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double wifi_play_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_decimalerflow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal consult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal union_roi_0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal union_roi_3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_7d_ltv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal game_addiction_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal union_roi_7 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_pay_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_stat_cost_by_author_7days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_pay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double attribution_day_acitve_pay_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal dy_comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_5days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_0d_ltv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal dy_follow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_count_by_author_7days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal loan_completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_pay_7d_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_download { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal pre_loan_credit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_3d_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal form_click_button { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_clue_pay_succeed_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_0d_roi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_8days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attach_creative_show_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double valid_play_of_mille { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double deep_convert_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal install_finish_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_micro_game_3d_ltv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double cpc_platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal live_fans_club_join_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal first_rental_order_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal ies_music_click { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_day_acitve_pay_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal coupon_single_page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_order_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_stat_cost_by_author_30days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal approval_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double pre_convert_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double valid_play_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal live_watch_one_minute_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_order_stat_amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double attribution_next_day_open_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double stat_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_99_feed_break { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_grant_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal download_finish_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal phone_effective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_detail_uv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal map { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_7days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_order_gmv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_counsel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_2days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal phone_confirm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal location_click { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal game_pay_count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double attribution_active_pay_7d_cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal click_shopwindow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_6days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double valid_play_cost_of_mille { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_roi_1day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal play_25_feed_break { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal in_app_pay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal attribution_game_in_app_ltv_3days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_follow_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double attribution_active_pay_7d_rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal luban_live_pay_order_stat_cost_by_author_3days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_union_ltv_0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal active_register { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_union_ltv_3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal consult_clue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal deep_convert_cnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal stat_union_ltv_7 { get; set; }

    }



    public class Pagination
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool hasMore { get; set; }

    }



    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Data_listItem> data_list { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Total_metrics total_metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Pagination pagination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string download_id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal download_channel { get; set; }

    }



    public class Extra
    {
    }



    public class TTStatsListN
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Extra extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string request_id { get; set; }

        /// <summary>
        /// 将一个新的TTStatsList合并到当前的对象中
        /// </summary>
        /// <param name="aStatsList">要加入的新TTStatsList</param>
        public void Add(TTStatsListN aStatsList)
        {
            data.pagination = aStatsList.data.pagination;
            foreach (Data_listItem aDStats in aStatsList.data.data_list)
            {
                data.data_list.Add(aDStats);
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }


}
