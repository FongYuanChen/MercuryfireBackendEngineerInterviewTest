namespace MercuryfireBackendEngineerInterviewTest.Models.Requests
{
    /// <summary>
    /// 查詢使用者基本資料之請求
    /// </summary>
    public class MyOfficeAcpdQueryRequest
    {
        /// <summary>
        /// 要查詢的 ACPD_SID，空值表示查全部
        /// </summary>
        public string ACPD_SID { get; set; }

        // TODO: 之後可以補其他查詢欄位
    }
}
