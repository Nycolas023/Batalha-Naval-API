using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Models.CreateModels
{
    public class CreateThemeModel
    {
        public string Image { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Preview { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

}
