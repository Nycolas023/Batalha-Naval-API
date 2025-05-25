using Batalha_Naval_API.Models.DeletesModel;

namespace Batalha_Naval_API.Services
{
    public class DeletesService
    {
        private readonly Supabase.Client _supabase;

        public DeletesService(Supabase.Client supabase)
        {
            _supabase = supabase;
        }

        public async Task DeletarBarcoAsync(DeleteBarcoModel model)
        {
            await _supabase.Rpc("deletar_barco", new { p_ship_id = model.P_Ship_Id });
        }

        public async Task DeletarBombaAsync(DeleteBombaModel model)
        {
            await _supabase.Rpc("deletar_bomba", new { p_bomb_id = model.P_Bomb_Id });
        }

        public async Task DeletarTemaAsync(DeleteTemaModel model)
        {
            await _supabase.Rpc("deletar_tema", new { p_theme_id = model.P_Theme_Id });
        }

        public async Task DeletarUsuarioAsync(DeleteUsuarioModel model)
        {
            await _supabase.Rpc("deletar_usuario", new { p_user_id = model.P_User_Id });
        }

        public async Task UsarBombaAsync(UsarBombaModel model)
        {
            await _supabase.Rpc("usar_bomba", new
            {
                p_user_id = model.P_User_Id,
                p_bomb_id = model.P_Bomb_Id
            });
        }
    }
}
