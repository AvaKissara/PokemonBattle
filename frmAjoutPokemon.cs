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
    public partial class frmAjoutPokemon : Form
    {
        RepoPokemon dataPokemon;
        List<MPokemon> pokemons;

        public frmAjoutPokemon()
        {
            InitializeComponent();

            dataPokemon = new RepoPokemon();
            pokemons = dataPokemon.listerPokemonDeJson("dataPokemon");
        }
        private void btnValiderAjoutP_Click(object sender, EventArgs e)
        {
            //MPokemon unPokemon = new MPokemon(pokemons.Count +1, textBoxChImg, )
        }
        private void btnAnnulerAjoutP_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
