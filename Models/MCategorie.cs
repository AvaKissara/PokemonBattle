using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Models
{
    public class MCategorie
    {
        private int idCategorie;
        public int GetId()
        {
            return idCategorie;
        }
        private string nomCategorie;
        public string NomCategorie
        {
            get { return nomCategorie; }
            set { nomCategorie = value; }
        }
    }
}
