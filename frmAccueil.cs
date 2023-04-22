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
    public partial class frmAccueil : Form
    {
        RepoUtilisateur dataUtilisateur;
        List<MUtilisateur> utilisateurs;

        public frmAccueil()
        {
            InitializeComponent();

            dataUtilisateur = new RepoUtilisateur();
            utilisateurs = dataUtilisateur.listerUtilisateurDeJson("dataUtilisateur");
       


       
            //// Parcourir la liste des utilisateurnes et les ajouter à la TextBox
            //foreach (MUtilisateur utilisateur in utilisateurs)
            //{
            //    textBoxTest.AppendText($"Nom: {utilisateur.NomPersonne} {Environment.NewLine}");
            //    textBoxTest.AppendText($"Prénom: {utilisateur.PrenomPersonne} {Environment.NewLine}");
            //    textBoxTest.AppendText($"Pseudo: {utilisateur.Pseudo} {Environment.NewLine}");
            //    textBoxTest.AppendText($"Mot de passe: {utilisateur.MotDePasse} {Environment.NewLine}");
            //}


        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            frmInscription inscription= new frmInscription();
            inscription.ShowDialog();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            frmConnexion connexion= new frmConnexion();
            connexion.ShowDialog();
        }
    }
}
