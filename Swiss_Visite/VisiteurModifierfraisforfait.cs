using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Swiss_Visite
{
    public partial class VisiteurModifierfraisforfait : Form
    {
        private string mois;
        public VisiteurModifierfraisforfait(string mois)
        {
            InitializeComponent();
            this.mois = mois;
        }

        private void VisiteurModifierfraisforfait_Load(object sender, EventArgs e)
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
            // cbmois.Value = DateTime.Today;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fr-FR");

           
            int moisint = 2;
            if(int.Parse(mois.Substring(0, 2)) < 10)
            {
                moisint = int.Parse(mois.Substring(1, 1));
            }
            else
            {
                moisint = int.Parse(mois.Substring(0, 2));
            }
            MessageBox.Show(moisint.ToString());
            cbmois.DataSource = CultureInfo.DefaultThreadCurrentCulture.DateTimeFormat
                                                     .MonthNames.Take(12).ToList();
            cbmois.SelectedItem = CultureInfo.DefaultThreadCurrentCulture.DateTimeFormat
                                                     .MonthNames[moisint-1];


            //frais une Nuite
            bsNuit.DataSource = Model.rechercheFraisForfait("NUI");

            txtMontantNuit.Text = ((FraisForfait)bsNuit[0]).montant.ToString();
            //frais repas midi
            bsMidi.DataSource = Model.rechercheFraisForfait("REM");

            txtMontantMidi.Text = ((FraisForfait)bsMidi[0]).montant.ToString();
            //frais repas soir
            bsSoir.DataSource = Model.rechercheFraisForfait("RES");

            txtMontantSoir.Text = ((FraisForfait)bsSoir[0]).montant.ToString();
            //frais forfait nuite
            bsForfaitnuite.DataSource = Model.rechercheFraisForfait("ETP");

            txtMontantForfaitnuite.Text = ((FraisForfait)bsForfaitnuite[0]).montant.ToString();

            cboModeDeTransport.ValueMember = "id";//permet de stocker l'identifiant
            cboModeDeTransport.DisplayMember = "libelle";
            bsModedetransport.DataSource = Model.recherchefraiskilometrique();
            cboModeDeTransport.DataSource = bsModedetransport;


            bsdgvtransport.DataSource = Model.ajouterfichefrais(Model.idclient, DateTime.Now.Month.ToString());
            if (bsdgvtransport == null)
            {
                int moissansanne = DateTime.ParseExact(cbmois.SelectedItem.ToString(), "MMMM", CultureInfo.CurrentCulture).Month;

                if (moissansanne < 10)
                {
                    this.mois = "0" + moissansanne.ToString() + DateTime.Now.Year.ToString();
                }
                else
                {
                    this.mois = moissansanne.ToString() + DateTime.Now.Year.ToString();
                }

                fichefrais visiteurchoisi = new fichefrais();
                visiteurchoisi.idVisiteur = Model.idclient.ToString();
                visiteurchoisi.mois = this.mois;
                visiteurchoisi.nbJustificatifs = 0;
                visiteurchoisi.montantValide = 0;
                visiteurchoisi.dateModif = DateTime.Now;
                visiteurchoisi.idEtat = "0";





            }

            txtTotalMidi.Text = (double.Parse(numMidi.Value.ToString()) * double.Parse(txtMontantMidi.Text)).ToString();


            if (Model.LignefraisForfaitNUI(v2.idVisiteur.ToString(), mois) != null)
            {
                bsNuiNum.DataSource = Model.LignefraisForfaitNUI(v2.idVisiteur.ToString(), mois);
                numNuite.Value = int.Parse(((LigneFraisForfait)bsNuiNum[0]).quantite.ToString());
            }

            if (Model.LignefraisForfaitREM(v2.idVisiteur.ToString(), mois) != null)
            {
                bsRemNum.DataSource = Model.LignefraisForfaitREM(v2.idVisiteur.ToString(), mois);
                numMidi.Value = int.Parse(((LigneFraisForfait)bsRemNum[0]).quantite.ToString());
            }


            if (Model.LignefraisForfaitRES(v2.idVisiteur.ToString(), mois) != null)
            {
                bsResNum.DataSource = Model.LignefraisForfaitRES(v2.idVisiteur.ToString(), mois);
                numSoir.Value = int.Parse(((LigneFraisForfait)bsResNum[0]).quantite.ToString());
            }

            if (Model.LignefraisForfaitETP(v2.idVisiteur.ToString(), mois) != null)
            {

                bsEtpNum.DataSource = Model.LignefraisForfaitETP(v2.idVisiteur.ToString(), mois);
                numForfaitnuite.Value = int.Parse(((LigneFraisForfait)bsEtpNum[0]).quantite.ToString());
            }

            if(Model.LignefraisForfaitkilometrique(v2.idVisiteur.ToString(), mois) != null)
            {
                bsdgvtransport.DataSource = Model.LignefraisForfaitkilometrique(v2.idVisiteur.ToString(), mois);
                foreach (LigneFraisForfait l in bsdgvtransport)
                {
                    


                    if (dgvfraiskilometriques.RowCount > 0)
                    {
                        string a = l.quantite.ToString();
                        double b = (double.Parse(l.FraisForfait.montant.ToString()) * double.Parse(a));
                        string[] row = new string[] { l.quantite.ToString(), l.idFraisForfait.ToString(), b.ToString() };
                        dgvfraiskilometriques.Rows.Add(row);



                        // dgvfraiskilometriques[1, dgvfraiskilometriques.RowCount+1].Value = cboModeDeTransport.SelectedValue;
                    }
                    else
                    {
                        dgvfraiskilometriques[1, 0].Value = cboModeDeTransport.SelectedItem;
                    }
                }
            }

        }

        private void btnAjoutertrans_Click(object sender, EventArgs e)
        {
            if (dgvfraiskilometriques.RowCount > 0)
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string a = ((FraisForfait)bsModedetransport.Current).montant.ToString();
            double b = (double.Parse(txtQuantiteKilometres.Text) * double.Parse(a));
            // cboModeDeTransport.SelectedItem = dgvfraiskilometriques.SelectedRows[0].Cells[1].Value;
            dgvfraiskilometriques.SelectedRows[0].Cells[1].Value = cboModeDeTransport.Text;
            dgvfraiskilometriques.SelectedRows[0].Cells[0].Value = txtQuantiteKilometres.Text;
            dgvfraiskilometriques.SelectedRows[0].Cells[2].Value = b.ToString();
        }

        private void dgvfraiskilometriques_SelectionChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(dgvfraiskilometriques.SelectedRows[0].Cells[1].Value.ToString());
            if (dgvfraiskilometriques.SelectedRows[0].Cells[1].Value != null)
            {
                cboModeDeTransport.Text = dgvfraiskilometriques.SelectedRows[0].Cells[1].Value.ToString();
                txtQuantiteKilometres.Text = dgvfraiskilometriques.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvfraiskilometriques.CurrentRow.Selected == true && dgvfraiskilometriques.Rows.Count > 1 && dgvfraiskilometriques.Rows != null)
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

        private void numNuite_ValueChanged(object sender, EventArgs e)
        {
            txtTotalNuit.Text = (double.Parse(numNuite.Value.ToString()) * double.Parse(txtMontantNuit.Text)).ToString();

        }

        private void numMidi_ValueChanged(object sender, EventArgs e)
        {
            txtTotalMidi.Text = (double.Parse(numMidi.Value.ToString()) * double.Parse(txtMontantMidi.Text)).ToString();

        }

        private void numSoir_ValueChanged(object sender, EventArgs e)
        {
            txtTotalRepasSoir.Text = (double.Parse(numSoir.Value.ToString()) * double.Parse(txtMontantSoir.Text)).ToString();

        }

        private void numForfaitnuite_ValueChanged(object sender, EventArgs e)
        {
            txttotalForfaitnuite.Text = (double.Parse(numForfaitnuite.Value.ToString()) * double.Parse(txtMontantForfaitnuite.Text)).ToString();

        }

        public static void ThreadProc()
        {
            Application.Run(new FormMenuMission3());
        }

        private void btnAnnulerfraistransport_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

            t.Start();
            this.Close();
        }

        private void btnValiderfichefrais_Click(object sender, EventArgs e)
        {
            int moissansanne = DateTime.ParseExact(cbmois.SelectedItem.ToString(), "MMMM", CultureInfo.CurrentCulture).Month;

            if (moissansanne < 10)
            {
                this.mois = "0" + moissansanne.ToString() + DateTime.Now.Year.ToString();
            }
            else
            {
                this.mois = moissansanne.ToString() + DateTime.Now.Year.ToString();
            }

            string date = DateTime.Now.Month + DateTime.Now.Year.ToString();
            Model.alterenregnuite(txtMatricule.Text, this.mois, "NUI", numNuite.Value.ToString());
            Model.alterenregmidi(txtMatricule.Text, this.mois, "REM", numMidi.Value.ToString());
            Model.alterenregsoir(txtMatricule.Text, this.mois, "RES", numSoir.Value.ToString());
            Model.alterenregforfnuite(txtMatricule.Text, this.mois, "ETP", numForfaitnuite.Value.ToString());
            for (int i = 0; i < dgvfraiskilometriques.Rows.Count - 1; i++)
            {
                if (dgvfraiskilometriques.RowCount > 0)
                {

                    MessageBox.Show("L'application ne gere pas la modification des transports pour l'instant");
                   // Model.alterenregfraiskm(txtMatricule.Text, this.mois, ((FraisForfait)Model.idlignefrais(dgvfraiskilometriques.Rows[i].Cells[1].Value.ToString())).id, int.Parse(dgvfraiskilometriques.Rows[i].Cells[0].Value.ToString()));
                }
            }
            MessageBox.Show("Enregistrement effectue");

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

            t.Start();
            this.Close();

        }

        public static void ThreadProchorsforfait()
        {
            Application.Run(new FraisHorsForafaitModifier());
        }

        private void btnfraishorsforfait_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProchorsforfait));

            t.Start();
        }

        private void lemoisamodifier(string mois)
        {
            this.mois = mois;
        }

        


    }
}
