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
    }
}
