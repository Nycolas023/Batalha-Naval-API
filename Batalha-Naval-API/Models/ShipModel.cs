namespace Batalha_Naval_API.Models
{
    public class ShipModel
    {
        public int ShipId { get; set; }
        public string? ShipImage { get; set; }
        public string? ShipName { get; set; }
        public double ShipPrice { get; set; }
        public int? ThemeId { get; set; }
    }
}
