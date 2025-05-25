using System.Text.Json.Serialization;

namespace Batalha_Naval_API.DTOs
{
    public class LoginDTO
    {
        //[JsonPropertyName("user_login")]
        public string Login { get; set; } = string.Empty;

        //[JsonPropertyName("user_password")]
        public string Password { get; set; } = string.Empty;
    }
}
