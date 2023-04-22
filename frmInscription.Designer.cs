namespace PokemonBattle
{
    partial class frmInscription
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
            this.lblInscription = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.textBoxMdP = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInscription
            // 
            this.lblInscription.AutoSize = true;
            this.lblInscription.Location = new System.Drawing.Point(332, 33);
            this.lblInscription.Name = "lblInscription";
            this.lblInscription.Size = new System.Drawing.Size(82, 15);
            this.lblInscription.TabIndex = 0;
            this.lblInscription.Text = "Inscrivez-vous";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(262, 127);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(34, 15);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(262, 189);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 15);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(262, 247);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(46, 15);
            this.lblPseudo.TabIndex = 3;
            this.lblPseudo.Text = "Pseudo";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(262, 311);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(77, 15);
            this.lblMotDePasse.TabIndex = 4;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(428, 119);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 23);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(428, 181);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrenom.TabIndex = 6;
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(428, 247);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(100, 23);
            this.textBoxPseudo.TabIndex = 7;
            // 
            // textBoxMdP
            // 
            this.textBoxMdP.Location = new System.Drawing.Point(428, 308);
            this.textBoxMdP.Name = "textBoxMdP";
            this.textBoxMdP.Size = new System.Drawing.Size(100, 23);
            this.textBoxMdP.TabIndex = 8;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(567, 391);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(92, 30);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(676, 391);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(92, 30);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.textBoxMdP);
            this.Controls.Add(this.textBoxPseudo);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblInscription);
            this.Name = "frmInscription";
            this.Text = "frmInscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInscription;
        private Label lblNom;
        private Label lblPrenom;
        private Label lblPseudo;
        private Label lblMotDePasse;
        private TextBox textBoxNom;
        private TextBox textBoxPrenom;
        private TextBox textBoxPseudo;
        private TextBox textBoxMdP;
        private Button btnValider;
        private Button btnAnnuler;
    }
}