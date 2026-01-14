namespace MercuryfireBackendEngineerInterviewTest.Models.Responses
{
    /// <summary>
    /// 查詢使用者基本資料之回傳結果
    /// </summary>
    public class MyOfficeAcpdQueryResponse
    {
        /// <summary>
        /// ACPD 系統代碼
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
        /// 狀況 0=正常 , 99=不正常
        /// </summary>
        public byte ACPD_Status { get; set; }

        /// <summary>
        /// 是否停用/不可登入
        /// </summary>
        public bool ACPD_Stop { get; set; }

        /// <summary>
        /// 停用原因
        /// </summary>
        public string ACPD_StopMemo { get; set; }

        /// <summary>
        /// 登入帳號
        /// </summary>
        public string ACPD_LoginID { get; set; }

        /// <summary>
        /// 登入密碼
        /// </summary>
        public string ACPD_LoginPWD { get; set; }

        /// <summary>
        ///  備註
        /// </summary>
        public string ACPD_Memo { get; set; }
    }
}
