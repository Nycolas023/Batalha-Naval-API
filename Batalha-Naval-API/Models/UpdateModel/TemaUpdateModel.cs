using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Models
{
    public class TemaUpdateModel
    {
        public int ThemeId { get; set; }
        public string? ThemeName { get; set; }
        public string? ThemeImage { get; set; }
        public string? ThemePreview { get; set; }
        public int ThemePrice { get; set; }
    }
}