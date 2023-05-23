using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PokemonBattle.Models
{
    public class MPokemon
    {
        private int idPokemon;
        public int IDPokemon 
        {
            get { return idPokemon; }
        }
        private string cheminImgPokemon;
        public string CheminImgPokemon 
        { 
            get { return cheminImgPokemon; }
            set { cheminImgPokemon = value; }
        }
        private string nomPokemon;
        public string NomPokemon
        {
            get { return nomPokemon; }
            set { nomPokemon = value; }
        }
        private string numPokemon;
        public string NumPokemon
        {
            get { return numPokemon; }
            set { numPokemon = value; }
        }
        private int niveau;
        public int Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }
        private int iv;
        public int IV
        {
            get { return iv; }
            set { iv = value; }
        }
        private int ev;
        public int EV
        {
            get { return ev; }
            set { ev = value; }
        }
        private int pv;
        public int Pv
        {
            get { return pv; }
            set { pv = value; }
        }
        private int attaque;
        public int Attaque
        {
            get { return attaque; }
            set { attaque = value; }
        }
        private int defense;
        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        private int attSpe;
        public int AttSpe
        {
            get { return attSpe; }
            set { attSpe = value; }
        }
        private int defSpe;
        public int DefSpe
        {
            get { return defSpe; }
            set { defSpe = value; }
        }
        private int vitesse;
        public int Vitesse
        {
            get { return vitesse; }
            set { vitesse = value; }
        }
        private string nature;
        public string Nature
        {
            get { return nature; }
            set { nature = value; }
        }

        public MPokemon(int IdPokemon, string CheminImgPokemon, string NomPokemon, string NumPokemon, int Niveau, int IV, int EV, int PV, int Attaque, int Defense, int AttSpe, int DefSpe, int Vitesse, string Nature)
        {
            this.idPokemon = IdPokemon;
            this.cheminImgPokemon = CheminImgPokemon;
            this.nomPokemon = NomPokemon;
            this.NumPokemon = NumPokemon;
            this.niveau = Niveau;
            this.iv = IV;
            this.ev = EV;
            this.pv = PV;
            this.attaque = Attaque;
            this.defense = Defense;
            this.attSpe = AttSpe;
            this.defSpe = DefSpe;
            this.vitesse = Vitesse;
            this.nature = Nature;
        }


        public MPokemon()
        {

        }

        public void calculStat(MPokemon unPokemon)
        {
            unPokemon.Pv = ((IV + (2 * Pv) + (EV / 4)) * Niveau / 100) + Niveau + 10;
            unPokemon.Attaque = ((IV + 2 * Attaque + (EV / 4) * Niveau / 100) + 5);
            unPokemon.Defense = ((IV + 2 * Defense + (EV / 4) * Niveau / 100) + 5);
            unPokemon.AttSpe = ((IV + 2 * AttSpe + (EV / 4) * Niveau / 100) + 5);
            unPokemon.DefSpe = ((IV + 2 * DefSpe + (EV / 4) * Niveau / 100) + 5);
            unPokemon.Vitesse = ((IV + 2 * Vitesse + (EV / 4) * Niveau / 100) + 5);
        }

        public void CalculDegat(int valDegat)
        {
           
        }
    }
}
