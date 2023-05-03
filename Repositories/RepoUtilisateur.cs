using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories
{
    public class RepoUtilisateur
    {
        public List<MUtilisateur> listerUtilisateurDeJson(string chemin)
        {
            string json = File.ReadAllText(@"C:\Users\Lila Badi\Documents\GitHub\AvaKissara\PokemonBattle\Data\dataUtilisateur.json");
            List<MUtilisateur> utilisateurs = JsonConvert.DeserializeObject<List<MUtilisateur>>(json);
            return utilisateurs;
        }

        public void ecrireUtilisateurJson<Type>(string chemin, Type data)
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(@"C:\Users\Lila Badi\Documents\GitHub\AvaKissara\PokemonBattle\Data\dataUtilisateur.json", jsonData);
        }
    }
}
