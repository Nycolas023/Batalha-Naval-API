using Batalha_Naval_API.DTOs;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;

namespace Batalha_Naval_API.Services
{
    public class BombService
    {
        private readonly HttpClient _httpClient;

        public BombService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<bool> CriarAsync(BombCreateDTO dto)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "/rest/v1/bomb");

            request.Content = JsonContent.Create(new
            {
                bomb_name = dto.BombName,
                bomb_price = dto.BombPrice,
                bomb_image = dto.BombImage // novo campo incluído
            });

            var response = await _httpClient.SendAsync(request);
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"SUPABASE CRIA BOMBA: {(int)response.StatusCode} - {responseBody}");

            return response.IsSuccessStatusCode;
        }



        public async Task<List<BombResponseDTO>> BuscarTodasAsync()
        {
            var response = await _httpClient.GetAsync("/rest/v1/bomb");

            if (!response.IsSuccessStatusCode)
                return new List<BombResponseDTO>();

            var bombas = await response.Content.ReadFromJsonAsync<List<BombResponseDTO>>();
            return bombas ?? new List<BombResponseDTO>();
        }

        public async Task<List<BombInventarioDTO>> ListarInventarioAsync(int userId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/rest/v1/bomb_quantity?user_id=eq.{userId}");

            var response = await _httpClient.SendAsync(request);
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"SUPABASE INVENTARIO: {(int)response.StatusCode} - {responseBody}");

            if (!response.IsSuccessStatusCode)
                return new List<BombInventarioDTO>();

            var lista = await response.Content.ReadFromJsonAsync<List<BombInventarioDTO>>();
            return lista ?? new List<BombInventarioDTO>();
        }

        public async Task<string?> ComprarAsync(BombCompraDTO dto)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "/rest/v1/rpc/comprar_bomba");

            request.Content = JsonContent.Create(new
            {
                p_users_id = dto.UsersId,
                p_bomb_id = dto.BombId
            });

            var response = await _httpClient.SendAsync(request);
            string resposta = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"SUPABASE COMPRA BOMBA: {(int)response.StatusCode} - {resposta}");

            return response.IsSuccessStatusCode ? resposta : null;
        }


    }
}
