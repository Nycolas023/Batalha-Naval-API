using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Models.SelectModels
{
    public class UserModel
    {
        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        [JsonPropertyName("user_nickname")]
        public string? Nickname { get; set; }

        [JsonPropertyName("user_login")]
        public string? Login { get; set; }

        [JsonPropertyName("user_password")]
        public string? Password { get; set; }

        [JsonPropertyName("user_money_amount")]
        public int MoneyAmount { get; set; }

        [JsonPropertyName("user_present_theme")]
        public string?  PresentTheme { get; set; }

        [JsonPropertyName("user_match_victory")]
        public int MatchVictory { get; set; }

        [JsonPropertyName("user_match_defeat")]
        public int MatchDefeat { get; set; }

        [JsonPropertyName("user_match_boats_sunk")]
        public int MatchBoatsSunk { get; set; }
    }
}
