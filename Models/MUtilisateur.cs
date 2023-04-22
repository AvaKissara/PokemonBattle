using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Models
{
    public class MUtilisateur : MPersonne
    {
        private string motDePasse;

        public MUtilisateur(int unIdUtilisateur, string unNomUtilisateur, string unPrenomUtilisateur, string unPseudoUtilisateur, string MotDePasse) : base(unIdUtilisateur, unNomUtilisateur, unPrenomUtilisateur, unPseudoUtilisateur)
        {
            this.motDePasse = MotDePasse;
        }

        public string MotDePasse
        {
            get { return motDePasse; }
            set
            {
                if (value.Length >= 6)
                {
                    motDePasse = value;
                }
                else
                {
                    throw new ArgumentException("Le mot de passe doit contenir au moins 6 caractères.");
                }
            }

        }
    }
}
