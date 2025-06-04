using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Models.ConsultaModels
{
    public class ShipImageModel
    {
        [JsonPropertyName("ship_image")]
        public string Image { get; set; } = string.Empty;
    }
}
