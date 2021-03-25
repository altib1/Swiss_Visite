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
    public partial class FraisHorsForfait : Form
    {
        public FraisHorsForfait()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (dgvfraisHorsForfait.RowCount > 0)
            {
       
                string[] row = new string[] { lblLibelle.Text, nmMontant.Text};
                dgvfraisHorsForfait.Rows.Add(row);



                // dgvfraiskilometriques[1, dgvfraiskilometriques.RowCount+1].Value = cboModeDeTransport.SelectedValue;
            }
            else
            {
                dgvfraisHorsForfait[0, 0].Value = lblLibelle.Text;
            }
        }
 

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
