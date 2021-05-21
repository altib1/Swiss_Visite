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
        private string moisanne;
        public FraisHorsForfait(string moisanneselectionne)
        {
            InitializeComponent();
            this.moisanne = moisanneselectionne;
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
           // string a = ((FraisForfait)bsModedetransport.Current).montant.ToString();
           // double b = (double.Parse(txtQuantiteKilometres.Text) * double.Parse(a));
           // cboModeDeTransport.SelectedItem = dgvfraiskilometriques.SelectedRows[0].Cells[1].Value;
            dgvfraisHorsForfait.SelectedRows[0].Cells[1].Value = nmMontant.Text;
            dgvfraisHorsForfait.SelectedRows[0].Cells[0].Value = lblLibelle.Text;
           
        }

        private void dgvfraisHorsForfait_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvfraisHorsForfait.Rows.Count == 0)
            {
                lblLibelle.Text = dgvfraisHorsForfait.SelectedRows[0].Cells[0].Value.ToString();
                nmMontant.Text = dgvfraisHorsForfait.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvfraisHorsForfait.CurrentRow.Selected == true && dgvfraisHorsForfait.Rows.Count > 1 && dgvfraisHorsForfait.Rows != null)
            {
                if (MessageBox.Show("voulez vous vraiement suprimer ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = dgvfraisHorsForfait.CurrentCell.RowIndex;
                   dgvfraisHorsForfait.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    // user clicked no
                }
            }
            else
            {
                MessageBox.Show("Selectionner la ligne que vous voulez supprimer");
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.Month + DateTime.Now.Year.ToString();
            Visiteur v2 = Model.rechercheVisiteur(Model.idclient);
            string matricule = v2.idVisiteur.ToString();

            for (int i = 0; i < dgvfraisHorsForfait.Rows.Count - 1; i++)
            {
                MessageBox.Show(dgvfraisHorsForfait.Rows[i].Cells[0].Value.ToString());
                MessageBox.Show(dgvfraisHorsForfait.Rows[i].Cells[1].Value.ToString());
                MessageBox.Show(moisanne);
                Model.enregfraishorsforfait(i.ToString(), matricule, this.moisanne, dgvfraisHorsForfait.Rows[i].Cells[0].Value.ToString(), dgvfraisHorsForfait.Rows[i].Cells[1].Value.ToString());


            }

            this.Close();
        }

        private void FraisHorsForfait_Load(object sender, EventArgs e)
        {

        }
    }
}
