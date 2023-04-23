using Newtonsoft.Json;
using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories
{
    public class RepoAdmin
    {
        public List<MAdmin> listerAdminDeJson(string chemin)
        {
            string jsonAdmin = File.ReadAllText(@"C:\Users\AvaKissara\source\repos\PokemonBattle\Data\dataAdmin.json");
            List<MAdmin> admins = JsonConvert.DeserializeObject<List<MAdmin>>(jsonAdmin);
            return admins;
        }

        public void ecrireAdminJson<Type>(string chemin, Type data) 
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(@"C:\Users\AvaKissara\source\repos\PokemonBattle\Repositories\RepoAdmin.cs", jsonData);
        }
    }
}
