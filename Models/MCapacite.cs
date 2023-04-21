using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Models
{
    public class MCapacite
    {
        private int idCapacite;
        public int GetId()
        {
            return idCapacite;
        }
        private string nomCapacite;
        public string NomCapacite
        {
            get { return nomCapacite; }
            set { nomCapacite = value; }
        }
    }
}
