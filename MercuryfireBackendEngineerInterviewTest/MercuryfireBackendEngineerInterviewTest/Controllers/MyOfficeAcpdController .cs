using MercuryfireBackendEngineerInterviewTest.Interfaces;
using MercuryfireBackendEngineerInterviewTest.Models.Requests;
using MercuryfireBackendEngineerInterviewTest.Models.Responses;
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
        /// 查尋全部使用者基本資訊
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<MyOfficeAcpdQueryResponse>>> GetAll()
        {
            var request = new MyOfficeAcpdQueryRequest();
            return Ok(await _myOfficeAcpdRepository.GetAsync(request));
        }

        /// <summary>
        /// 查尋特定使用者基本資訊
        /// </summary>
        /// <param name="acpdSid"></param>
        /// <returns></returns>
        [HttpGet("{acpdSid}")]
        public async Task<ActionResult<MyOfficeAcpdQueryResponse>> GetBySid(string acpdSid)
        {
            var request = new MyOfficeAcpdQueryRequest { ACPD_SID = acpdSid };
            return Ok((await _myOfficeAcpdRepository.GetAsync(request))?.FirstOrDefault());
        }

        /// <summary>
        /// 建立使用者基本資訊
        /// </summary>
        /// <remarks>
        /// 範例 JSON:
        /// {
        ///   "acpD_CName": "王小明",
        ///   "acpD_EName": "Ming Wang",
        ///   "acpD_SName": "Ming",
        ///   "acpD_Email": "ming@test.com",
        ///   "acpD_LoginID": "ming01",
        ///   "acpD_LoginPWD": "123456",
        ///   "acpD_Memo": "測試帳號",
        ///   "acpD_NowID": "admin"
        /// }
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<MyOfficeAcpdCreateResponse>> Create([FromBody] MyOfficeAcpdCreateRequest request)
        {
            return Ok(await _myOfficeAcpdRepository.CreateAsync(request));
        }

        /// <summary>
        /// 更新使用者基本資訊
        /// </summary>
        /// <remarks>
        /// 範例 JSON:
        /// {
        ///   "acpD_SID": "0Q014681127674302152",
        ///   "acpD_CName": "王小明-1",
        ///   "acpD_EName": "Ming Wang-1",
        ///   "acpD_SName": "小明-1",
        ///   "acpD_Email": "ming-1@test.com",
        ///   "acpD_LoginID": "ming01-1",
        ///   "acpD_LoginPWD": "123456-1",
        ///   "acpD_Memo": "測試帳號-1",
        ///   "acpD_UpdID": "admin"
        /// }
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult<MyOfficeAcpdUpdateResponse>> Update([FromBody] MyOfficeAcpdUpdateRequest request)
        {
            return Ok(await _myOfficeAcpdRepository.UpdateAsync(request));
        }

        /// <summary>
        /// 刪除使用者基本資訊（軟刪除）
        /// </summary>
        /// <remarks>
        /// 範例 JSON:
        /// {
        ///   "acpD_SID": "0Q014681127674302152",
        ///   "acpD_StopMemo": "使用者刪除帳號",
        ///   "acpD_UpdID": "admin"
        /// }
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ActionResult<MyOfficeAcpdDeleteResponse>> Delete([FromBody] MyOfficeAcpdDeleteRequest request)
        {
            return Ok(await _myOfficeAcpdRepository.DeleteAsync(request));
        }
    }
}
