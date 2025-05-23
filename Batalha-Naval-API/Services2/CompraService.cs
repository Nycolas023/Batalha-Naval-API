using Batalha_Naval_API.Models.Compra;

namespace Batalha_Naval_API.Services2
{
    public class CompraService
    {
        private readonly Supabase.Client _supabase;

        public CompraService(Supabase.Client supabase)
        {
            _supabase = supabase;
        }

        public async Task PostCompraTema(CompraTemaModel model)
        {
            await _supabase.Rpc("comprar_tema", new
            {
                p_user_id = model.P_User_Id,
                p_theme_id = model.P_Theme_Id
            });
        }

        public async Task PostCompraMoedas(CompraMoedasModel model)
        {
            await _supabase.Rpc("comprar_moedas", new
            {
                p_user_id = model.P_User_Id,
                p_amount = model.P_Amount
            });
        }

        public async Task PostCompraBomba(CompraBombaModel model)
        {
            await _supabase.Rpc("comprar_bomba", new
            {
                p_user_id = model.P_User_Id,
                p_bomb_id = model.P_Bomb_Id
            });
        }
    }

}
