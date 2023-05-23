using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PokemonBattle.Models
{
    public class MCapacite
    {
        private int idCapacite;
        public int IdCapacite
        {
            get { return idCapacite; } 

        }
        private string nomCapacite;
        public string NomCapacite
        {
            get { return nomCapacite; }
            set { nomCapacite = value; }
        }

        private int pp;
        public int PP 
        {
            get { return pp; }
            set { pp = value; }
        }

        private int puissance;
        public int Puissance
        {
            get { return puissance; }
            set { puissance = value; }  
        }

        private int pre;
        public int Pre
        {
            get { return pre; }
            set { pre = value; }    
        }

        public MCapacite(int IdCapacite, string NomCapacite, int PP, int Puissance, int Pre) 
        {
            this.idCapacite = IdCapacite;
            this.NomCapacite = NomCapacite;
            this.PP= PP;
            this.Puissance= Puissance;
            this.Pre= Pre;
        }

     
    }
}
