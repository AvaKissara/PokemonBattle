using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class Utilisateur
    {
        private int idUtilisateur;
        public int IdUtilisateur
        {
            get { return idUtilisateur; }
        }
        private string nomUtilisateur;
        public string NomUtilisateur
        {
            get { return nomUtilisateur; }
            set { nomUtilisateur = value; }
        }

        private string prenomUtilisateur;
        public string PrenomUtilisateur
        {
            get { return prenomUtilisateur; }
            set { prenomUtilisateur = value; }
        }

        private string pseudo;
        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }       
    }
}
