namespace Batalha_Naval_API.DTOs
{
    public class MatchCreateDTO
    {
        public int UsersId { get; set; }
        public int MatchVictory { get; set; }
        public int MatchDefeat { get; set; }
        public int MatchDraw { get; set; }
        public int BoatsSunk { get; set; }
    }
}
