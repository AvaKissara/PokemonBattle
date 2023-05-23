using Newtonsoft.Json;
using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories
{
    public class RepoCapacite
    {
        public List<MCapacite> listerCapaciteDeJson(string chemin)
        {
            string jsonCapacite = File.ReadAllText(@"C:\Users\Lila Badi\Documents\GitHub\AvaKissara\PokemonBattle\Data\dataCapacite.json");
            List<MCapacite> capacites = JsonConvert.DeserializeObject<List<MCapacite>>(jsonCapacite);
            return capacites;
        }
    }
}
