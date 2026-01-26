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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesseur)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomProf
            // 
            this.txtNomProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNomProf.Location = new System.Drawing.Point(2, 50);
            this.txtNomProf.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomProf.Name = "txtNomProf";
            this.txtNomProf.Size = new System.Drawing.Size(164, 24);
            this.txtNomProf.TabIndex = 0;
            this.txtNomProf.TextChanged += new System.EventHandler(this.txtNomProf_TextChanged);
            // 
            // txtPrenomProf
            // 
            this.txtPrenomProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomProf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPrenomProf.Location = new System.Drawing.Point(2, 100);
            this.txtPrenomProf.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPrenomProf.Name = "txtPrenomProf";
            this.txtPrenomProf.Size = new System.Drawing.Size(182, 24);
            this.txtPrenomProf.TabIndex = 1;
            this.txtPrenomProf.TextChanged += new System.EventHandler(this.txtPrenomProf_TextChanged);
            // 
            // cbSpecialite
            // 
            this.cbSpecialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpecialite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbSpecialite.FormattingEnabled = true;
            this.cbSpecialite.Location = new System.Drawing.Point(4, 150);
            this.cbSpecialite.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbSpecialite.Name = "cbSpecialite";
            this.cbSpecialite.Size = new System.Drawing.Size(199, 26);
            this.cbSpecialite.TabIndex = 2;
            this.cbSpecialite.SelectedIndexChanged += new System.EventHandler(this.cbSpecialite_SelectedIndexChanged);
            // 
            // dgvProfesseur
            // 
            this.dgvProfesseur.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesseur.Location = new System.Drawing.Point(48, 306);
            this.dgvProfesseur.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvProfesseur.Name = "dgvProfesseur";
            this.dgvProfesseur.RowHeadersWidth = 51;
            this.dgvProfesseur.Size = new System.Drawing.Size(610, 220);
            this.dgvProfesseur.TabIndex = 3;
            this.dgvProfesseur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesseur_CellClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAjouter.Location = new System.Drawing.Point(48, 222);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(140, 50);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnModifier.Location = new System.Drawing.Point(234, 222);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(140, 50);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSupprimer.Location = new System.Drawing.Point(440, 222);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(150, 50);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom du Professeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(0, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenom du Professeur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(1, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Specialité";
            // 
            // frmProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(770, 540);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvProfesseur);
            this.Controls.Add(this.cbSpecialite);
            this.Controls.Add(this.txtPrenomProf);
            this.Controls.Add(this.txtNomProf);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}