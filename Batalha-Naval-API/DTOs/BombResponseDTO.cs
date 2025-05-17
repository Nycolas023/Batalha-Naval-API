using System.Text.Json.Serialization;

namespace Batalha_Naval_API.DTOs
{
    public class BombResponseDTO
    {
        [JsonPropertyName("bomb_id")]
        public int BombId { get; set; }

        [JsonPropertyName("bomb_name")]
        public string BombName { get; set; }

        [JsonPropertyName("bomb_price")]
        public decimal BombPrice { get; set; }
    }
}
