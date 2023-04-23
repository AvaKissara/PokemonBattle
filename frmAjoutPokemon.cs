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
        public frmAjoutPokemon()
        {
            InitializeComponent();
        }

        private void btnAnnulerAjoutP_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
