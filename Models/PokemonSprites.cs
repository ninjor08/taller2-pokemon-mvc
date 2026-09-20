using System.Text.Json.Serialization;

namespace PokemonMVC.Models
{
    public class PokemonSprites
    {
        [JsonPropertyName("front_default")]
        public string? FrontDefault { get; set; }

        [JsonPropertyName("back_default")]
        public string? BackDefault { get; set; }

        [JsonPropertyName("front_shiny")]
        public string? FrontShiny { get; set; }

        [JsonPropertyName("back_shiny")]
        public string? BackShiny { get; set; }
    }
}

