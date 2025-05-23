using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Models.SelectModels
{
    public class ShipModel
    {
        [JsonPropertyName("ship_id")]
        public int ShipId { get; set; }

        [JsonPropertyName("ship_image")]
        public string ShipImage { get; set; } = string.Empty;

        [JsonPropertyName("ship_name")]
        public string ShipName { get; set; } = string.Empty;

        [JsonPropertyName("ship_desc")]
        public string ShipDesc { get; set; } = string.Empty;
    }

}
