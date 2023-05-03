using PokemonBattle.Models;
using PokemonBattle.Repositories;
using PokemonBattle.Controllers;
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
    public partial class frmPokedex : Form
    {
        public frmPokedex(MPersonne unePersonne)
        {
            InitializeComponent();

            //Gestion des boutons pour le CRUD du Pokedex en fonction des droits de la personne connectée
            if (unePersonne is MUtilisateur)
            {
                btnAjouterPokedex.Enabled = false;
                btnAjouterPokedex.Visible = false;
                btnModifierPokedex.Enabled = false;
                btnModifierPokedex.Visible = false;
                btnSupprimerPokedex.Enabled = false;
                btnSupprimerPokedex.Visible = false;
            }
            else
            {
                btnAjouterPokedex.Enabled = true;
                btnAjouterPokedex.Visible = true;
                btnModifierPokedex.Enabled = true;
                btnModifierPokedex.Visible = true;
                btnSupprimerPokedex.Enabled = true;
                btnSupprimerPokedex.Visible = true;
            }

            afficherPokemon();

        }

        public void afficherPokemon()
        {
            this.dataGridViewPokedex.DataSource = ControlPokemon.formerListePokemon();
            this.dataGridViewPokedex.Refresh();

        }
        private void dataGridViewPokedex_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPokedex.Columns[e.ColumnIndex].Name == "Pokemon")
            {
                if (e.Value != null)
                {
                    e.FormattingApplied = true;
                    dataGridViewPokedex.Columns[e.ColumnIndex].Width = 100;                
                }

                
            }
            else if(dataGridViewPokedex.Columns[e.ColumnIndex].Name == "Nom")
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

        private void btnFermerPokedex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouterPokedex_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAjoutPokemon ajoutPokemon= new frmAjoutPokemon();
            ajoutPokemon.Closed += (s, args) => this.Show();
            ajoutPokemon.ShowDialog();  
        }
    }
}
