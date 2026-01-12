using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GestionCahierTexte.View.Pamettre
{

    
    public partial class frmClasse : Form
    {
        List<Classe> classes = new List<Classe>();
        public frmClasse()

        {
            InitializeComponent();
        }

        public class Classe
        {
            public string Nom { get; set; }
            public string Niveau { get; set; }
        }

        private void frmClasse_Load(object sender, EventArgs e)
        {
            cbNiveau.Items.Clear(); 
            cbNiveau.Items.AddRange(new string[] { "Doctorat", "Master", "Licence" , "Licence2" , "Licence1" });

            dgvClasse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasse.MultiSelect = false;
            RafraichirTable();

        }

        private void RafraichirTable()
        {
            dgvClasse.DataSource = null;
            dgvClasse.DataSource = classes;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNomClasse.Text.Trim() != "" && cbNiveau.Text.Trim() != "")
            {
                
            Classe c = new Classe
                {
                    Nom = txtNomClasse.Text.Trim(),
                    Niveau = cbNiveau.Text.Trim()
                };

                classes.Add(c);
                RafraichirTable();

                txtNomClasse.Clear();
                cbNiveau.SelectedIndex = -1;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvClasse.SelectedRows.Count > 0 && txtNomClasse.Text.Trim() != "" && cbNiveau.Text.Trim() != "")
            {
                int index = dgvClasse.SelectedRows[0].Index; // Utilise la ligne sélectionnée
                classes[index].Nom = txtNomClasse.Text.Trim();
                classes[index].Niveau = cbNiveau.Text.Trim();

                RafraichirTable();

                txtNomClasse.Clear();
                cbNiveau.SelectedIndex = -1;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvClasse.SelectedRows.Count > 0)
            {
                int index = dgvClasse.SelectedRows[0].Index;
                classes.RemoveAt(index);
                RafraichirTable();

                txtNomClasse.Clear();
                cbNiveau.SelectedIndex = -1;
            }
        }

        private void dgvClasse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvClasse.Rows[e.RowIndex].Selected = true; // Sélectionne la ligne entière
                txtNomClasse.Text = dgvClasse.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                cbNiveau.Text = dgvClasse.Rows[e.RowIndex].Cells["Niveau"].Value.ToString();
            }
        }

        private void txtNomClasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}