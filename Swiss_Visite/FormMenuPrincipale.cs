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
    public partial class FormMenuPrincipale : Form
    {
        public FormMenuPrincipale()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsulterSonCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMenuPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void OptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ConsulterMesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void ConsulterMesInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultationForm1 consult = new consultationForm1();
            consult.Show();
        }

        private void REGIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ParRégionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegion region = new frmRegion();
            region.Show();

        }

        private void ParSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecteur secteur = new frmSecteur();
            secteur.Show();
        }
    }
}
