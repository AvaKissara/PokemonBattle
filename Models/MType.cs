using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Models
{
    public class MType
    {
        private int idType;
        public int IDType 
        {
            get { return idType; }
        }
        public int GetId()
        {
            return idType;
        }
        private string nomType;
        public string NomType
        {
            get { return nomType; }
            set { nomType = value; }
        }
        private List<MType> faiblesses = new List<MType>();

        private List<MType> resistances = new List<MType>();
    }
}
