namespace Batalha_Naval_API.Models
{
    public class ThemeModel
    {
        public int ThemeId { get; set; }
        public string ThemeName { get; set; } = string.Empty;
        public string? ThemeImage { get; set; }  // Campo opcional (nullável)
        public decimal ThemePrice { get; set; }
    }
}
