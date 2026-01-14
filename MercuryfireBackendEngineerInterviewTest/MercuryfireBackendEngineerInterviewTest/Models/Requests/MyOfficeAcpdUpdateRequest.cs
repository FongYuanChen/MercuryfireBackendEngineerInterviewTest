namespace MercuryfireBackendEngineerInterviewTest.Models.Requests
{
    /// <summary>
    /// 更新使用者基本資料之請求
    /// </summary>
    public class MyOfficeAcpdUpdateRequest
    {
        /// <summary>
        /// 本次欲更新的使用者系統識別碼
        /// </summary>
        public string ACPD_SID { get; set; }

        /// <summary>
        /// 中文名稱
        /// </summary>
        public string ACPD_CName { get; set; }

        /// <summary>
        /// 英文名稱
        /// </summary>
        public string ACPD_EName { get; set; }

        /// <summary>
        /// 簡稱
        /// </summary>
        public string ACPD_SName { get; set; }

        /// <summary>
        /// 使用者信箱
        /// </summary>
        public string ACPD_Email { get; set; }

        /// <summary>
        /// 登入帳號
        /// </summary>
        public string ACPD_LoginID { get; set; }

        /// <summary>
        /// 登入密碼
        /// </summary>
        public string ACPD_LoginPWD { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        public string ACPD_Memo { get; set; }

        /// <summary>
        /// 執行本次更新動作的操作者識別代碼
        /// </summary>
        public string ACPD_UpdID { get; set; }
    }
}
