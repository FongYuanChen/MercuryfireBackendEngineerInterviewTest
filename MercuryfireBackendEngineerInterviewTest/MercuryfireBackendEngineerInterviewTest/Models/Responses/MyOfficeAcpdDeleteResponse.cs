namespace MercuryfireBackendEngineerInterviewTest.Models.Responses
{
    /// <summary>
    /// 刪除（軟刪除）使用者基本資料之回傳結果
    /// </summary>
    public class MyOfficeAcpdDeleteResponse
    {
        /// <summary>
        /// 本次被刪除（軟刪除）的使用者系統識別碼
        /// </summary>
        public string DeletedSID { get; set; }

        /// <summary>
        /// 執行本次刪除動作的操作者識別代碼
        /// </summary>
        public string UpdID { get; set; }

        /// <summary>
        /// 本次 Stored Procedure 執行紀錄結果
        /// </summary>
        public string ExecuteLog { get; set; }
    }
}
