using Batalha_Naval_API.Models;

namespace Batalha_Naval_API.Services
{
    public class AlteracaoService
    {
        private readonly Supabase.Client _supabase;

        public AlteracaoService(Supabase.Client supabase)
        {
            _supabase = supabase;
        }

        public async Task AtualizarResultados(PartidasJogadasModel model)
        {
            await _supabase.Rpc("atualizar_resultados", new
            {
                p_user_id = model.P_User_Id,
                p_victories = model.P_Victories,
                p_defeats = model.P_Defeats,
                p_boats_sunk = model.P_Boats_Sunk
            });
        }

        public async Task AtualizarBarcos(BarcoUpdateModel model)
        {
            await _supabase.Rpc("atualizar_barco", new
            {
                p_ship_id = model.ShipId,
                p_image = model.ShipImage,
                p_name = model.ShipName,
                p_ship_size = model.ShipSize,
                p_desc = model.ShipDesc,
                p_theme_id = model.ThemeId
            });
        }

        public async Task AtualizarTemas(TemaUpdateModel model)
        {

            var response = await _supabase.Rpc("atualizar_tema", new
            {
                pid = model.ThemeId,
                pimage = model.ThemeImage,
                pname = model.ThemeName,
                pprice = model.ThemePrice,
                ppreview = model.ThemePreview
            });

        }

        public async Task AtualizarBombas(BombaUpdateModel model)
        {
            await _supabase.Rpc("atualizar_bomba", new
            {
                p_bomb_id = model.BombId,
                p_image = model.BombImage,
                p_name = model.BombName,
                p_desc = model.BombDesc,
                p_price = model.BombPrice
            });
        }


    }
}
