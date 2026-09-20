using Microsoft.AspNetCore.Mvc;
using PokemonMVC.Services;

namespace PokemonMVC.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokemonService _pokemonService;

        public PokemonController(PokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        public async Task<IActionResult> Index(int page = 1, int pageSize = 10)
        {
            if (page < 1)
            {
                page = 1;
            }

            if (pageSize < 1)
            {
                pageSize = 10;
            }

            if (pageSize > 50)
            {
                pageSize = 50;
            }

            int offset = (page - 1) * pageSize;

            var response = await _pokemonService.GetPokemons(offset, pageSize);

            ViewBag.CurrentPage = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalItems = response.Count;
            ViewBag.TotalPages = (int)Math.Ceiling((double)response.Count / pageSize);

            return View(response.Results);
        }

        public async Task<IActionResult> Details(int id)
        {
            var pokemon = await _pokemonService.GetPokemon(id);

            return View(pokemon);
        }
    }
}

