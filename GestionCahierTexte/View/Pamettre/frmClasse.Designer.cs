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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomClasse
            // 
            this.txtNomClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomClasse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNomClasse.Location = new System.Drawing.Point(13, 55);
            this.txtNomClasse.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomClasse.Name = "txtNomClasse";
            this.txtNomClasse.Size = new System.Drawing.Size(157, 24);
            this.txtNomClasse.TabIndex = 0;
            this.txtNomClasse.TextChanged += new System.EventHandler(this.txtNomClasse_TextChanged);
            // 
            // cbNiveau
            // 
            this.cbNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNiveau.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbNiveau.FormattingEnabled = true;
            this.cbNiveau.Location = new System.Drawing.Point(13, 116);
            this.cbNiveau.Margin = new System.Windows.Forms.Padding(4);
            this.cbNiveau.Name = "cbNiveau";
            this.cbNiveau.Size = new System.Drawing.Size(160, 26);
            this.cbNiveau.TabIndex = 1;
            this.cbNiveau.SelectedIndexChanged += new System.EventHandler(this.cbNiveau_SelectedIndexChanged);
            // 
            // dgvClasse
            // 
            this.dgvClasse.BackgroundColor = System.Drawing.Color.White;
            this.dgvClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasse.Location = new System.Drawing.Point(13, 266);
            this.dgvClasse.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClasse.Name = "dgvClasse";
            this.dgvClasse.RowHeadersWidth = 51;
            this.dgvClasse.Size = new System.Drawing.Size(533, 179);
            this.dgvClasse.TabIndex = 2;
            this.dgvClasse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasse_CellClick);
            this.dgvClasse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasse_CellContentClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAjouter.Location = new System.Drawing.Point(136, 182);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(134, 38);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnModifier.Location = new System.Drawing.Point(278, 182);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(135, 38);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSupprimer.Location = new System.Drawing.Point(421, 182);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(125, 38);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom de la Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Niveau";
            // 
            // frmClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(583, 458);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}