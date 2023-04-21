using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Models
{
    public class MTalent
    {
        private int idTalent;
        public int GetId()
        {
            return idTalent;
        }
        private string nomTalent;
        public string NomTalent
        {
            get { return nomTalent; }
            set { nomTalent = value; }
        }
    }
}
