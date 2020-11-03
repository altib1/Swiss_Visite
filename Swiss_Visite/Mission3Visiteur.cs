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

            bsNuit.DataSource = ModelMission3.rechercheFraisForfait("NUI").montant.ToString();
            txtMontantNuit.Text = bsNuit.DataSource.ToString();


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
    }
}
