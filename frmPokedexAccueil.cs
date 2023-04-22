using PokemonBattle.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonBattle
{
    public partial class frmPokedexAccueil : Form
    {
        public frmPokedexAccueil(MUtilisateur unUtilisateur)
        {
            InitializeComponent();
        
            lblBonjour.Text = "Bienvenue " + unUtilisateur.Pseudo;
        }
    }
}
