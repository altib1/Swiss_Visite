using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swiss_Visite
{
    public partial class frmRegion : Form
    {
        public frmRegion()
        {
            InitializeComponent();
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void FrmRegion_Load(object sender, EventArgs e)
        {
            cboRegion.ValueMember = "idRegion";//permet de stocker l'identifiant
            cboRegion.DisplayMember = "libRegion";
            bsRegion.DataSource = Model.listeregion();
            cboRegion.DataSource = bsRegion;

        }

        private void BsRegion_CurrentChanged(object sender, EventArgs e)
        {

            bsVisiteur.DataSource = ((Region)bsRegion.Current).Visiteur1.ToList();
                dgvVisiteur.DataSource = bsVisiteur;




                for (int i = 0; i < dgvVisiteur.ColumnCount; i++)
                {
                    dgvVisiteur.Columns[i].Visible = false;
                }
                dgvVisiteur.Columns["nom"].Visible = true;
                dgvVisiteur.Columns["nom"].HeaderText = "NOM";
                dgvVisiteur.Columns["prenom"].Visible = true;
                dgvVisiteur.Columns["prenom"].HeaderText = "PRENOM";
                dgvVisiteur.ClearSelection();


              




        }
    }
}
