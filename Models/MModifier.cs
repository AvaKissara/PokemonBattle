using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Models
{
    public class MModifier
    {
        private int idModifier;
        public int GetId()
        {
            return idModifier;
        }
        private string nomModifier;
        public string NomModifier
        {
            get { return nomModifier; }
            set { nomModifier = value; }
        }
        private string abbrModifier;
        public string AbbrModifier
        {
            get { return abbrModifier; }
            set { abbrModifier = value; }
        }
    }
}
