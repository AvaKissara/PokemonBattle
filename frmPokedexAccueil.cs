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
        MPersonne laPersonne;
        public frmPokedexAccueil(MPersonne unePersonne)
        {
            InitializeComponent();

            laPersonne = unePersonne;
            lblBonjour.Text = "Bienvenue " + unePersonne.Pseudo;
            lblPAccueil.Text = $"Cette application permet de consulter le Pokédex {Environment.NewLine} et de simuler des match pokémon, enjoy !";
            
            //Gestion du bouton 'Utilisateurs' en fonction des droits de la personne connectée
            if (unePersonne is MUtilisateur)
            {
                menuUtilisateurs.Enabled = false;
                menuUtilisateurs.Visible= false;
                menuPokedex.Text = "Mes Equipes";
            }
            else
            {
                menuUtilisateurs.Enabled = true;
                menuUtilisateurs.Visible = true;
                menuPokedex.Text = "Pokedex";
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuPokedex_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPokedex pokedex = new frmPokedex(this.laPersonne);
            pokedex.FormClosed += (s, args) => this.Show();
            pokedex.ShowDialog();
        }
    }
}
