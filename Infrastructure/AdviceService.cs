using Domain.Entities;
using Domain.Interfaces;
using System.Text.Json;

namespace Infrastructure
{
    public class AdviceService : IAdviceService
    {
        private readonly HttpClient _httpClient;

        public AdviceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Advice> GetRandomAdviceAsync()
        {
            var response = await _httpClient.GetStringAsync("https://api.adviceslip.com/advice");
            var json = JsonDocument.Parse(response);

            var id = json.RootElement.GetProperty("slip").GetProperty("id").GetInt32();
            var text = json.RootElement.GetProperty("slip").GetProperty("advice").GetString();

            return new Advice(id, text);
        }
    }

}
