using System.Text.Json.Serialization;

public class ThemeResponseDTO
{
    [JsonPropertyName("theme_id")]
    public int ThemeId { get; set; }

    [JsonPropertyName("theme_name")]
    public string ThemeName { get; set; } = string.Empty;

    [JsonPropertyName("theme_image")]
    public string? ThemeImage { get; set; }

    [JsonPropertyName("theme_price")]
    public decimal ThemePrice { get; set; }
}
