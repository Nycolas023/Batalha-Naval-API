namespace Batalha_Naval_API.Models
{
    public class UsuarioModel
    {
        public int UsersId { get; set; }
        public string? UsersNickname { get; set; }
        public string? UsersLogin { get; set; }
        public string? UsersPassword { get; set; }
        public double UsersMoneyAmount { get; set; }
        public int? ShipId { get; set; }  // FK para navio
    }
}
