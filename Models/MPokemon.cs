using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Models
{
    public class MPokemon
    {
        private int idPokemon;
        public int IDPokemon 
        {
            get { return idPokemon; }
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
        private int pv;
        public int PV
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
        private int iv;
        public int IV
        {
            get { return iv; }
            set { iv = value; }
        }
        private string nature;
        public string Nature
        {
            get { return nature; }
            set { nature = value; }
        }

    }
}
