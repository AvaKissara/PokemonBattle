using PokemonBattle.Controllers;
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

            afficherPokedex();
        }
        public void afficherPokedex()
        {
            this.dataGridViewPokedex.DataSource = ControlPokemon.formerListePokedex();
            this.dataGridViewPokedex.Refresh();

        }

        private void dataGridViewPokedex_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPokedex.Columns[e.ColumnIndex].Name == "Pokedex")
            {
                if (e.Value != null)
                {
                    e.FormattingApplied = true;
                    dataGridViewPokedex.Columns[e.ColumnIndex].Width = 100;
                }
            }
            else if (dataGridViewPokedex.Columns[e.ColumnIndex].Name == "NomPokedex")
            {
                if (e.Value != null)
                {
                    e.FormattingApplied = true;
                    dataGridViewPokedex.Columns[e.ColumnIndex].Width = 67;
                }
            }
            else if (dataGridViewPokedex.Columns[e.ColumnIndex].Name != null)
            {
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString();
                    e.FormattingApplied = true;
                    dataGridViewPokedex.Columns[e.ColumnIndex].Width = 48;
                }

            }
            dataGridViewPokedex.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewPokedex.RowTemplate.Height = 100;
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
