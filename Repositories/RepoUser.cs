using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Repositories
{
    public class RepoUser
    {
        public List<Utilisateur> listerUtilisateurDeJson(string filePath)
        {
            string json = File.ReadAllText(@"C:\Users\AvaKissara\source\repos\PokemonBattle\Data\dataUser.json");
            List<Utilisateur> utilisateurs = JsonConvert.DeserializeObject<List<Utilisateur>>(json);
            return utilisateurs;
        }
    }
}
