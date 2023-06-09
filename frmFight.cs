﻿using PokemonBattle.Controllers;
using PokemonBattle.Models;
using PokemonBattle.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PokemonBattle
{
    public partial class frmFight : Form
    {
        RepoCapacite dataCap = new RepoCapacite();
        RepoPokemon dataPokemon = new RepoPokemon();
        List<MPokemon> pokemons;

        MPokemon attaquant;
        MPokemon defenseur;
        MCapacite CapaciteTrouvee;

        public frmFight(MPersonne unePersonne)
        {
            InitializeComponent();

            afficherPokemon();
            afficherCapacite();
        }

        public void afficherPokemon()
        {
            this.dataGridViewPok.DataSource = ControlPokemon.formerListePokemon();
            this.dataGridViewPok.Refresh();
        }

        public void afficherCapacite()
        {
            this.dataGridViewCap.DataSource = ControlPokemon.formerListeCapacite();
            this.dataGridViewCap.Refresh();
        }

        private void btnAttaquer_Click(object sender, EventArgs e)
        {
            string nom;

            nom = (string)this.dataGridViewCap.CurrentRow.Cells[0].Value;
           
            List<MCapacite> capacites;
            capacites = dataCap.listerCapaciteDeJson("dataCapacite");
            CapaciteTrouvee = capacites.FirstOrDefault(c => c.NomCapacite == nom);
            textBoxAtt.Text += CapaciteTrouvee.NomCapacite + "," + Environment.NewLine;

            defenseur.Pv = defenseur.Pv - CapaciteTrouvee.Puissance;
            textBoxAtt.Text = defenseur.Pv.ToString();



        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {

            string nom;

            nom = (string)this.dataGridViewPok.CurrentRow.Cells[1].Value;

            pokemons = dataPokemon.listerPokemonDeJson("dataPokemon");
            attaquant = pokemons.FirstOrDefault(p => p.NomPokemon == nom);

            textBoxAtt.Text += "Attaquant: " + attaquant.NomPokemon + Environment.NewLine;


        }
        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        private void dataGridViewPok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnDef_Click(object sender, EventArgs e)
        {
            string nom;

            nom = (string)this.dataGridViewPok.CurrentRow.Cells[1].Value;

            pokemons = dataPokemon.listerPokemonDeJson("dataPokemon");
            defenseur = pokemons.FirstOrDefault(p => p.NomPokemon == nom);

            textBoxDef.Text += "Défenseur: " + defenseur.NomPokemon + "," + Environment.NewLine;
        }
    }
}
