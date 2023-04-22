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
            List<MPersonne> personnes = dataUser.listerPersonneDeJson("dataUser");



            // Parcourir la liste des utilisateurnes et les ajouter à la TextBox
            foreach (MPersonne utilisateur in personnes)
            {
                txtDisplay.AppendText($"Nom: {utilisateur.NomPersonne} {Environment.NewLine}");
                txtDisplay.AppendText($"Prénom: {utilisateur.PrenomPersonne} {Environment.NewLine}");
                txtDisplay.AppendText($"Pseudo: {utilisateur.Pseudo} {Environment.NewLine}");
            }
        }
    }
}
