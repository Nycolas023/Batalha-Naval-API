using System.Text.Json.Serialization;

namespace Batalha_Naval_API.Models.SelectModels
{
    public class ThemeQuantityModel
    {
        [JsonPropertyName("user_id")]
        public int UsersId { get; set; }

        [JsonPropertyName("theme_id")]
        public int ThemeId { get; set; }
        //public int StoredQuantity { get; set; }

        [JsonPropertyName("theme_is_bought")]
        public bool ThemeIsBought { get; set; }
    }
}
