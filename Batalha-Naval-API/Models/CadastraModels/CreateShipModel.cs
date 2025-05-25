namespace Batalha_Naval_API.Models.CreateModels
{
    public class CreateShipModel
    {
        public string Image { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Desc { get; set; } = null!;
        public int Theme_id { get; set; } = 0!;
    }

}
