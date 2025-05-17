using Batalha_Naval_API.Models;

namespace Batalha_Naval_API.Interfaces
{
    public interface IUsuario
    {
        Task AdicionaUsuario(UsuarioModel usuario);

    }
}
