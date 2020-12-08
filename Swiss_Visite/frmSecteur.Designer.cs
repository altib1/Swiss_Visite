namespace Swiss_Visite
{
    partial class frmSecteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboSecteur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.bsSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSecteur
            // 
            this.cboSecteur.FormattingEnabled = true;
            this.cboSecteur.Location = new System.Drawing.Point(21, 32);
            this.cboSecteur.Name = "cboSecteur";
            this.cboSecteur.Size = new System.Drawing.Size(121, 21);
            this.cboSecteur.TabIndex = 0;
            this.cboSecteur.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du responsable";
            // 
            // txtResp
            // 
            this.txtResp.Location = new System.Drawing.Point(486, 36);
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(100, 20);
            this.txtResp.TabIndex = 2;
            // 
            // bsSecteur
            // 
            this.bsSecteur.CurrentChanged += new System.EventHandler(this.BsSecteur_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtResp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSecteur);
            this.Name = "frmSecteur";
            this.Text = "frmSecteur";
            this.Load += new System.EventHandler(this.FrmSecteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.BindingSource bsSecteur;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}