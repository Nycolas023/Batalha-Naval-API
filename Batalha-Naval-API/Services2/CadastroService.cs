using System.Net.Http.Json;
using Batalha_Naval_API.Models.CreateModels;

namespace Batalha_Naval_API.Services2
{
    public class CadastroService
    {
        private readonly HttpClient _httpClient;

        public CadastroService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CriarUsuarioAsync(CreateUserModel user)
        {
            await _httpClient.PostAsJsonAsync("/rest/v1/rpc/criar_usuario", new
            {
                p_nickname = user.Nickname,
                p_login = user.Login,
                p_password = user.Password,
                p_money_amount = user.MoneyAmount,
                p_present_theme = user.PresentTheme,
                p_victory = user.Victory,
                p_defeat = user.Defeat,
                p_boats_sunk = user.BoatsSunk
            });
        }

        public async Task CriarBarcoAsync(CreateShipModel ship)
        {
            await _httpClient.PostAsJsonAsync("/rest/v1/rpc/criar_barco", new
            {
                p_image = ship.Image,
                p_name = ship.Name,
                p_desc = ship.Desc
            });
        }

        public async Task CriarBombaAsync(CreateBombModel bomb)
        {
            await _httpClient.PostAsJsonAsync("/rest/v1/rpc/criar_bomba", new
            {
                p_name = bomb.Name,
                p_price = bomb.Price,
                p_image = bomb.Image,
                p_desc = bomb.Desc
            });
        }

        public async Task CriarTemaAsync(CreateThemeModel theme)
        {
            await _httpClient.PostAsJsonAsync("/rest/v1/rpc/criar_tema", new
            {
                p_image = theme.Image,
                p_name = theme.Name,
                p_price = theme.Price,
                p_ship_id = theme.ShipId
            });
        }
    }
}
