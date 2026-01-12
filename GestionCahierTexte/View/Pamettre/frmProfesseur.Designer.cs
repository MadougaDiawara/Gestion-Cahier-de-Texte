namespace GestionCahierTexte.View.Pamettre
{
    partial class frmProfesseur
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
            this.txtNomProf = new System.Windows.Forms.TextBox();
            this.txtPrenomProf = new System.Windows.Forms.TextBox();
            this.cbSpecialite = new System.Windows.Forms.ComboBox();
            this.dgvProfesseur = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomProf
            // 
            this.txtNomProf.Location = new System.Drawing.Point(17, 16);
            this.txtNomProf.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomProf.Name = "txtNomProf";
            this.txtNomProf.Size = new System.Drawing.Size(132, 22);
            this.txtNomProf.TabIndex = 0;
            this.txtNomProf.Text = "Nom du Professeur";
            this.txtNomProf.TextChanged += new System.EventHandler(this.txtNomProf_TextChanged);
            // 
            // txtPrenomProf
            // 
            this.txtPrenomProf.Location = new System.Drawing.Point(16, 48);
            this.txtPrenomProf.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenomProf.Name = "txtPrenomProf";
            this.txtPrenomProf.Size = new System.Drawing.Size(147, 22);
            this.txtPrenomProf.TabIndex = 1;
            this.txtPrenomProf.Text = "Prenom du Professeur";
            this.txtPrenomProf.TextChanged += new System.EventHandler(this.txtPrenomProf_TextChanged);
            // 
            // cbSpecialite
            // 
            this.cbSpecialite.FormattingEnabled = true;
            this.cbSpecialite.Location = new System.Drawing.Point(13, 78);
            this.cbSpecialite.Margin = new System.Windows.Forms.Padding(4);
            this.cbSpecialite.Name = "cbSpecialite";
            this.cbSpecialite.Size = new System.Drawing.Size(160, 24);
            this.cbSpecialite.TabIndex = 2;
            this.cbSpecialite.Text = "Specialité";
            this.cbSpecialite.SelectedIndexChanged += new System.EventHandler(this.cbSpecialite_SelectedIndexChanged);
            // 
            // dgvProfesseur
            // 
            this.dgvProfesseur.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesseur.Location = new System.Drawing.Point(51, 203);
            this.dgvProfesseur.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProfesseur.Name = "dgvProfesseur";
            this.dgvProfesseur.RowHeadersWidth = 51;
            this.dgvProfesseur.Size = new System.Drawing.Size(476, 246);
            this.dgvProfesseur.TabIndex = 3;
            this.dgvProfesseur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesseur_CellClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(39, 130);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 44);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(199, 130);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(112, 44);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(371, 130);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(120, 44);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(616, 480);
            this.ControlBox = false;
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvProfesseur);
            this.Controls.Add(this.cbSpecialite);
            this.Controls.Add(this.txtPrenomProf);
            this.Controls.Add(this.txtNomProf);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProfesseur";
            this.Text = "Professeur";
            this.Load += new System.EventHandler(this.frmProfesseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomProf;
        private System.Windows.Forms.TextBox txtPrenomProf;
        private System.Windows.Forms.ComboBox cbSpecialite;
        private System.Windows.Forms.DataGridView dgvProfesseur;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
    }
}