using System.Text.Json.Serialization;

namespace Batalha_Naval_API.DTOs
{
    public class UsuarioResponseDTO
    {
        [JsonPropertyName("user_id")]
        public int UsersId { get; set; }

        [JsonPropertyName("user_nickname")]
        public string? Username { get; set; }

        [JsonPropertyName("user_login")]
        public string? Login { get; set; }

        [JsonPropertyName("ship_id")]
        public int? ShipId { get; set; }
    }
}
