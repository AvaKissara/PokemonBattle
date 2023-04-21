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
        public frmAccueil()
        {
            InitializeComponent();

            RepoUser dataUser = new RepoUser();
            List<Utilisateur> utilisateurs = dataUser.listerUtilisateurDeJson("dataUser");



            // Parcourir la liste des utilisateurnes et les ajouter à la TextBox
            foreach (Utilisateur utilisateur in utilisateurs)
            {
                txtDisplay.AppendText($"Nom: {utilisateur.NomUtilisateur} {Environment.NewLine}");
                txtDisplay.AppendText($"Prénom: {utilisateur.PrenomUtilisateur} {Environment.NewLine}");
                txtDisplay.AppendText($"Pseudo: {utilisateur.Pseudo} {Environment.NewLine}");
            }
        }
    }
}
