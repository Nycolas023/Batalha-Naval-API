using Batalha_Naval_API.DTOs;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;
using System.Net.Http.Headers;


namespace Batalha_Naval_API.Services
{
    public class UsuarioService
    {
        private readonly HttpClient _httpClient;
        private readonly string _supabaseUrl;
        private readonly string _anonKey;

        public UsuarioService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _supabaseUrl = configuration["Supabase:Url"]!;
            _anonKey = configuration["Supabase:AnonKey"]!;
        }

        public async Task<UsuarioResponseDTO?> CriarUsuarioAsync(UsuarioCreateDTO dto)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "/rest/v1/rpc/cadastrar_usuario");

            request.Content = JsonContent.Create(new
            {
                p_username = dto.Username,
                p_login = dto.Login,
                p_password = dto.Password,
                p_ship_id = (int?)null,
                p_dinheiro = 100.0
            });

            var response = await _httpClient.SendAsync(request);

            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"SUPABASE: {(int)response.StatusCode} - {responseBody}");

            if (!response.IsSuccessStatusCode)
                return null;

            return new UsuarioResponseDTO
            {
                Username = dto.Username,
                Login = dto.Login,
                ShipId = null
            };
        }


        public async Task<UsuarioResponseDTO?> Login(UsuarioLoginDTO dto)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "/rest/v1/rpc/retorna_usuario");

            request.Content = JsonContent.Create(new
            {
                p_login = dto.Login,
                p_password = dto.Password
            });

            var response = await _httpClient.SendAsync(request);

            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"SUPABASE LOGIN: {(int)response.StatusCode} - {responseBody}");

            if (!response.IsSuccessStatusCode)
                return null;

            var lista = await response.Content.ReadFromJsonAsync<List<UsuarioResponseDTO>>();
            var usuario = lista?.FirstOrDefault();
            return usuario;
        }


    }
}
