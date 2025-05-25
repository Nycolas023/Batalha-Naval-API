using Batalha_Naval_API.Models.PartidaJogadasModel;

namespace Batalha_Naval_API.Services
{
    public class PartidasJogadasService
    {
        private readonly Supabase.Client _supabase;

        public PartidasJogadasService(Supabase.Client supabase)
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
    }
}
