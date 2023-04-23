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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPokedex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPokedex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPokedex.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPokedex.Location = new System.Drawing.Point(80, 64);
            this.dataGridViewPokedex.Name = "dataGridViewPokedex";
            this.dataGridViewPokedex.ReadOnly = true;
            this.dataGridViewPokedex.RowTemplate.Height = 25;
            this.dataGridViewPokedex.Size = new System.Drawing.Size(708, 334);
            this.dataGridViewPokedex.TabIndex = 0;
            this.dataGridViewPokedex.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPokemon_CellFormatting);
            // 
            // btnAjouterPokedex
            // 
            this.btnAjouterPokedex.Location = new System.Drawing.Point(3, 124);
            this.btnAjouterPokedex.Name = "btnAjouterPokedex";
            this.btnAjouterPokedex.Size = new System.Drawing.Size(71, 23);
            this.btnAjouterPokedex.TabIndex = 1;
            this.btnAjouterPokedex.Text = "Ajouter";
            this.btnAjouterPokedex.UseVisualStyleBackColor = true;
            // 
            // btnModifierPokedex
            // 
            this.btnModifierPokedex.Location = new System.Drawing.Point(3, 196);
            this.btnModifierPokedex.Name = "btnModifierPokedex";
            this.btnModifierPokedex.Size = new System.Drawing.Size(71, 23);
            this.btnModifierPokedex.TabIndex = 2;
            this.btnModifierPokedex.Text = "Modifier";
            this.btnModifierPokedex.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPokedex
            // 
            this.btnSupprimerPokedex.Location = new System.Drawing.Point(3, 272);
            this.btnSupprimerPokedex.Name = "btnSupprimerPokedex";
            this.btnSupprimerPokedex.Size = new System.Drawing.Size(71, 23);
            this.btnSupprimerPokedex.TabIndex = 3;
            this.btnSupprimerPokedex.Text = "Supprimer";
            this.btnSupprimerPokedex.UseVisualStyleBackColor = true;
            // 
            // btnFermerPokedex
            // 
            this.btnFermerPokedex.Location = new System.Drawing.Point(693, 414);
            this.btnFermerPokedex.Name = "btnFermerPokedex";
            this.btnFermerPokedex.Size = new System.Drawing.Size(75, 23);
            this.btnFermerPokedex.TabIndex = 4;
            this.btnFermerPokedex.Text = "Fermer";
            this.btnFermerPokedex.UseVisualStyleBackColor = true;
            this.btnFermerPokedex.Click += new System.EventHandler(this.btnFermerPokedex_Click);
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