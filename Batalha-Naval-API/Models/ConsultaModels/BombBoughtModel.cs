using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Models.ConsultaModels
{
    public class BombBoughtModel
    {

        [JsonPropertyName("bomb_id")]
        public int Id { get; set; }

        [JsonPropertyName("bomb_name")]
        public string Nome { get; set; } = string.Empty;

        [JsonPropertyName("bomb_price")]
        public double Price { get; set; }

        [JsonPropertyName("bomb_image")]
        public string ImagePath { get; set; } = string.Empty;

        [JsonPropertyName("bomb_desc")]
        public string Desc { get; set; } = string.Empty;

        [JsonPropertyName("bomb_type")]
        public int Type { get; set; }

        [JsonPropertyName("stored_quantity")]
        public int Quantity { get; set; }
    }
}
