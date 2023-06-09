﻿using PokemonBattle.Models;
using PokemonBattle.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonBattle.Controllers
{
    public class ControlPokemon
    {
       

        public static DataTable formerListePokemon()
        {
            RepoPokemon dataPokemon;
            List<MPokemon> pokemons;
            DataTable dtPokemon;
            dataPokemon = new RepoPokemon();
            pokemons = dataPokemon.listerPokemonDeJson("dataPokemon");
            RepoCapacite dataCap = new RepoCapacite();
          

            DataRow row;

            dtPokemon = new DataTable();
            dtPokemon.Columns.Add("Pokemon", typeof(Image));
            dtPokemon.Columns.Add("Nom", typeof(string));
            dtPokemon.Columns.Add("Num", typeof(string));
            dtPokemon.Columns.Add("Niveau", typeof(int));
            dtPokemon.Columns.Add("PV", typeof(int));
            dtPokemon.Columns.Add("Attaque", typeof(int));
            dtPokemon.Columns.Add("Defense", typeof(int));
            dtPokemon.Columns.Add("AttSpe", typeof(int));
            dtPokemon.Columns.Add("DefSpe", typeof(int));
            dtPokemon.Columns.Add("Vitesse", typeof(int));
            dtPokemon.Columns.Add("IV", typeof(int));
            dtPokemon.Columns.Add("Nature", typeof(string));
            dtPokemon.Columns[0].ColumnName= "Pokemon";
            dtPokemon.Columns[1].ColumnName = "Nom";



            foreach (MPokemon pokemon in pokemons)
            {
                pokemon.calculStat(pokemon);
                Image imgPokemon = Image.FromFile(@pokemon.CheminImgPokemon);
                row = dtPokemon.NewRow();
                row[0] = imgPokemon;
                row[1] = pokemon.NomPokemon;
                row[2] = pokemon.NumPokemon;
                row[3] = pokemon.Niveau;
                row[4] = pokemon.Pv;
                row[5] = pokemon.Attaque;
                row[6] = pokemon.Defense;
                row[7] = pokemon.AttSpe;
                row[8] = pokemon.DefSpe;
                row[9] = pokemon.Vitesse;
                row[10] = pokemon.IV;
                row[11] = pokemon.Nature;

                dtPokemon.Rows.Add(row);
            }

            return dtPokemon;
        }


        public static DataTable formerListePokedex()
        {
            RepoPokemon dataPokemon;
            List<MPokemon> pokemons;
            DataTable dtPokemon;
            dataPokemon = new RepoPokemon();
            pokemons = dataPokemon.listerPokemonDeJson("dataPokemon");

            DataRow row;

            dtPokemon = new DataTable();
            dtPokemon.Columns.Add("Pokemon", typeof(Image));
            dtPokemon.Columns.Add("Nom", typeof(string));
            dtPokemon.Columns.Add("Num", typeof(string));
            dtPokemon.Columns.Add("Niveau", typeof(int));
            dtPokemon.Columns.Add("PV", typeof(int));
            dtPokemon.Columns.Add("Attaque", typeof(int));
            dtPokemon.Columns.Add("Defense", typeof(int));
            dtPokemon.Columns.Add("AttSpe", typeof(int));
            dtPokemon.Columns.Add("DefSpe", typeof(int));
            dtPokemon.Columns.Add("Vitesse", typeof(int));
            dtPokemon.Columns.Add("IV", typeof(int));
            dtPokemon.Columns.Add("Nature", typeof(string));
            dtPokemon.Columns[0].ColumnName = "Pokedex";
            dtPokemon.Columns[1].ColumnName = "NomPokedex";




            foreach (MPokemon pokemon in pokemons)
            {
                Image imgPokemon = Image.FromFile(@pokemon.CheminImgPokemon);
                row = dtPokemon.NewRow();
                row[0] = imgPokemon;
                row[1] = pokemon.NomPokemon;
                row[2] = pokemon.NumPokemon;
                row[3] = pokemon.Niveau;
                row[4] = pokemon.Pv;
                row[5] = pokemon.Attaque;
                row[6] = pokemon.Defense;
                row[7] = pokemon.AttSpe;
                row[8] = pokemon.DefSpe;
                row[9] = pokemon.Vitesse;
                row[10] = pokemon.IV;
                row[11] = pokemon.Nature;
                dtPokemon.Rows.Add(row);
            }

            return dtPokemon;
        }


        public static DataTable formerListeCapacite()
        {
            RepoCapacite dataCapacite;
            List<MCapacite> capacites;
            DataTable dtCapacite;
            dataCapacite = new RepoCapacite();
            capacites = dataCapacite.listerCapaciteDeJson("dataCapacite");

            DataRow row;

            dtCapacite = new DataTable();
            dtCapacite.Columns.Add("NomCapacite", typeof(string));
            dtCapacite.Columns.Add("PP", typeof(int));
            dtCapacite.Columns.Add("Puissance", typeof(int));
            dtCapacite.Columns.Add("Pre", typeof(int));



            foreach (MCapacite cap in capacites)
            {
                row = dtCapacite.NewRow();
                row[0] = cap.NomCapacite;
                row[1] = cap.PP;
                row[2] = cap.Puissance;
                row[3] = cap.Pre;
            
                dtCapacite.Rows.Add(row);
            }

            return dtCapacite;
        }
    }
}
