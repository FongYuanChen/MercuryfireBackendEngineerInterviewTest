namespace MercuryfireBackendEngineerInterviewTest.Models.Responses
{
    /// <summary>
    /// 更新使用者基本資料之回傳結果
    /// </summary>
    public class MyOfficeAcpdUpdateResponse
    {
        // <summary>
        /// 本次被更新的使用者系統識別碼
        /// </summary>
        public string UpdatedSID { get; set; }

        /// <summary>
        /// 執行本次更新動作的操作者識別代碼
        /// </summary>
        public string UpdID { get; set; }

        /// <summary>
        /// 本次 Stored Procedure 執行紀錄結果
        /// </summary>
        public string ExecuteLog { get; set; }
    }
}
