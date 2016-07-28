using PokemonGoBot.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoBot.Interfaces
{
    interface ILevel
    {
        Task PrintLevel(Client client, int id);
        Task ConsoleLevelTitle(string Username, Client client, int id);
    }
}
