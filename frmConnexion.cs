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
        RepoAdmin dataAdmin;
        List<MAdmin> admins;

        public frmConnexion()
        {
            InitializeComponent();

            dataUtilisateur = new RepoUtilisateur();
            utilisateurs = dataUtilisateur.listerUtilisateurDeJson("dataUtilisateur");
            dataAdmin= new RepoAdmin();
            admins = dataAdmin.listerAdminDeJson("dataAdmin");
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MUtilisateur unUtilisateur;
            MAdmin unAdmin;
            if(utilisateurs.Any(utilisateur => utilisateur.Pseudo == textBoxPseudo.Text) && utilisateurs.Any(utilisateur => utilisateur.MotDePasse == textBoxMdP.Text))
            { 
                unUtilisateur = utilisateurs.Find(utilisateur => utilisateur.Pseudo == textBoxPseudo.Text);

                this.Hide();
                frmPokedexAccueil sessionUtilisateur = new frmPokedexAccueil(unUtilisateur);
                sessionUtilisateur.FormClosed += (s, args) => this.Show();
                sessionUtilisateur.ShowDialog();
            }
            else if(admins.Any(admin => admin.Pseudo == textBoxPseudo.Text) && admins.Any(admin => admin.MotDePasse == textBoxMdP.Text))
            {
                unAdmin = admins.Find(admin => admin.Pseudo == textBoxPseudo.Text);

                this.Hide(); 
                frmPokedexAccueil sessionAdmin = new frmPokedexAccueil(unAdmin);
                sessionAdmin.FormClosed += (s, args) => this.Show();

                sessionAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("NON!");
            }
           
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
