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
    public partial class pwModif : Form
    {
        public pwModif()
        {
            InitializeComponent();
        }

        private void PwModif_Load(object sender, EventArgs e)
        {
            Visiteur v = Model.getUtil();
            
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            string password = motDePasse1.Text.Trim();
            string password2 = MotDePasse2.Text.Trim();
            if (password == password2)
            {
                Model.ModifMP(password);
                MessageBox.Show("Mot de passe modifié");

            }
            else
            {

                MessageBox.Show("Erreur");


            }
           
            

        }

        private void MotDePasse1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
