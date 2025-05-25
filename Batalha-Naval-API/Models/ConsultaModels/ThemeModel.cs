using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Models.SelectModels
{
    public class ThemeModel
    {
        [JsonPropertyName("theme_id")]
        public int ThemeId { get; set; }

        [JsonPropertyName("theme_image")]
        public string? ThemeImage { get; set; }

        [JsonPropertyName("theme_name")]
        public string? ThemeName { get; set; }

        [JsonPropertyName("theme_price")]
        public double ThemePrice { get; set; }

    }
}
