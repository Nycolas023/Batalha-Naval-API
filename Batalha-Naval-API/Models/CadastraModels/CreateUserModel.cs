namespace Batalha_Naval_API.Models.CreateModels
{
    public class CreateUserModel
    {
        public string Nickname { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int MoneyAmount { get; set; }
        public int PresentTheme { get; set; }
        public int Victory { get; set; }
        public int Defeat { get; set; }
        public int BoatsSunk { get; set; }
    }

}
