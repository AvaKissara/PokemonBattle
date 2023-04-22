﻿using Microsoft.VisualBasic.ApplicationServices;
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
        public List<MUtilisateur> listerUtilisateurDeJson(string filePath)
        {
            string json = File.ReadAllText(@"C:\Users\AvaKissara\source\repos\PokemonBattle\Data\dataUtilisateur.json");
            List<MUtilisateur> utilisateurs = JsonConvert.DeserializeObject<List<MUtilisateur>>(json);
            return utilisateurs;
        }

        public void ecrireJson<Type>(string filePath, Type data)
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(@"C:\Users\AvaKissara\source\repos\PokemonBattle\Data\dataUtilisateur.json", jsonData);
        }
    }
}