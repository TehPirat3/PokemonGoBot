using PokemonGoBot.API;
using PokemonGoBot.API.GeneratedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoBot.Interfaces
{
    interface ITransfer
    {
        Task TransferAllGivenPokemons(int id, Client client, IEnumerable<PokemonData> unwantedPokemons, float keepPerfectPokemonLimit = 80.0f);
    }
}
