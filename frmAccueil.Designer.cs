﻿namespace PokemonBattle
{
    partial class frmAccueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnInscription = new System.Windows.Forms.Button();
            this.dataGridViewPokedex = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokedex)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(261, 388);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(119, 33);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(386, 388);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(119, 33);
            this.btnInscription.TabIndex = 1;
            this.btnInscription.Text = "Inscription";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // dataGridViewPokedex
            // 
            this.dataGridViewPokedex.AllowUserToAddRows = false;
            this.dataGridViewPokedex.AllowUserToDeleteRows = false;
            this.dataGridViewPokedex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokedex.Location = new System.Drawing.Point(51, 75);
            this.dataGridViewPokedex.Name = "dataGridViewPokedex";
            this.dataGridViewPokedex.ReadOnly = true;
            this.dataGridViewPokedex.RowTemplate.Height = 25;
            this.dataGridViewPokedex.Size = new System.Drawing.Size(709, 281);
            this.dataGridViewPokedex.TabIndex = 2;
            this.dataGridViewPokedex.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPokedex_CellFormatting);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(305, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(102, 15);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Bonjour Dresseurs";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.dataGridViewPokedex);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.btnConnexion);
            this.Name = "frmAccueil";
            this.Text = "frmAccueil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokedex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConnexion;
        private Button btnInscription;
        private DataGridView dataGridViewPokedex;
        private Label lblWelcome;
    }
}