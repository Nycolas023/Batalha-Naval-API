using System.Text.Json.Serialization;

namespace Batalha_Naval_API.DTOs
{
    public class BombInventarioDTO
    {
        [JsonPropertyName("users_id")]
        public int UserId { get; set; }

        [JsonPropertyName("bomb_id")]
        public int BombId { get; set; }

        [JsonPropertyName("stored_quantity")]
        public int Quantidade { get; set; }
    }
}
