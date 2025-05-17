using System.Text.Json.Serialization;

namespace Batalha_Naval_API.DTOs
{
    public class MatchResponseDTO
    {
        [JsonPropertyName("match_id")]
        public Guid MatchId { get; set; }

        [JsonPropertyName("match_victory")]
        public int MatchVictory { get; set; }

        [JsonPropertyName("match_defeat")]
        public int MatchDefeat { get; set; }

        [JsonPropertyName("match_draw")]
        public int MatchDraw { get; set; }

        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        [JsonPropertyName("match_boats_sunk")]
        public int MatchBoatsSunk { get; set; }
    }
}
