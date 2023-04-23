namespace PokemonBattle
{
    partial class frmPokedex
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
            this.dataGridViewPokedex = new System.Windows.Forms.DataGridView();
            this.btnAjouterPokedex = new System.Windows.Forms.Button();
            this.btnModifierPokedex = new System.Windows.Forms.Button();
            this.btnSupprimerPokedex = new System.Windows.Forms.Button();
            this.btnFermerPokedex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokedex)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPokedex
            // 
            this.dataGridViewPokedex.AllowUserToAddRows = false;
            this.dataGridViewPokedex.AllowUserToDeleteRows = false;
            this.dataGridViewPokedex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokedex.Location = new System.Drawing.Point(177, 121);
            this.dataGridViewPokedex.Name = "dataGridViewPokedex";
            this.dataGridViewPokedex.ReadOnly = true;
            this.dataGridViewPokedex.RowTemplate.Height = 25;
            this.dataGridViewPokedex.Size = new System.Drawing.Size(484, 206);
            this.dataGridViewPokedex.TabIndex = 0;
            this.dataGridViewPokedex.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPokemon_CellFormatting);

            // 
            // btnAjouterPokedex
            // 
            this.btnAjouterPokedex.Location = new System.Drawing.Point(65, 141);
            this.btnAjouterPokedex.Name = "btnAjouterPokedex";
            this.btnAjouterPokedex.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterPokedex.TabIndex = 1;
            this.btnAjouterPokedex.Text = "Ajouter";
            this.btnAjouterPokedex.UseVisualStyleBackColor = true;
            // 
            // btnModifierPokedex
            // 
            this.btnModifierPokedex.Location = new System.Drawing.Point(65, 211);
            this.btnModifierPokedex.Name = "btnModifierPokedex";
            this.btnModifierPokedex.Size = new System.Drawing.Size(75, 23);
            this.btnModifierPokedex.TabIndex = 2;
            this.btnModifierPokedex.Text = "Modifier";
            this.btnModifierPokedex.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPokedex
            // 
            this.btnSupprimerPokedex.Location = new System.Drawing.Point(65, 287);
            this.btnSupprimerPokedex.Name = "btnSupprimerPokedex";
            this.btnSupprimerPokedex.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerPokedex.TabIndex = 3;
            this.btnSupprimerPokedex.Text = "Supprimer";
            this.btnSupprimerPokedex.UseVisualStyleBackColor = true;
            // 
            // btnFermerPokedex
            // 
            this.btnFermerPokedex.Location = new System.Drawing.Point(657, 390);
            this.btnFermerPokedex.Name = "btnFermerPokedex";
            this.btnFermerPokedex.Size = new System.Drawing.Size(75, 23);
            this.btnFermerPokedex.TabIndex = 4;
            this.btnFermerPokedex.Text = "Fermer";
            this.btnFermerPokedex.UseVisualStyleBackColor = true;
            // 
            // frmPokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFermerPokedex);
            this.Controls.Add(this.btnSupprimerPokedex);
            this.Controls.Add(this.btnModifierPokedex);
            this.Controls.Add(this.btnAjouterPokedex);
            this.Controls.Add(this.dataGridViewPokedex);
            this.Name = "frmPokedex";
            this.Text = "frmPokedex";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokedex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewPokedex;
        private Button btnAjouterPokedex;
        private Button btnModifierPokedex;
        private Button btnSupprimerPokedex;
        private Button btnFermerPokedex;
    }
}