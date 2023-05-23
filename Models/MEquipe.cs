using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Models
{
    public class MEquipe
    {
        private int idEquipe;
        public int IdEquipe
        {
            get { return idEquipe; } 
            set { idEquipe = value; }
        }
        public string nomEquipe
        {
            get { return nomEquipe; }
            set { nomEquipe = value; }
        }
    }
}
