using Newtonsoft.Json;
using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories
{
    public class RepoPokemon
    {
        public List<MPokemon> listerPokemonDeJson(string chemin)
        {
            string jsonPokemon = File.ReadAllText(@"C:\Users\Lila Badi\Documents\GitHub\AvaKissara\PokemonBattle\Data\dataPokemon.json");
            List<MPokemon> pokemons = JsonConvert.DeserializeObject<List<MPokemon>>(jsonPokemon);
            return pokemons;
        }
    }
}
