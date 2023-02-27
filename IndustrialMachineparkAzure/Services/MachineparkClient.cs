using IndustrialMachineparkAzure.Shared.Entities;
using System.Net.Http.Json;
using static IndustrialMachineparkAzure.Pages.FetchData;
using static System.Net.WebRequestMethods;

namespace IndustrialMachineparkAzure.Services
{
    public class MachineparkClient : IMachineparkClient
    {
        private const string RequestUri = "sample-data/machines.json";
        private HttpClient httpClient;
        private Machine[]? jsonMachines;


        public MachineparkClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Machine>> GetAsync()
        {
            return SeedMachines();
        }

        public List<Machine> SeedMachines()
        {
            return new List<Machine>()
            {
                new Machine()
                {
                    Type = "Genio 30 Industrial Roaster",
                    Status = false
                },
                new Machine()
                {
                    Type = "Genio 15 Commercial Roaster",
                    Status = true
                },
                new Machine()
                {
                    Type = "Neuhaus Neotec RFB Batch",
                    Status = false
                },
                new Machine()
                {
                    Type = "Machine Castle K-120 Coffee",
                    Status = false
                }
            };
        }

        public async Task<IEnumerable<Machine>> GetJsonAsync<Machine>()
        {
            return await httpClient.GetFromJsonAsync<Machine[]>(RequestUri);

        }

    }
}
