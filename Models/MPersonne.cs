using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Models
{
    abstract public class MPersonne
    {
        protected int idPersonne;
        public int IdPersonne
        {
            get { return idPersonne; }
            set { idPersonne = value; }
        }
        protected string nomPersonne;
        public string NomPersonne
        {
            get { return nomPersonne; }
            set { nomPersonne = value.Trim().ToUpper(); }
        }
        protected string prenomPersonne;
        public string PrenomPersonne
        {
            get { return prenomPersonne; }
            set { prenomPersonne = value; }
        }
        protected string pseudo;
        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }

        public MPersonne(int IdPersonne, string NomPersonne, string PrenomPersonne, string Pseudo) 
        {
            this.idPersonne = IdPersonne;
            this.nomPersonne = NomPersonne;
            this.prenomPersonne = PrenomPersonne;
            this.pseudo = Pseudo;
        }
    }
}
