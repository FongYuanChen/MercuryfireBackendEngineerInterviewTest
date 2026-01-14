namespace MercuryfireBackendEngineerInterviewTest.Models.Requests
{
    /// <summary>
    /// 刪除（軟刪除）使用者基本資料之請求
    /// </summary>
    public class MyOfficeAcpdDeleteRequest
    {
        /// <summary>
        /// 本次欲刪除（軟刪除）的使用者系統識別碼
        /// </summary>
        public string ACPD_SID { get; set; }

        /// <summary>
        /// 刪除（軟刪除）備註
        /// </summary>
        public string ACPD_StopMemo { get; set; }

        /// <summary>
        /// 執行本次刪除動作的操作者識別代碼
        /// </summary>
        public string ACPD_UpdID { get; set; }
    }
}
