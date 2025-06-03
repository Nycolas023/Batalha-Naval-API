using Batalha_Naval_API.DTOs;
using Batalha_Naval_API.Models.SelectModels;
using System.Net.Http.Json;
using System.Text.Json;
namespace Batalha_Naval_API.Services
{
    public class ConsultaService
    {
        private readonly HttpClient _httpClient;

        public ConsultaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ShipModel?> RetornaBarcoAsync(int shipId)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/rest/v1/rpc/retorna_barco", new { p_ship_id = shipId });

                if (!response.IsSuccessStatusCode)
                    return null;

                var resultado = await response.Content.ReadFromJsonAsync<List<ShipModel>>();
                return resultado?.FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public async Task<BombModel?> RetornaBombaAsync(int bombId)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/rest/v1/rpc/retorna_bomba", new { p_bomb_id = bombId });
                if (!response.IsSuccessStatusCode)
                    return null;

                var resultado = await response.Content.ReadFromJsonAsync<List<BombModel>>();
                return resultado?.FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public async Task<ThemeModel?> RetornaTemaAsync(int themeId)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/rest/v1/rpc/retorna_tema", new { p_theme_id = themeId });
                if (!response.IsSuccessStatusCode)
                    return null;

                var resultado = await response.Content.ReadFromJsonAsync<List<ThemeModel>>();
                return resultado?.FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public async Task<UserModel?> RetornaUsuarioAsync(LoginDTO dto)
        {
            try
            {

                var jsonBody = new
                {
                    p_user_login = dto.Login,
                    p_user_password = dto.Password
                };

                var response = await _httpClient.PostAsJsonAsync("/rest/v1/rpc/retorna_usuario", jsonBody);


                Console.WriteLine(JsonSerializer.Serialize(jsonBody));


                Console.WriteLine(response);

                if (!response.IsSuccessStatusCode)
                    return null;

                var resultado = await response.Content.ReadFromJsonAsync<List<UserModel>>();
                return resultado?.FirstOrDefault();
            }
            catch (Exception ex)
            {
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public async Task<List<ThemeModel>?> RetornaTodosTemasAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("/rest/v1/rpc/retorna_todos_temas");
                if (!response.IsSuccessStatusCode)
                    return null;

                var resultado = await response.Content.ReadFromJsonAsync<List<ThemeModel>>();
                return resultado;
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<UserModel>?> RetornaTodosUsuariosAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("/rest/v1/rpc/retorna_todos_usuarios");
                if (!response.IsSuccessStatusCode)
                    return null;

                var resultado = await response.Content.ReadFromJsonAsync<List<UserModel>>();
                return resultado;
            }
            catch
            {
                return null;
            }
        }
        public async Task<List<ShipModel>?> RetornaTodosBarcosAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("/rest/v1/rpc/retorna_todos_barcos");
                if (!response.IsSuccessStatusCode)
                    return null;

                var resultado = await response.Content.ReadFromJsonAsync<List<ShipModel>>();
                return resultado;
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<BombModel>?> RetornaTodasBombasAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("/rest/v1/rpc/retorna_todas_bombas");
                if (!response.IsSuccessStatusCode)
                    return null;

                var resultado = await response.Content.ReadFromJsonAsync<List<BombModel>>();
                return resultado;
            }
            catch
            {
                return null;
            }
        }
    }
}
