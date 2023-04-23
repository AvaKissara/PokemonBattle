namespace PokemonBattle
{
    partial class frmConnexion
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
            this.lblConnexion = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblMdP = new System.Windows.Forms.Label();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.textBoxMdP = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Location = new System.Drawing.Point(357, 44);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(93, 15);
            this.lblConnexion.TabIndex = 0;
            this.lblConnexion.Text = "Connectez-vous";
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(283, 167);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(46, 15);
            this.lblPseudo.TabIndex = 1;
            this.lblPseudo.Text = "Pseudo";
            // 
            // lblMdP
            // 
            this.lblMdP.AutoSize = true;
            this.lblMdP.Location = new System.Drawing.Point(283, 259);
            this.lblMdP.Name = "lblMdP";
            this.lblMdP.Size = new System.Drawing.Size(77, 15);
            this.lblMdP.TabIndex = 2;
            this.lblMdP.Text = "Mot de passe";
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(421, 164);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(100, 23);
            this.textBoxPseudo.TabIndex = 3;
            // 
            // textBoxMdP
            // 
            this.textBoxMdP.Location = new System.Drawing.Point(421, 251);
            this.textBoxMdP.Name = "textBoxMdP";
            this.textBoxMdP.Size = new System.Drawing.Size(100, 23);
            this.textBoxMdP.TabIndex = 4;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(553, 372);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(636, 372);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.textBoxMdP);
            this.Controls.Add(this.textBoxPseudo);
            this.Controls.Add(this.lblMdP);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.lblConnexion);
            this.Name = "frmConnexion";
            this.Text = "frmConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblConnexion;
        private Label lblPseudo;
        private Label lblMdP;
        private TextBox textBoxPseudo;
        private TextBox textBoxMdP;
        private Button btnValider;
        private Button btnAnnuler;
    }
}