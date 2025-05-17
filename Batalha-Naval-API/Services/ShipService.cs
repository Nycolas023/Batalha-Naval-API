using Batalha_Naval_API.DTOs;
using System.Net.Http.Json;

namespace Batalha_Naval_API.Services
{
    public class ShipService
    {
        private readonly HttpClient _httpClient;

        public ShipService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CriarNavioAsync(ShipCreateDTO dto)
        {
            var response = await _httpClient.PostAsJsonAsync("/rest/v1/ship", dto);

            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"SUPABASE SHIP CREATE: {(int)response.StatusCode} - {body}");

            return response.IsSuccessStatusCode;
        }


        public async Task<List<ShipResponseDTO>?> BuscarTodosAsync()
        {
            var response = await _httpClient.GetAsync("/rest/v1/ship?select=ship_image,ship_name,ship_price");

            string body = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"SUPABASE SHIP: {(int)response.StatusCode} - {body}");

            if (!response.IsSuccessStatusCode)
                return null;

            var navios = await response.Content.ReadFromJsonAsync<List<ShipResponseDTO>>();
            return navios;
        }
    }
}
