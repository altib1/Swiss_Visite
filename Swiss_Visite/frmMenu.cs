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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
           
        }

        public static void ThreadProc()
        {
            Application.Run(new Form2());
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (rbtnVisiteurs.Checked)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

                t.Start();
                this.Close();
            }
        }
    }
}
