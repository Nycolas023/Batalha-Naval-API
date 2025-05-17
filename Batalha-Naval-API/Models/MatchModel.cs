namespace Batalha_Naval_API.Models
{
    public class MatchModel
    {
        public Guid MatchId { get; set; }            // UUID
        public int MatchVictory { get; set; }
        public int MatchDefeat { get; set; }
        public int MatchDraw { get; set; }
        public int UserId { get; set; }
        public int MatchBoatsSunk { get; set; }
    }
}
