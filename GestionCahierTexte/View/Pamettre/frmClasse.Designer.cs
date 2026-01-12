namespace GestionCahierTexte.View.Pamettre
{
    partial class frmClasse
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
            this.txtNomClasse = new System.Windows.Forms.TextBox();
            this.cbNiveau = new System.Windows.Forms.ComboBox();
            this.dgvClasse = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomClasse
            // 
            this.txtNomClasse.Location = new System.Drawing.Point(16, 32);
            this.txtNomClasse.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomClasse.Name = "txtNomClasse";
            this.txtNomClasse.Size = new System.Drawing.Size(157, 22);
            this.txtNomClasse.TabIndex = 0;
            this.txtNomClasse.Text = "Nom de la Classe";
            this.txtNomClasse.TextChanged += new System.EventHandler(this.txtNomClasse_TextChanged);
            // 
            // cbNiveau
            // 
            this.cbNiveau.FormattingEnabled = true;
            this.cbNiveau.Location = new System.Drawing.Point(16, 64);
            this.cbNiveau.Margin = new System.Windows.Forms.Padding(4);
            this.cbNiveau.Name = "cbNiveau";
            this.cbNiveau.Size = new System.Drawing.Size(160, 24);
            this.cbNiveau.TabIndex = 1;
            this.cbNiveau.Text = "Niveau";
            this.cbNiveau.SelectedIndexChanged += new System.EventHandler(this.cbNiveau_SelectedIndexChanged);
            // 
            // dgvClasse
            // 
            this.dgvClasse.BackgroundColor = System.Drawing.Color.White;
            this.dgvClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasse.Location = new System.Drawing.Point(16, 97);
            this.dgvClasse.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClasse.Name = "dgvClasse";
            this.dgvClasse.RowHeadersWidth = 51;
            this.dgvClasse.Size = new System.Drawing.Size(503, 238);
            this.dgvClasse.TabIndex = 2;
            this.dgvClasse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasse_CellClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(16, 356);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(159, 58);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(183, 356);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(156, 58);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(347, 356);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(160, 58);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(583, 458);
            this.ControlBox = false;
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvClasse);
            this.Controls.Add(this.cbNiveau);
            this.Controls.Add(this.txtNomClasse);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmClasse";
            this.Text = "Classe";
            this.Load += new System.EventHandler(this.frmClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomClasse;
        private System.Windows.Forms.ComboBox cbNiveau;
        private System.Windows.Forms.DataGridView dgvClasse;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
    }
}