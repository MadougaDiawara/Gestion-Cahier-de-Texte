using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCahierTexte.View.Pamettre
{
    public partial class frmProfesseur : Form
    {
        List<Professeur> professeurs = new List<Professeur>();
        public frmProfesseur()
        {
            InitializeComponent();
        }

        public class Professeur
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Specialite { get; set; }
        }


        private void cbSpecialite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmProfesseur_Load(object sender, EventArgs e)
        {

            cbSpecialite.Items.Clear();
            cbSpecialite.Items.AddRange(new string[] { "DOTNET", "PYTHON", "CRYPTOGRAPHIE", "PHP" });
            cbSpecialite.SelectedIndex = -1;

            dgvProfesseur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProfesseur.MultiSelect = false;

            RafraichirTable();
        }

        private void RafraichirTable()
        {
            dgvProfesseur.DataSource = null;
            dgvProfesseur.DataSource = professeurs;
        }

        private void txtNomProf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenomProf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (txtNomProf.Text.Trim() != "" && txtPrenomProf.Text.Trim() != "" && cbSpecialite.Text.Trim() != "")
            {
                Professeur p = new Professeur
                {
                    Nom = txtNomProf.Text.Trim(),
                    Prenom = txtPrenomProf.Text.Trim(),
                    Specialite = cbSpecialite.Text.Trim()
                };

                professeurs.Add(p);
                RafraichirTable();

                txtNomProf.Clear();
                txtPrenomProf.Clear();
                cbSpecialite.SelectedIndex = -1;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvProfesseur.SelectedRows.Count > 0 && txtNomProf.Text.Trim() != "" && txtPrenomProf.Text.Trim() != "" && cbSpecialite.Text.Trim() != "")
            {
                int index = dgvProfesseur.SelectedRows[0].Index;
                professeurs[index].Nom = txtNomProf.Text.Trim();
                professeurs[index].Prenom = txtPrenomProf.Text.Trim();
                professeurs[index].Specialite = cbSpecialite.Text.Trim();

                RafraichirTable();

                txtNomProf.Clear();
                txtPrenomProf.Clear();
                cbSpecialite.SelectedIndex = -1;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvProfesseur.SelectedRows.Count > 0)
            {
                int index = dgvProfesseur.SelectedRows[0].Index;
                professeurs.RemoveAt(index);
                RafraichirTable();

                txtNomProf.Clear();
                txtPrenomProf.Clear();
                cbSpecialite.SelectedIndex = -1;
            }
        }

        private void dgvProfesseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvProfesseur.Rows[e.RowIndex].Selected = true; // Sélection ligne entière
                txtNomProf.Text = dgvProfesseur.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                txtPrenomProf.Text = dgvProfesseur.Rows[e.RowIndex].Cells["Prenom"].Value.ToString();
                cbSpecialite.Text = dgvProfesseur.Rows[e.RowIndex].Cells["Specialite"].Value.ToString();
            }
        }
    }
}
