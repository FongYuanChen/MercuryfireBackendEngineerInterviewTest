namespace MercuryfireBackendEngineerInterviewTest.Models.Responses
{
    /// <summary>
    /// 建立使用者基本資料之回傳結果
    /// </summary>
    public class MyOfficeAcpdCreateResponse
    {
        /// <summary>
        /// 新建立的使用者系統識別碼
        /// </summary>
        public string ACPD_SID { get; set; }

        /// <summary>
        /// 執行本次建立動作的操作者識別代碼
        /// </summary>
        public string NowID { get; set; }

        /// <summary>
        /// 本次 Stored Procedure 執行紀錄結果
        /// </summary>
        public string ExecuteLog { get; set; }
    }
}
