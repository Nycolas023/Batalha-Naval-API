using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Models.ConsultaModels
{
    public class ThemeBought
    {
        [JsonPropertyName("theme_id")]
        public int Id { get; set; }

        [JsonPropertyName("theme_image")]
        public string? Image { get; set; }

        [JsonPropertyName("theme_name")]
        public string? Name { get; set; }

        [JsonPropertyName("theme_price")]
        public float Price { get; set; }

        [JsonPropertyName("theme_preview")]
        public string Preview { get; set; } = string.Empty;

        [JsonPropertyName("foi_comprado")]
        public bool isBought { get; set; }
    }
}
