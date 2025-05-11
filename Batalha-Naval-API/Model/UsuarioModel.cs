using Batalha_Naval_API.Interfaces;

namespace Batalha_Naval_API.Model
{
    public class UsuarioModel
    {
        public UsuarioModel(int idUsuario, string username, string email, string senha, double dinheiro)
        {
            IdUsuario = idUsuario;
            Username = username;
            Email = email;
            Senha = senha;
            Dinheiro = dinheiro;
        }

        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public double Dinheiro { get; set; }
    }
}
