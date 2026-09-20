namespace PokemonMVC.Models
{
    public class PokemonListResponse
    {
        public int Count { get; set; }

        public List<PokemonListItem> Results { get; set; } = new List<PokemonListItem>();
    }

    public class PokemonListItem
    {
        public string Name { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;
    }
}

