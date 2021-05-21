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
    public partial class FormMenuMission3 : Form
    {
        private string moismodifier;
        public FormMenuMission3()
        {
            InitializeComponent();
        }

        private void FormMenuMission3_Load(object sender, EventArgs e)
        {


            Visiteur v2 = Model.rechercheVisiteur(Model.idclient);

            bsNom.DataSource = v2.prenom.ToString();
            lblNom.Text = bsNom.DataSource.ToString();

            cmbMois.ValueMember = "id";//permet de stocker l'identifiant
            cmbMois.DisplayMember = "libelle";

           // bsComboMois.DataSource = Model.recherchefichefrais(v2.idVisiteur.ToString());
           // cmbMois.DataSource = bsComboMois;
    



           for (int i = DateTime.Today.Year; i >= 1800; i--)
            {

               cmbMois.Items.Add(i);
            }

            //bsfichefrais.DataSource = Model.ToutesLesfichesfrais(v2.idVisiteur.ToString());
            //dgvfichesfrais.DataSource = bsfichefrais;
            //dgvfichesfrais.Columns[0].HeaderText = "ID";
            //dgvfichesfrais.Columns[1].HeaderText = "date de modification";
            //dgvfichesfrais.Columns[2].HeaderText = "Mois";




        }

        public static void ThreadProc()
        {
            Application.Run(new Form2());
        }
        private void Btncreer_Click(object sender, EventArgs e)
        {
            string moisanne;
            if (DateTime.Now.Month < 10)
            {
                moisanne = "0" + DateTime.Now.Year.ToString();
            }
            else
            {
                moisanne =  DateTime.Now.Year.ToString();
            }

            Visiteur v2 = Model.rechercheVisiteur(Model.idclient);
            string matricule = v2.idVisiteur.ToString();
            string date = DateTime.Now.Month + DateTime.Now.Year.ToString();

            Model.enregfichefrais(matricule, moisanne, "CR", "0");
            
                
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

                t.Start();
                this.Close();
            
            
            
        }

        private void dgvfichesfrais_CurrentCellChanged(object sender, EventArgs e)
        {

        }
        public void ThreadProcVisiteurModifier()
        {
            
            Application.Run(new VisiteurModifierfraisforfait(this.moismodifier));
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (dgvfichesfrais.SelectedRows.Count > 0)
            {
                //permets de passer la valeur du mois choisi dans le forms VisiteurModifierfraisforfait
                this.moismodifier = dgvfichesfrais.CurrentRow.Cells[1].Value.ToString();
                MessageBox.Show(this.moismodifier);
                
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcVisiteurModifier));
                
                t.Start();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Veuillz selectionner un fichefrais pour le modifier !");
            }
        }

        private void cmbMois_SelectedIndexChanged(object sender, EventArgs e)
        {
        

            Visiteur v2 = Model.rechercheVisiteur(Model.idclient);
           
          
                bsfichefrais.DataSource = Model.ToutesLesfichesfrais(v2.idVisiteur.ToString(), cmbMois.SelectedItem.ToString());
              
                    dgvfichesfrais.DataSource = bsfichefrais;

                    for (int i = 0; i < dgvfichesfrais.ColumnCount; i++)
                    {
                        dgvfichesfrais.Columns[i].Visible = false;
                    }

                    dgvfichesfrais.Columns[0].Visible = true;
                    dgvfichesfrais.Columns[1].Visible = true;
                    dgvfichesfrais.Columns[2].Visible = false;
                    dgvfichesfrais.Columns[3].Visible = false;
                    dgvfichesfrais.Columns[4].Visible = true;
                    dgvfichesfrais.Columns[5].Visible = false;
                
          
              


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
