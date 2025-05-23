using Batalha_Naval_API.DTOs;
using System.Net.Http.Json;

namespace Batalha_Naval_API.Services
{
    public class MatchService
    {
        private readonly HttpClient _httpClient;

        public MatchService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> CriarPartidaAsync(MatchCreateDTO dto)
        {
            var response = await _httpClient.PostAsJsonAsync("/rest/v1/match", dto);

            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"SUPABASE CREATE MATCH: {(int)response.StatusCode} - {body}");

            return response.IsSuccessStatusCode ? "Partida registrada com sucesso." : "Erro ao registrar partida.";
        }

        public async Task<List<MatchResponseDTO>?> BuscarPartidasPorUsuarioAsync(int userId)
        {
            var response = await _httpClient.GetAsync($"/rest/v1/match?user_id=eq.{userId}");

            string body = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"SUPABASE MATCH USER: {(int)response.StatusCode} - {body}");

            if (!response.IsSuccessStatusCode)
                return null;

            var partidas = await response.Content.ReadFromJsonAsync<List<MatchResponseDTO>>();
            return partidas;
        }
    }
}
