using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JWatchDog.TouTiao
{
    public static class OptCols
    {
        private static Logger logger = new Logger().Instance;
        /// <summary>
        /// 检测一个列是否存在，如果不存在就增加这个列
        /// </summary>
        /// <param name="driver">浏览器驱动器</param>
        /// <param name="colName">列名</param>
        /// <returns></returns>
        public static bool NeedCol(ref ChromeDriver driver, string colName)
        {
            try
            {
                IWebElement sec_cnt_col = driver.FindElements(By.ClassName("table-header")).Where(o => o.GetAttribute("outerText") == colName).First();
                if (sec_cnt_col is not null)
                {
                    return true;
                }
                else
                {
                    throw new Exception("所需列不存在，准备添加。");
                }
            }
            catch (Exception ex)
            {
                logger.Write("正在添加不存在的列：" + colName);
                try
                {
                    TryAddCol(ref driver, colName);
                    return true;
                }
                catch (Exception ex2)
                {

                    logger.Write("检测列错误：" + ex2.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// 试图增加一个列，注意如果列已存在则会去除此列
        /// </summary>
        /// <param name="driver">浏览器驱动器</param>
        /// <param name="colName">列名</param>
        public static void TryAddCol(ref ChromeDriver driver, string colName)
        {
            IWebElement colConfig = driver.FindElement(By.ClassName("bui-icon-_promotion_cols"));
            driver.ExecuteScript("arguments[0].click();", colConfig);
            IWebElement colSelect = driver.FindElements(By.ClassName("bui-checkbox-input-label")).Where(o => o.GetAttribute("outerText") == colName).First();
            driver.ExecuteScript("arguments[0].click();", colSelect);
            IWebElement confirmBtn = driver.FindElement(By.ClassName("emit-btn"));
            driver.ExecuteScript("arguments[0].click();", confirmBtn);
            // 等待加载完成或超时之后再返回
            for (int i = 0; i < 10; i++)
            {
                IWebElement loading = driver.FindElement(By.ClassName("byted-loading"));
                if (loading.GetCssValue("display") == "none")
                {
                    break;
                }
                Thread.Sleep(3000);
            }
            return;
        }
    }

}
