using System.Text.Json.Serialization;

namespace Batalha_Naval_API.DTOs
{
public class ThemeCreateDTO
{
    [JsonPropertyName("theme_name")]
    public string ThemeName { get; set; } = string.Empty;

    [JsonPropertyName("theme_image")]
    public string? ThemeImage { get; set; }

    [JsonPropertyName("theme_price")]
    public decimal ThemePrice { get; set; }
}

}
