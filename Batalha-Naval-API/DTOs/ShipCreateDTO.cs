using System.Text.Json.Serialization;

namespace Batalha_Naval_API.DTOs
{
    public class ShipCreateDTO
    {
        [JsonPropertyName("ship_name")]
        public string ShipName { get; set; } = string.Empty;

        [JsonPropertyName("ship_image")]
        public string ShipImage { get; set; } = string.Empty;

        [JsonPropertyName("ship_price")]
        public decimal ShipPrice { get; set; }

        [JsonPropertyName("theme_id")]
        public int ThemeId { get; set; }
    }
}
