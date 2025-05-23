using Batalha_Naval_API.Models.SelectModels;

namespace Batalha_Naval_API.Interfaces
{
    public interface IUsuario
    {
        Task AdicionaUsuario(UserModel usuario);

    }
}
