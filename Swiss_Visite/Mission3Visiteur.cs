﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TblVisiteur_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            Visiteur v2 = Model.rechercheVisiteur(Model.idclient);
            bsMatricule.DataSource = v2.idVisiteur.ToString();
            txtMatricule.Text = bsMatricule.DataSource.ToString();

            bsNom.DataSource = v2.nom.ToString();
            txtNom.Text = bsNom.DataSource.ToString();

            bsprenom.DataSource = v2.prenom.ToString();
            txtPrenom.Text = bsprenom.DataSource.ToString();

            // bsMois.DataSource = DateTime.Today.Month;
            // dtMois.Value.Month = bsMois.DataSource;
            dtMois.Value = DateTime.Today;
            //frais une Nuite
            bsNuit.DataSource = ModelMission3.rechercheFraisForfait("NUI");

            txtMontantNuit.Text = ((FraisForfait)bsNuit[0]).montant.ToString();
            //frais repas midi
            bsMidi.DataSource = ModelMission3.rechercheFraisForfait("REM");

            txtMontantMidi.Text = ((FraisForfait)bsMidi[0]).montant.ToString();
            //frais repas soir
            bsSoir.DataSource = ModelMission3.rechercheFraisForfait("RES");

            txtMontantSoir.Text = ((FraisForfait)bsSoir[0]).montant.ToString();
            //frais forfait nuite
            bsForfaitnuite.DataSource = ModelMission3.rechercheFraisForfait("ETP");

            txtMontantForfaitnuite.Text = ((FraisForfait)bsForfaitnuite[0]).montant.ToString();

            cboModeDeTransport.ValueMember = "id";//permet de stocker l'identifiant
            cboModeDeTransport.DisplayMember = "libelle";
            bsModedetransport.DataSource = ModelMission3.recherchefraiskilometrique();
            cboModeDeTransport.DataSource = bsModedetransport;


            bsdgvtransport.DataSource = ModelMission3.ajouterfichefrais(Model.idclient,DateTime.Now.Month.ToString());
            if(bsdgvtransport == null)
            {
                fichefrais visiteurchoisi = new fichefrais();
                visiteurchoisi.idVisiteur = Model.idclient.ToString();
                visiteurchoisi.mois = DateTime.Now.Month.ToString();
                visiteurchoisi.nbJustificatifs = 0;
                visiteurchoisi.montantValide = 0;
                visiteurchoisi.dateModif = DateTime.Now;
                visiteurchoisi.idEtat = "0";


               
              

            }

            txtTotalMidi.Text = (double.Parse(numMidi.Value.ToString()) * double.Parse(txtMontantMidi.Text)).ToString();
            
        }

        private void DgvForfait_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtQNuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void TblVisiteur_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void LblKilometrage_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CboModeDeTransport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAjoutertrans_Click(object sender, EventArgs e)
        {
            if (dgvfraiskilometriques.RowCount  > 0 )
            {
                string a = ((FraisForfait)bsModedetransport.Current).montant.ToString();
                double b = (double.Parse(txtQuantiteKilometres.Text) * double.Parse(a));
                string[] row = new string[] { txtQuantiteKilometres.Text, cboModeDeTransport.Text, b.ToString() };
                dgvfraiskilometriques.Rows.Add(row);
                


               // dgvfraiskilometriques[1, dgvfraiskilometriques.RowCount+1].Value = cboModeDeTransport.SelectedValue;
            }
            else
            {
                dgvfraiskilometriques[1, 0].Value = cboModeDeTransport.SelectedItem;
            }
           
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            string a = ((FraisForfait)bsModedetransport.Current).montant.ToString();
            double b = (double.Parse(txtQuantiteKilometres.Text) * double.Parse(a));
            // cboModeDeTransport.SelectedItem = dgvfraiskilometriques.SelectedRows[0].Cells[1].Value;
            dgvfraiskilometriques.SelectedRows[0].Cells[1].Value = cboModeDeTransport.Text;
            dgvfraiskilometriques.SelectedRows[0].Cells[0].Value = txtQuantiteKilometres.Text;
            dgvfraiskilometriques.SelectedRows[0].Cells[2].Value = b.ToString();
        }

        private void Dgvfraiskilometriques_SelectionChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(dgvfraiskilometriques.SelectedRows[0].Cells[1].Value.ToString());
            if (dgvfraiskilometriques.SelectedRows[0].Cells[1].Value != null)
            {
                cboModeDeTransport.Text = dgvfraiskilometriques.SelectedRows[0].Cells[1].Value.ToString();
                txtQuantiteKilometres.Text = dgvfraiskilometriques.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvfraiskilometriques.CurrentRow.Selected == true)
            {
                if (MessageBox.Show("voulez vous vraiement suprimer ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = dgvfraiskilometriques.CurrentCell.RowIndex;
                    dgvfraiskilometriques.Rows.RemoveAt(rowIndex);
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

        private void NumMidi_ValueChanged(object sender, EventArgs e)
        {
            txtTotalMidi.Text = (double.Parse(numMidi.Value.ToString()) * double.Parse(txtMontantMidi.Text)).ToString();
        }

        private void NumNuite_ValueChanged(object sender, EventArgs e)
        {
            txtTotalNuit.Text = (double.Parse(numNuite.Value.ToString()) * double.Parse(txtMontantNuit.Text)).ToString();
        }

        private void NumSoir_ValueChanged(object sender, EventArgs e)
        {
            txtTotalRepasSoir.Text = (double.Parse(numSoir.Value.ToString()) * double.Parse(txtMontantSoir.Text)).ToString();
        }

        private void NumForfaitnuite_ValueChanged(object sender, EventArgs e)
        {
            txttotalForfaitnuite.Text = (double.Parse(numForfaitnuite.Value.ToString()) * double.Parse(txtMontantForfaitnuite.Text)).ToString();
        }
    }
}
