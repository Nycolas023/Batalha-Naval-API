namespace Batalha_Naval_API.Models.CreateModels
{
    public class CreateThemeModel
    {
        public string Image { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int ShipId { get; set; }
    }

}
