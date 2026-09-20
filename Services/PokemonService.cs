using PokemonMVC.Models;
using System.Net.Http.Json;

namespace PokemonMVC.Services
{
    public class PokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PokemonListResponse> GetPokemons(int offset, int limit)
        {
            var response = await _httpClient.GetFromJsonAsync<PokemonListResponse>(
                $"pokemon?offset={offset}&limit={limit}");

            return response ?? new PokemonListResponse();
        }

        public async Task<Pokemon> GetPokemon(int id)
        {
            var pokemon = await _httpClient.GetFromJsonAsync<Pokemon>(
                $"pokemon/{id}");

            return pokemon ?? new Pokemon();
        }
    }
}

