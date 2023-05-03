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
            this.btnAjouterP = new System.Windows.Forms.Button();
            this.btnModifierP = new System.Windows.Forms.Button();
            this.btnSupprimerP = new System.Windows.Forms.Button();
            this.btnFermerPokedex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokedex)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPokedex
            // 
            this.dataGridViewPokedex.AllowUserToAddRows = false;
            this.dataGridViewPokedex.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPokedex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPokedex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokedex.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPokedex.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPokedex.Location = new System.Drawing.Point(71, 49);
            this.dataGridViewPokedex.Name = "dataGridViewPokedex";
            this.dataGridViewPokedex.ReadOnly = true;
            this.dataGridViewPokedex.RowTemplate.Height = 25;
            this.dataGridViewPokedex.Size = new System.Drawing.Size(684, 349);
            this.dataGridViewPokedex.TabIndex = 0;
            this.dataGridViewPokedex.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPokedex_CellFormatting);
            // 
            // btnAjouterP
            // 
            this.btnAjouterP.AutoSize = true;
            this.btnAjouterP.Image = global::PokemonBattle.Properties.Resources.add;
            this.btnAjouterP.Location = new System.Drawing.Point(17, 135);
            this.btnAjouterP.Name = "btnAjouterP";
            this.btnAjouterP.Size = new System.Drawing.Size(38, 38);
            this.btnAjouterP.TabIndex = 1;
            this.btnAjouterP.UseVisualStyleBackColor = true;
            this.btnAjouterP.Click += new System.EventHandler(this.btnAjouterPokedex_Click);
            // 
            // btnModifierP
            // 
            this.btnModifierP.AutoSize = true;
            this.btnModifierP.Image = global::PokemonBattle.Properties.Resources.update;
            this.btnModifierP.Location = new System.Drawing.Point(17, 197);
            this.btnModifierP.Name = "btnModifierP";
            this.btnModifierP.Size = new System.Drawing.Size(38, 38);
            this.btnModifierP.TabIndex = 2;
            this.btnModifierP.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerP
            // 
            this.btnSupprimerP.AutoSize = true;
            this.btnSupprimerP.Image = global::PokemonBattle.Properties.Resources.cancel;
            this.btnSupprimerP.Location = new System.Drawing.Point(17, 260);
            this.btnSupprimerP.Name = "btnSupprimerP";
            this.btnSupprimerP.Size = new System.Drawing.Size(38, 38);
            this.btnSupprimerP.TabIndex = 3;
            this.btnSupprimerP.UseVisualStyleBackColor = true;
            // 
            // btnFermerPokedex
            // 
            this.btnFermerPokedex.Location = new System.Drawing.Point(677, 415);
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
            this.Controls.Add(this.btnSupprimerP);
            this.Controls.Add(this.btnModifierP);
            this.Controls.Add(this.btnAjouterP);
            this.Controls.Add(this.dataGridViewPokedex);
            this.Name = "frmPokedex";
            this.Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokedex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewPokedex;
        private Button btnAjouterP;
        private Button btnModifierP;
        private Button btnSupprimerP;
        private Button btnFermerPokedex;
    }
}