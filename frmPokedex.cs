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

            afficherPokemon();

        }

        public void afficherPokemon()
        {
            this.dataGridViewPokedex.DataSource = ControlPokemon.formerListePokemon();
            this.dataGridViewPokedex.Refresh();

        }
        private void dataGridViewPokemon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPokedex.Columns[e.ColumnIndex].Name == "imgPokemon")
            {
                if (e.Value != null)
                {
                    e.FormattingApplied = true;
                    dataGridViewPokedex.Columns[e.ColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }
    }
}
