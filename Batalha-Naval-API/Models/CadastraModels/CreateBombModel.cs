using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Models.CreateModels
{
    public class CreateBombModel
    {
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Image { get; set; } = null!;
        public string Desc { get; set; } = null!;
        public int Type { get; set; }
    }

}
