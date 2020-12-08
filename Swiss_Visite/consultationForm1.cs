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
    public partial class consultationForm1 : Form
    {
        public consultationForm1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Ville_TextChanged(object sender, EventArgs e)
        {

        }

        private void CP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rue_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateEmbauche_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultationForm1_Load(object sender, EventArgs e)
        {
            Visiteur v = Model.getUtil();

            Nom.Text = v.nom;
            Prenom.Text = v.prenom;
            Rue.Text = v.rue;
            CP.Text = v.cp;
            Ville.Text = v.ville;
            DateEmbauche.Text = v.dateEmbauche;


            dgvRegion.DataSource = Model.UtilisateurConnecte.Region1.ToList();
            dgvSecteur.DataSource = Model.UtilisateurConnecte.Secteur.ToList();

            
            dgvRegion1.DataSource = Model.UtilisateurConnecte.Region.ToList();


            for (int i = 0; i < dgvRegion.ColumnCount; i++)
            {
                dgvRegion.Columns[i].Visible = false;
            }
            dgvRegion.Columns[1].Visible = true;

            dgvRegion.Columns[1].HeaderText = "Région(s) rattachée(s)";

            for (int i = 0; i < dgvSecteur.ColumnCount; i++)
            {
                dgvSecteur.Columns[i].Visible = false;
            }
            dgvSecteur.Columns[1].Visible = true;
            dgvSecteur.Columns[1].HeaderText = "Secteur(s) (s)";

            for (int i = 0; i < dgvRegion1.ColumnCount; i++)
            {
                dgvRegion1.Columns[i].Visible = false;
            }
            dgvRegion1.Columns[1].Visible = true;

            dgvRegion1.Columns[1].HeaderText = "Région(s) ";
            if(dgvRegion1.RowCount==0)
            {

                dgvRegion1.Visible= false;

            }



        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            Nom.Enabled = true;
            Prenom.Enabled = true;
            Rue.Enabled = true;
            CP.Enabled = true;
            Ville.Enabled = true;
            DateEmbauche.Enabled = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string nom = Nom.Text.Trim();
            string prenom = Prenom.Text.Trim();
            string rue = Rue.Text.Trim();
            string cp= CP.Text.Trim();
            string ville = Ville.Text.Trim();
            string dateEmbauche = DateEmbauche.Text.Trim();
            Model.Modif(nom, prenom, rue, cp, ville, dateEmbauche);
        }

        private void BtnMotDePasse_Click(object sender, EventArgs e)
        {
           pwModif modifPW=new pwModif();
            modifPW.Show();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
