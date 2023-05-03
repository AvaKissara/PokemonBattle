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
        private int pvBase;
        public int PvBase
        {
            get { return pvBase; }
            set { pvBase = value; }
        }
        private int pv;
        public int PV
        {
            get { return pv; }
            set 
            { pv = value; }
        }
        private int attaqueBase;
        public int AttaqueBase
        {
            get { return attaqueBase; }
            set { attaqueBase = value; }
        }
        private int attaque;
        public int Attaque
        {
            get { return attaque; }
            set { attaque = value; }
        }
        private int defenseBase;
        public int DefenseBase
        {
            get { return defenseBase; }
            set { defenseBase = value; }
        }
        private int defense;
        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        private int attSpeBase;
        public int AttSpeBase
        {
            get { return attSpeBase; }
            set { attSpeBase = value; }
        }
        private int attSpe;
        public int AttSpe
        {
            get { return attSpe; }
            set { attSpe = value; }
        }
        private int defSpeBase;
        public int DefSpeBase
        {
            get { return defSpeBase; }
            set { defSpeBase = value; }
        }
        private int defSpe;
        public int DefSpe
        {
            get { return defSpe; }
            set { defSpe = value; }
        }
        private int vitesseBase;
        public int VitesseBase
        {
            get { return vitesseBase; }
            set { vitesseBase = value; }
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

        public MPokemon(int IdPokemon, string CheminImgPokemon, string NomPokemon, string NumPokemon, int Niveau, int IV, int EV, int PVBase, int AttaqueBase, int DefenseBase, int AttSpeBase, int DefSpeBase, int VitesseBase, string Nature)
        {
            this.idPokemon = IdPokemon;
            this.cheminImgPokemon = CheminImgPokemon;
            this.nomPokemon = NomPokemon;
            this.NumPokemon = NumPokemon;
            this.niveau = Niveau;
            this.iv = IV;
            this.ev = EV;
            this.pvBase = PVBase;
            this.attaqueBase = AttaqueBase;
            this.defenseBase = DefenseBase;
            this.attSpeBase = AttSpeBase;
            this.defSpeBase = DefSpeBase;
            this.vitesseBase = VitesseBase;
            this.nature = Nature;
        }

        //public MPokemon(int IdPokemon, string CheminImgPokemon, string NomPokemon, string NumPokemon, int Niveau, int IV, int EV, int PVBase, int PV, int AttaqueBase, int Attaque, int DefenseBase, int Defense, int AttSpeBase, int AttSpe, int DefSpeBase, int DefSpe, int VitesseBase, int Vitesse, string Nature)
        //{
        //    this.idPokemon = IdPokemon;
        //    this.cheminImgPokemon = CheminImgPokemon;
        //    this.nomPokemon= NomPokemon;
        //    this.NumPokemon= NumPokemon;
        //    this.niveau= Niveau;
        //    this.iv = IV;
        //    this.ev = EV;
        //    this.pvBase = PVBase;
        //    this.pv= PV;
        //    this.attaqueBase= AttaqueBase;
        //    this.attaque = Attaque;
        //    this.defenseBase= DefenseBase;
        //    this.defense = Defense;
        //    this.attSpeBase= AttSpeBase;
        //    this.attSpe = AttSpe;
        //    this.defSpeBase= DefSpeBase;
        //    this.defSpe = DefSpe;
        //    this.vitesseBase= VitesseBase;
        //    this.vitesse = Vitesse;
        //    this.nature = Nature;
        //}

        public void calculStat(MPokemon unPokemon)
        {
            unPokemon.PvBase = ((IV + (2 * PvBase) + (EV / 4)) * Niveau / 100) + Niveau + 10;
            unPokemon.AttaqueBase = ((IV + 2 * AttaqueBase + (EV / 4) * Niveau / 100) + 5);
            unPokemon.DefenseBase = ((IV + 2 * DefenseBase + (EV / 4) * Niveau / 100) + 5);
            unPokemon.AttSpeBase = ((IV + 2 * AttSpeBase + (EV / 4) * Niveau / 100) + 5);
            unPokemon.DefSpeBase = ((IV + 2 * DefSpeBase + (EV / 4) * Niveau / 100) + 5);
            unPokemon.VitesseBase = ((IV + 2 * VitesseBase + (EV / 4) * Niveau / 100) + 5);
        }
    }
}
