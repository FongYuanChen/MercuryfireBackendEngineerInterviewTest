using MercuryfireBackendEngineerInterviewTest.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MercuryfireBackendEngineerInterviewTest.Controllers
{
    /// <summary>
    /// Myoffice_ACPD 相關API
    /// </summary>
    [Route("api/myoffice/acpd")]
    [ApiController]
    public class MyOfficeAcpdController : ControllerBase
    {
        private readonly IMyOfficeAcpdRepository _myOfficeAcpdRepository;

        public MyOfficeAcpdController(IMyOfficeAcpdRepository myOfficeAcpdRepository)
        {
            _myOfficeAcpdRepository = myOfficeAcpdRepository;
        }

        /// <summary>
        /// 建立 Myoffice_ACPD 使用者基本資訊
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] string json = "{\"ACPD_Cname\": \"王小明\",\"ACPD_Ename\": \"Ming Wang\",\"ACPD_Sname\": \"Ming\",\"ACPD_Email\": \"ming@test.com\",\"ACPD_LoginID\": \"ming01\",\"ACPD_LoginPWD\": \"123456\",\"ACPD_Memo\": \"測試帳號\",\"ACPD_NowID\": \"ADMIN\"}")
        {
            return Ok(await _myOfficeAcpdRepository.CreateAsync(json));
        }

        /// <summary>
        /// 刪除 Myoffice_ACPD 使用者基本資訊（軟刪除）
        /// </summary>
        /// <param name="acpdSid"></param>
        /// <returns></returns>
        [HttpDelete("{acpdSid}")]
        public async Task<IActionResult> Delete(char acpdSid)
        {
            return Ok(await _myOfficeAcpdRepository.DeleteAsync(acpdSid));
        }

    }
}
