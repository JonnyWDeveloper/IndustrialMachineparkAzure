using IndustrialMachineparkAzure.Shared.Entities;

namespace IndustrialMachineparkAzure.Services
{
    public interface IMachineparkClient
    {
        Task<IEnumerable<Machine>> GetAsync();
        Task<IEnumerable<Machine>> GetJsonAsync<Machine>();
    }
}