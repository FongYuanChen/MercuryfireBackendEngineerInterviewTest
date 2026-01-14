using MercuryfireBackendEngineerInterviewTest.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace MercuryfireBackendEngineerInterviewTest.Services
{
    public class UserRepository : IMyOfficeAcpdRepository
    {
        private readonly string _connectionString;

        public UserRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("BackendExamHub");
        }

        public async Task<string> CreateAsync(string json)
        {
            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand("dbo.sp_MyOffice_ACPD_Create_JSON", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@ActionJSON", SqlDbType.NVarChar)
            {
                Value = json
            });

            await connection.OpenAsync();

            return (await command.ExecuteScalarAsync())?.ToString();
        }

        public async Task<string> DeleteAsync(char acpdSid)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand("dbo.sp_MyOffice_ACPD_SoftDelete", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@ACPD_SID", SqlDbType.Char, 20).Value = acpdSid;

            await connection.OpenAsync();

            return (await command.ExecuteScalarAsync())?.ToString();
        }
    }
}
