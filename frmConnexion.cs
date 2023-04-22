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
        MUtilisateur lUtilisateur;

        public frmConnexion()
        {
            InitializeComponent();

            dataUtilisateur = new RepoUtilisateur();
            utilisateurs = dataUtilisateur.listerUtilisateurDeJson("dataUtilisateur");
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(utilisateurs.Any(utilisateur => utilisateur.Pseudo == textBoxPseudo.Text) && utilisateurs.Any(utilisateur => utilisateur.MotDePasse == textBoxMdP.Text))
            { 
                this.Close();
            }
            else
            {
                MessageBox.Show("NON");
            }
        }
    }
}
