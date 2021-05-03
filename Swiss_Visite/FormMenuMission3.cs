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

            bsComboMois.DataSource = ModelMission3.recherchefichefrais(v2.idVisiteur.ToString());
            cmbMois.DataSource = bsComboMois;



        //    for (int i = DateTime.Today.Year; i >= 1800; i--)
        //    {

        //        cmbMois.Items.Add(i);
        //    }

            bsfichefrais.DataSource = ModelMission3.ToutesLesfichesfrais();
            dgvfichesfrais.DataSource = bsfichefrais;
            dgvfichesfrais.Columns[0].HeaderText = "Mois";
            dgvfichesfrais.Columns[1].HeaderText = "NB justificatifs";
            dgvfichesfrais.Columns[2].HeaderText = "date de modification";
            dgvfichesfrais.Columns[3].HeaderText = "l'etat";




        }

        public static void ThreadProc()
        {
            Application.Run(new Form2());
        }
        private void Btncreer_Click(object sender, EventArgs e)
        {
            Visiteur v2 = Model.rechercheVisiteur(Model.idclient);
            string matricule = v2.idVisiteur.ToString();
            string date = DateTime.Now.Month + DateTime.Now.Year.ToString();

            ModelMission3.enregfichefrais(matricule, "62021", "CR", "0");
            
                
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

                t.Start();
                this.Close();
            
            
            
        }

        private void dgvfichesfrais_CurrentCellChanged(object sender, EventArgs e)
        {

        }
    }
}
