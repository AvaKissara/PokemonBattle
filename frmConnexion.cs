using PokemonBattle.Models;
using PokemonBattle.Repositories;
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
    public partial class frmConnexion : Form
    {
        RepoUtilisateur dataUtilisateur;
        List<MUtilisateur> utilisateurs;

        public frmConnexion()
        {
            InitializeComponent();

            dataUtilisateur = new RepoUtilisateur();
            utilisateurs = dataUtilisateur.listerUtilisateurDeJson("dataUtilisateur");
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MUtilisateur unUtilisateur;
            if(utilisateurs.Any(utilisateur => utilisateur.Pseudo == textBoxPseudo.Text) && utilisateurs.Any(utilisateur => utilisateur.MotDePasse == textBoxMdP.Text))
            { 
                unUtilisateur = utilisateurs.Find(utilisateur => utilisateur.Pseudo == textBoxPseudo.Text);
                frmPokedexAccueil session = new frmPokedexAccueil(unUtilisateur);
                session.ShowDialog();
            }
            else
            {
                MessageBox.Show("NON");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
