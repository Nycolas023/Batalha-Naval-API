using Batalha_Naval_API.Interfaces;
using Batalha_Naval_API.Model;
using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Services
{
    public class UsuarioService : IUsuario
    {
        public Task AdicionaUsuario(UsuarioModel usuario)
        {


            return Task.FromResult(0);
        }
    }
}
