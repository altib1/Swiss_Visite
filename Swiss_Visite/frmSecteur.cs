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
    public partial class frmSecteur : Form
    {
        public frmSecteur()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmSecteur_Load(object sender, EventArgs e)
        {
           cboSecteur.ValueMember = "idSecteur";//permet de stocker l'identifiant
           cboSecteur.DisplayMember = "libSecteur";
            bsSecteur.DataSource = Model.listesecteur();
            bsSecteur.DataSource = bsSecteur;
        }

        private void BsSecteur_CurrentChanged(object sender, EventArgs e)
        {
           
           




           // txtResp.Text = ((Secteur)bsSecteur.Current).Visiteur.nom;
            //prenomResp.Text = ((Region)bsSecteur.Current).Visiteur.prenom;


            /*

            bsVisiteur.DataSource = ((Visiteur)bsRe.Current).Visiteur1.ToList();
            dgvVisiteur.DataSource = bsVisiteur;
            




            for (int i = 0; i < dgvVisiteur.ColumnCount; i++)
            {
                dgvVisiteur.Columns[i].Visible = false;
            }
            dgvVisiteur.Columns["nom"].Visible = true;
            dgvVisiteur.Columns["nom"].HeaderText = "NOM";
            dgvVisiteur.Columns["prenom"].Visible = true;
            dgvVisiteur.Columns["prenom"].HeaderText = "PRENOM";
            dgvVisiteur.ClearSelection();
            txtResp.Text = ((Region)bsRegion.Current).Visiteur.nom;
            prenomResp.Text = ((Region)bsRegion.Current).Visiteur.prenom;
            */

        }
    }
}
