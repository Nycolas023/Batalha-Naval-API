using Batalha_Naval_API.Model;

namespace Batalha_Naval_API.Interfaces
{
    public interface IUsuario
    {
        Task AdicionaUsuario(UsuarioModel usuario);

    }
}
