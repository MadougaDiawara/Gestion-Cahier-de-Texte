namespace GestionCahierTexte.View.Pamettre
{
    partial class frmMatiere
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatiere = new System.Windows.Forms.DataGridView();
            this.txtNomMatiere = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatiere)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(205, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des Matieres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvMatiere
            // 
            this.dgvMatiere.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvMatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatiere.Location = new System.Drawing.Point(36, 213);
            this.dgvMatiere.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMatiere.Name = "dgvMatiere";
            this.dgvMatiere.RowHeadersWidth = 51;
            this.dgvMatiere.Size = new System.Drawing.Size(520, 183);
            this.dgvMatiere.TabIndex = 1;
            this.dgvMatiere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatiere_CellContentClick);
            // 
            // txtNomMatiere
            // 
            this.txtNomMatiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomMatiere.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNomMatiere.Location = new System.Drawing.Point(36, 56);
            this.txtNomMatiere.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomMatiere.Name = "txtNomMatiere";
            this.txtNomMatiere.Size = new System.Drawing.Size(188, 24);
            this.txtNomMatiere.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAjouter.Location = new System.Drawing.Point(208, 119);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 28);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnModifier.Location = new System.Drawing.Point(326, 119);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 28);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSupprimer.Location = new System.Drawing.Point(434, 119);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(33, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Veuillez Saisir le Nom de la Matiere";
            // 
            // frmMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 409);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNomMatiere);
            this.Controls.Add(this.dgvMatiere);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMatiere";
            this.Text = "Matiere";
            this.Load += new System.EventHandler(this.frmMatiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatiere;
        private System.Windows.Forms.TextBox txtNomMatiere;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label2;
    }
}