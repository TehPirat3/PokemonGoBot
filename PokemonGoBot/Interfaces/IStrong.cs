using PokemonGoBot.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoBot.Interfaces
{
    interface IStrong
    {
        Task TransferAllButStrongestUnwantedPokemon(Client client, int id);
    }
}
