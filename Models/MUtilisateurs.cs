using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Models
{
    public class MUtilisateurs : MPersonne
    {
        private string motDePasse;

        // Constructeur par défaut
        public MUtilisateurs() : base()
        {
            motDePasse = "";
        }

        // Propriété publique pour accéder à l'attribut motDePasse en lecture seule
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
