using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class MPersonne
    {
        protected int idPersonne;
        public int IdPersonne
        {
            get { return idPersonne; }
        }
        protected string nomPersonne;
        public string NomPersonne
        {
            get { return nomPersonne; }
            set { nomPersonne = value; }
        }

        protected string prenomPersonne;
        public string PrenomPersonne
        {
            get { return prenomPersonne; }
            set { prenomPersonne = value; }
        }

        private string pseudo;
        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }       
    }
}
