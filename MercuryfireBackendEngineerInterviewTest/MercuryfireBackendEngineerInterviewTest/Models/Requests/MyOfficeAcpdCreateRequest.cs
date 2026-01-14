namespace MercuryfireBackendEngineerInterviewTest.Models.Requests
{
    /// <summary>
    /// 建立使用者基本資料之請求
    /// </summary>
    public class MyOfficeAcpdCreateRequest
    {
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
        /// 執行本次建立動作的操作者識別代碼
        /// </summary>
        public string ACPD_NowID { get; set; }
    }
}
