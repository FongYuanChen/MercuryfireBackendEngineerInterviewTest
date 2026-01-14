using MercuryfireBackendEngineerInterviewTest.Interfaces;
using MercuryfireBackendEngineerInterviewTest.Models.Requests;
using MercuryfireBackendEngineerInterviewTest.Models.Responses;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;

namespace MercuryfireBackendEngineerInterviewTest.Services
{
    public class UserRepository : IMyOfficeAcpdRepository
    {
        private readonly string _connectionString;

        public UserRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("BackendExamHub");
        }

        public async Task<List<MyOfficeAcpdQueryResponse>> GetAsync(MyOfficeAcpdQueryRequest request)
        {
            var requestJson = JsonSerializer.Serialize(request);
            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand("dbo.sp_MyOffice_ACPD_Query_JSON", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@ActionJSON", SqlDbType.NVarChar)
            {
                Value = requestJson
            });
            await connection.OpenAsync();
            var responseJson = (await command.ExecuteScalarAsync())?.ToString() ?? string.Empty;
            return JsonSerializer.Deserialize<List<MyOfficeAcpdQueryResponse>>(responseJson);
        }

        public async Task<MyOfficeAcpdCreateResponse> CreateAsync(MyOfficeAcpdCreateRequest request)
        {
            var requestJson = JsonSerializer.Serialize(request);
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("dbo.sp_MyOffice_ACPD_Create_JSON", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@ActionJSON", SqlDbType.NVarChar)
            {
                Value = requestJson
            });
            await connection.OpenAsync();
            var responseJson = (await command.ExecuteScalarAsync())?.ToString() ?? string.Empty;
            return JsonSerializer.Deserialize<MyOfficeAcpdCreateResponse>(responseJson);
        }

        public async Task<MyOfficeAcpdUpdateResponse> UpdateAsync(MyOfficeAcpdUpdateRequest request)
        {
            var requestJson = JsonSerializer.Serialize(request);
            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand("dbo.sp_MyOffice_ACPD_Update_JSON", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@ActionJSON", SqlDbType.NVarChar)
            {
                Value = requestJson
            });
            await connection.OpenAsync();
            var responseJson = (await command.ExecuteScalarAsync())?.ToString() ?? string.Empty;
            return JsonSerializer.Deserialize<MyOfficeAcpdUpdateResponse>(responseJson);
        }

        public async Task<MyOfficeAcpdDeleteResponse> DeleteAsync(MyOfficeAcpdDeleteRequest request)
        {
            var requestJson = JsonSerializer.Serialize(request);
            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand("dbo.sp_MyOffice_ACPD_Delete_JSON", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@ActionJSON", SqlDbType.NVarChar)
            {
                Value = requestJson
            });
            await connection.OpenAsync();
            var responseJson = (await command.ExecuteScalarAsync())?.ToString() ?? string.Empty;
            return JsonSerializer.Deserialize<MyOfficeAcpdDeleteResponse>(responseJson);
        }
    }
}
