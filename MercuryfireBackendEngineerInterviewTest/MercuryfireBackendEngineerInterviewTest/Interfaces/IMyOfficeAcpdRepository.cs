namespace MercuryfireBackendEngineerInterviewTest.Interfaces
{
    public interface IMyOfficeAcpdRepository
    {
        Task<string> CreateAsync(string json);

        Task<string> DeleteAsync(char acpdSid);
    }
}
