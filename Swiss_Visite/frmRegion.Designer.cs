namespace Swiss_Visite
{
    partial class frmRegion
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
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.prenomResp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRegion
            // 
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(26, 12);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(121, 21);
            this.cboRegion.TabIndex = 0;
            this.cboRegion.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // bsRegion
            // 
            this.bsRegion.CurrentChanged += new System.EventHandler(this.BsRegion_CurrentChanged);
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(26, 131);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(353, 169);
            this.dgvVisiteur.TabIndex = 1;
            this.dgvVisiteur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVisiteur_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom responsable";
            // 
            // txtResp
            // 
            this.txtResp.Location = new System.Drawing.Point(483, 9);
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(100, 20);
            this.txtResp.TabIndex = 3;
            this.txtResp.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // prenomResp
            // 
            this.prenomResp.Location = new System.Drawing.Point(483, 46);
            this.prenomResp.Name = "prenomResp";
            this.prenomResp.Size = new System.Drawing.Size(100, 20);
            this.prenomResp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom responsable";
            // 
            // frmRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prenomResp);
            this.Controls.Add(this.txtResp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.cboRegion);
            this.Name = "frmRegion";
            this.Text = "frmRegion";
            this.Load += new System.EventHandler(this.FrmRegion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.TextBox prenomResp;
        private System.Windows.Forms.Label label2;
    }
}