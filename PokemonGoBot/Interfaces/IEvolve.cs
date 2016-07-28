using PokemonGoBot.API;
using PokemonGoBot.API.GeneratedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoBot.Interfaces
{
    interface IEvolve
    {
        Task EvolveAllGivenPokemons(Client client, IEnumerable<PokemonData> pokemonToEvolve, int id);
    }
}
