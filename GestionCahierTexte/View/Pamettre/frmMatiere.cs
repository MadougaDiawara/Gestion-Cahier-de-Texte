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
    public partial class frmMatiere : Form
    {
        List<string> matieres = new List<string>();

        public frmMatiere()

        {
            InitializeComponent();
        }

        private void RafraichirTable()
        {
            dgvMatiere.DataSource = null;
            dgvMatiere.DataSource = matieres.Select(m => new { Matiere = m }).ToList();
   
            dgvMatiere.DataSource = matieres.Select(m => new { Nom = m }).ToList();
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

            

        }

        private void frmMatiere_Load(object sender, EventArgs e)
        {
            RafraichirTable();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            matieres.Add(txtNomMatiere.Text);
            RafraichirTable();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nom = dgvMatiere.CurrentRow.Cells["Nom"].Value.ToString();
            matieres.Remove(nom);
            RafraichirTable();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvMatiere.CurrentRow != null && txtNomMatiere.Text.Trim() != "")
            {
               
                string ancienNom = dgvMatiere.CurrentRow.Cells["Nom"].Value.ToString();

                int index = matieres.IndexOf(ancienNom);

                if (index >= 0)
                {
                    matieres[index] = txtNomMatiere.Text.Trim();

                    RafraichirTable();

                    txtNomMatiere.Clear();
                }
           }     
        }

        private void dgvMatiere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        }
    }


