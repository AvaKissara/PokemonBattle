﻿using Newtonsoft.Json;
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
    public partial class frmInscription : Form
    {
        RepoUtilisateur dataUtilisateur;
        List<MUtilisateur> utilisateurs;

        public frmInscription()
        {
            InitializeComponent();

            // Charge les données depuis le fichier JSON
            dataUtilisateur = new RepoUtilisateur();
            utilisateurs = dataUtilisateur.listerUtilisateurDeJson("dataUtilisateur");
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Crée un nouvel objet MUtilisateur à partir des valeurs saisies
            MUtilisateur unUtilisateur = new MUtilisateur(utilisateurs.Count + 1, textBoxNom.Text, textBoxPrenom.Text, textBoxPseudo.Text, textBoxMdP.Text);

            // Ajoute le nouvel objet MUtilisateur à la liste
            utilisateurs.Add(unUtilisateur);

            // Écrit le JSON avec les infos contenues dans utilisateurs
            dataUtilisateur.ecrireUtilisateurJson("dataUtilisateur.json", utilisateurs);

            //Ferme le formulaire la dernière instruction effectué
            DialogResult = DialogResult.OK;

            // Affiche un message pour indiquer que l'ajout a été effectué
            MessageBox.Show("Nouvel utilisateur ajouté avec succès !");

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
