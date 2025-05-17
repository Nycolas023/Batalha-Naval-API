using System.Text.Json.Serialization;

public class MatchCreateDTO
{
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
