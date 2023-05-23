namespace PokemonBattle
{
    partial class frmFight
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
            this.dataGridViewPok = new System.Windows.Forms.DataGridView();
            this.dataGridViewCap = new System.Windows.Forms.DataGridView();
            this.textBoxAtt = new System.Windows.Forms.TextBox();
            this.btnAttaquer = new System.Windows.Forms.Button();
            this.btnAtt = new System.Windows.Forms.Button();
            this.textBoxDef = new System.Windows.Forms.TextBox();
            this.btnDef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCap)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPok
            // 
            this.dataGridViewPok.AllowUserToAddRows = false;
            this.dataGridViewPok.AllowUserToDeleteRows = false;
            this.dataGridViewPok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPok.Location = new System.Drawing.Point(106, 57);
            this.dataGridViewPok.Name = "dataGridViewPok";
            this.dataGridViewPok.ReadOnly = true;
            this.dataGridViewPok.RowTemplate.Height = 25;
            this.dataGridViewPok.Size = new System.Drawing.Size(338, 160);
            this.dataGridViewPok.TabIndex = 0;
            this.dataGridViewPok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPok_CellClick);
            // 
            // dataGridViewCap
            // 
            this.dataGridViewCap.AllowUserToAddRows = false;
            this.dataGridViewCap.AllowUserToDeleteRows = false;
            this.dataGridViewCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCap.Location = new System.Drawing.Point(51, 300);
            this.dataGridViewCap.Name = "dataGridViewCap";
            this.dataGridViewCap.ReadOnly = true;
            this.dataGridViewCap.RowTemplate.Height = 25;
            this.dataGridViewCap.Size = new System.Drawing.Size(573, 82);
            this.dataGridViewCap.TabIndex = 1;
            // 
            // textBoxAtt
            // 
            this.textBoxAtt.Location = new System.Drawing.Point(497, 79);
            this.textBoxAtt.Multiline = true;
            this.textBoxAtt.Name = "textBoxAtt";
            this.textBoxAtt.Size = new System.Drawing.Size(211, 23);
            this.textBoxAtt.TabIndex = 2;
            // 
            // btnAttaquer
            // 
            this.btnAttaquer.Location = new System.Drawing.Point(651, 310);
            this.btnAttaquer.Name = "btnAttaquer";
            this.btnAttaquer.Size = new System.Drawing.Size(75, 23);
            this.btnAttaquer.TabIndex = 3;
            this.btnAttaquer.Text = "Attaquer";
            this.btnAttaquer.UseVisualStyleBackColor = true;
            this.btnAttaquer.Click += new System.EventHandler(this.btnAttaquer_Click);
            // 
            // btnAtt
            // 
            this.btnAtt.BackgroundImage = global::PokemonBattle.Properties.Resources.add;
            this.btnAtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtt.Location = new System.Drawing.Point(51, 71);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(42, 37);
            this.btnAtt.TabIndex = 4;
            this.btnAtt.UseVisualStyleBackColor = true;
            this.btnAtt.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // textBoxDef
            // 
            this.textBoxDef.Location = new System.Drawing.Point(497, 162);
            this.textBoxDef.Multiline = true;
            this.textBoxDef.Name = "textBoxDef";
            this.textBoxDef.Size = new System.Drawing.Size(211, 23);
            this.textBoxDef.TabIndex = 5;
            // 
            // btnDef
            // 
            this.btnDef.BackgroundImage = global::PokemonBattle.Properties.Resources.close;
            this.btnDef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDef.Location = new System.Drawing.Point(51, 133);
            this.btnDef.Name = "btnDef";
            this.btnDef.Size = new System.Drawing.Size(41, 42);
            this.btnDef.TabIndex = 6;
            this.btnDef.UseVisualStyleBackColor = true;
            this.btnDef.Click += new System.EventHandler(this.btnDef_Click);
            // 
            // frmFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDef);
            this.Controls.Add(this.textBoxDef);
            this.Controls.Add(this.btnAtt);
            this.Controls.Add(this.btnAttaquer);
            this.Controls.Add(this.textBoxAtt);
            this.Controls.Add(this.dataGridViewCap);
            this.Controls.Add(this.dataGridViewPok);
            this.Name = "frmFight";
            this.Text = "frmFight";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewPok;
        private DataGridView dataGridViewCap;
        private TextBox textBoxAtt;
        private Button btnAttaquer;
        private Button btnAtt;
        private TextBox textBoxDef;
        private Button btnDef;
    }
}