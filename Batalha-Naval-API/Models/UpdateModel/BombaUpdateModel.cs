using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Models
{
    public class BombaUpdateModel
    {
        public int BombId { get; set; }
        public string? BombName { get; set; }
        public int BombPrice { get; set; }
        public string? BombImage { get; set; }
        public string? BombDesc { get; set; }
        public int BombType { get; set; }
    }
}
