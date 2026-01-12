using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCahierTexte.View.Pamettre;
using Microsoft.VisualBasic.Devices;

namespace GestionCahierTexte
{
    public partial class frmMdi : Form
    {
        public frmMdi()
        {
            InitializeComponent();
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();
        }

        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            //For each child form set the window state to Maximized 
            foreach (Form chform in charr)
            {
                //chform.WindowState = FormWindowState.Maximized;
                chform.Close();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void matiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmMatiere f = new frmMatiere();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmClasse f = new frmClasse();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }
        

        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProfesseur f = new frmProfesseur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }
        

        private void frmMdi_Load(object sender, EventArgs e)
        {
            
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);

        }
    }
}
        
