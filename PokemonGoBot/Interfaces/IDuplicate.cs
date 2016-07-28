using PokemonGoBot.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoBot.Interfaces
{
    interface IDuplicate
    {
        Task TransferDuplicatePokemon(Client client, int id);
    }
}
