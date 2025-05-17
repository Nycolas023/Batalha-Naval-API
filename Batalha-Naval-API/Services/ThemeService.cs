using Batalha_Naval_API.DTOs;
using System.Net.Http.Json;

namespace Batalha_Naval_API.Services
{
    public class ThemeService
    {
        private readonly HttpClient _httpClient;

        public ThemeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ThemeResponseDTO>> BuscarTodosAsync()
        {
            var response = await _httpClient.GetAsync("/rest/v1/theme?select=*");
            response.EnsureSuccessStatusCode();
            var temas = await response.Content.ReadFromJsonAsync<List<ThemeResponseDTO>>();
            return temas ?? new List<ThemeResponseDTO>();
        }

        public async Task<bool> CriarAsync(ThemeCreateDTO dto)
        {
            var response = await _httpClient.PostAsJsonAsync("/rest/v1/theme", dto);
            return response.IsSuccessStatusCode;
        }
    }
}
