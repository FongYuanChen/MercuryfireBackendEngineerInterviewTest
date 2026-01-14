using MercuryfireBackendEngineerInterviewTest.Models.Requests;
using MercuryfireBackendEngineerInterviewTest.Models.Responses;

namespace MercuryfireBackendEngineerInterviewTest.Interfaces
{
    /// <summary>
    /// MyOffice ACPD 資料存取層介面
    /// </summary>
    public interface IMyOfficeAcpdRepository
    {
        /// <summary>
        /// 依條件查詢使用者基本資料
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<List<MyOfficeAcpdQueryResponse>> GetAsync(MyOfficeAcpdQueryRequest request);

        /// <summary>
        /// 建立一筆新的使用者基本資料
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<MyOfficeAcpdCreateResponse> CreateAsync(MyOfficeAcpdCreateRequest request);

        /// <summary>
        /// 更新既有的使用者基本資料
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<MyOfficeAcpdUpdateResponse> UpdateAsync(MyOfficeAcpdUpdateRequest request);

        /// <summary>
        /// 刪除一筆使用者基本資料
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<MyOfficeAcpdDeleteResponse> DeleteAsync(MyOfficeAcpdDeleteRequest request);
    }
}
