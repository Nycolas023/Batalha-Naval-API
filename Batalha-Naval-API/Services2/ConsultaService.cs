using Batalha_Naval_API.DTOs;
using Batalha_Naval_API.Models.SelectModels;
namespace Batalha_Naval_API.Services2
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

        public async Task<UserModel?> RetornaUsuarioAsync(string login, string senha)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/rest/v1/rpc/retorna_usuario", new
                {
                    p_user_login = login,
                    p_user_password = senha
                });

                if (!response.IsSuccessStatusCode)
                    return null;

                var resultado = await response.Content.ReadFromJsonAsync<List<UserModel>>();
                return resultado?.FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }


        //public async Task<UsuarioResponseDTO?> Login(UsuarioLoginDTO dto)
        //{
        //    var request = new HttpRequestMessage(HttpMethod.Post, "/rest/v1/rpc/retorna_usuario");

        //    request.Content = JsonContent.Create(new
        //    {
        //        p_login = dto.Login,
        //        p_password = dto.Password
        //    });

        //    var response = await _httpClient.SendAsync(request);

        //    string responseBody = await response.Content.ReadAsStringAsync();
        //    Console.WriteLine($"SUPABASE LOGIN: {(int)response.StatusCode} - {responseBody}");

        //    if (!response.IsSuccessStatusCode)
        //        return null;

        //    var lista = await response.Content.ReadFromJsonAsync<List<UsuarioResponseDTO>>();
        //    var usuario = lista?.FirstOrDefault();
        //    return usuario;
        //}
    }
}
