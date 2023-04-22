using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.Models
{
    public class MAdmin : MPersonne
    {
        private string motDePasse;

        // Constructeur par défaut
        public MAdmin() : base()
        {
            motDePasse = "";
        }
        // Propriété publique pour accéder à l'attribut motDePasse en lecture seule
        public string MotDePasse
        {
            get { return motDePasse; }
            set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentException("Le mot de passe doit contenir au moins 10 caractères.");
                }
                if (!value.Any(c => char.IsUpper(c)))
                {
                    throw new ArgumentException("Le mot de passe doit contenir au moins une majuscule.");
                }
                if (!value.Any(c => char.IsLower(c)))
                {
                    throw new ArgumentException("Le mot de passe doit contenir au moins une minuscule.");
                }
                if (!value.Any(c => char.IsDigit(c)))
                {
                    throw new ArgumentException("Le mot de passe doit contenir au moins un chiffre.");
                }
                if (!value.Any(c => !char.IsLetterOrDigit(c)))
                {
                    throw new ArgumentException("Le mot de passe doit contenir au moins un caractère spécial.");
                }

                motDePasse = value;
            }
        }
    }
}
