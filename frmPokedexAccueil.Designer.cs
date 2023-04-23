namespace PokemonBattle
{
    partial class frmPokedexAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokedexAccueil));
            this.navbar = new System.Windows.Forms.ToolStrip();
            this.menuPokedex = new System.Windows.Forms.ToolStripButton();
            this.menuFight = new System.Windows.Forms.ToolStripButton();
            this.menuProfile = new System.Windows.Forms.ToolStripButton();
            this.menuUtilisateurs = new System.Windows.Forms.ToolStripButton();
            this.lblBonjour = new System.Windows.Forms.Label();
            this.lblPAccueil = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.AutoSize = false;
            this.navbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPokedex,
            this.menuFight,
            this.menuProfile,
            this.menuUtilisateurs});
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(800, 50);
            this.navbar.TabIndex = 0;
            this.navbar.Text = "toolStrip1";
            // 
            // menuPokedex
            // 
            this.menuPokedex.AutoSize = false;
            this.menuPokedex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuPokedex.Image = ((System.Drawing.Image)(resources.GetObject("menuPokedex.Image")));
            this.menuPokedex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPokedex.Margin = new System.Windows.Forms.Padding(0);
            this.menuPokedex.Name = "menuPokedex";
            this.menuPokedex.Size = new System.Drawing.Size(80, 50);
            this.menuPokedex.Text = "Le Pokedex";
            this.menuPokedex.Click += new System.EventHandler(this.menuPokedex_Click);
            // 
            // menuFight
            // 
            this.menuFight.AutoSize = false;
            this.menuFight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFight.Image = ((System.Drawing.Image)(resources.GetObject("menuFight.Image")));
            this.menuFight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFight.Name = "menuFight";
            this.menuFight.Size = new System.Drawing.Size(80, 50);
            this.menuFight.Text = "New fight";
            // 
            // menuProfile
            // 
            this.menuProfile.AutoSize = false;
            this.menuProfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuProfile.Image = ((System.Drawing.Image)(resources.GetObject("menuProfile.Image")));
            this.menuProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuProfile.Name = "menuProfile";
            this.menuProfile.Size = new System.Drawing.Size(80, 50);
            this.menuProfile.Text = "Mon profile";
            // 
            // menuUtilisateurs
            // 
            this.menuUtilisateurs.AutoSize = false;
            this.menuUtilisateurs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuUtilisateurs.Image = ((System.Drawing.Image)(resources.GetObject("menuUtilisateurs.Image")));
            this.menuUtilisateurs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuUtilisateurs.Name = "menuUtilisateurs";
            this.menuUtilisateurs.Size = new System.Drawing.Size(80, 50);
            this.menuUtilisateurs.Text = "Utilisateurs";
            // 
            // lblBonjour
            // 
            this.lblBonjour.AutoSize = true;
            this.lblBonjour.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBonjour.Location = new System.Drawing.Point(316, 159);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(56, 30);
            this.lblBonjour.TabIndex = 1;
            this.lblBonjour.Text = "Zzzz";
            // 
            // lblPAccueil
            // 
            this.lblPAccueil.AutoSize = true;
            this.lblPAccueil.Location = new System.Drawing.Point(297, 259);
            this.lblPAccueil.Name = "lblPAccueil";
            this.lblPAccueil.Size = new System.Drawing.Size(88, 15);
            this.lblPAccueil.TabIndex = 3;
            this.lblPAccueil.Text = "Gnagnagnagna";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(669, 391);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmPokedexAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblPAccueil);
            this.Controls.Add(this.lblBonjour);
            this.Controls.Add(this.navbar);
            this.Name = "frmPokedexAccueil";
            this.Text = "frmPokedexAccueil";
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip navbar;
        private ToolStripButton menuPokedex;
        private Label lblBonjour;
        private ToolStripButton menuFight;
        private ToolStripButton menuProfile;
        private ToolStripButton menuUtilisateurs;
        private Label lblPAccueil;
        private Button btnFermer;
    }
}