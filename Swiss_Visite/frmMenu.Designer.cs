namespace Swiss_Visite
{
    partial class frmMenu
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
            this.lblgestiondescomptesrendus = new System.Windows.Forms.Label();
            this.rbtnComptesrendus = new System.Windows.Forms.RadioButton();
            this.rbtnVisiteurs = new System.Windows.Forms.RadioButton();
            this.rbtnPracticiens = new System.Windows.Forms.RadioButton();
            this.rbtnMedicaments = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblgestiondescomptesrendus
            // 
            this.lblgestiondescomptesrendus.AutoSize = true;
            this.lblgestiondescomptesrendus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblgestiondescomptesrendus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblgestiondescomptesrendus.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestiondescomptesrendus.ForeColor = System.Drawing.Color.White;
            this.lblgestiondescomptesrendus.Location = new System.Drawing.Point(382, 77);
            this.lblgestiondescomptesrendus.Name = "lblgestiondescomptesrendus";
            this.lblgestiondescomptesrendus.Size = new System.Drawing.Size(311, 28);
            this.lblgestiondescomptesrendus.TabIndex = 0;
            this.lblgestiondescomptesrendus.Text = "Gestion des comptes rendus";
            // 
            // rbtnComptesrendus
            // 
            this.rbtnComptesrendus.AutoSize = true;
            this.rbtnComptesrendus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtnComptesrendus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnComptesrendus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnComptesrendus.Location = new System.Drawing.Point(106, 23);
            this.rbtnComptesrendus.Name = "rbtnComptesrendus";
            this.rbtnComptesrendus.Size = new System.Drawing.Size(133, 23);
            this.rbtnComptesrendus.TabIndex = 1;
            this.rbtnComptesrendus.TabStop = true;
            this.rbtnComptesrendus.Text = "Comptes-Rendus";
            this.rbtnComptesrendus.UseVisualStyleBackColor = false;
            // 
            // rbtnVisiteurs
            // 
            this.rbtnVisiteurs.AutoSize = true;
            this.rbtnVisiteurs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtnVisiteurs.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVisiteurs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnVisiteurs.Location = new System.Drawing.Point(106, 72);
            this.rbtnVisiteurs.Name = "rbtnVisiteurs";
            this.rbtnVisiteurs.Size = new System.Drawing.Size(79, 23);
            this.rbtnVisiteurs.TabIndex = 2;
            this.rbtnVisiteurs.TabStop = true;
            this.rbtnVisiteurs.Text = "Visiteurs";
            this.rbtnVisiteurs.UseVisualStyleBackColor = false;
            // 
            // rbtnPracticiens
            // 
            this.rbtnPracticiens.AutoSize = true;
            this.rbtnPracticiens.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtnPracticiens.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPracticiens.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnPracticiens.Location = new System.Drawing.Point(106, 120);
            this.rbtnPracticiens.Name = "rbtnPracticiens";
            this.rbtnPracticiens.Size = new System.Drawing.Size(93, 23);
            this.rbtnPracticiens.TabIndex = 3;
            this.rbtnPracticiens.TabStop = true;
            this.rbtnPracticiens.Text = "Practiciens";
            this.rbtnPracticiens.UseVisualStyleBackColor = false;
            // 
            // rbtnMedicaments
            // 
            this.rbtnMedicaments.AutoSize = true;
            this.rbtnMedicaments.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtnMedicaments.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMedicaments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnMedicaments.Location = new System.Drawing.Point(106, 164);
            this.rbtnMedicaments.Name = "rbtnMedicaments";
            this.rbtnMedicaments.Size = new System.Drawing.Size(110, 23);
            this.rbtnMedicaments.TabIndex = 4;
            this.rbtnMedicaments.TabStop = true;
            this.rbtnMedicaments.Text = "Medicaments";
            this.rbtnMedicaments.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(281, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 146);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.btnValider);
            this.panel2.Controls.Add(this.rbtnMedicaments);
            this.panel2.Controls.Add(this.rbtnComptesrendus);
            this.panel2.Controls.Add(this.rbtnPracticiens);
            this.panel2.Controls.Add(this.rbtnVisiteurs);
            this.panel2.Location = new System.Drawing.Point(281, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 312);
            this.panel2.TabIndex = 6;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(106, 231);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(155, 41);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 450);
            this.panel3.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblgestiondescomptesrendus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgestiondescomptesrendus;
        private System.Windows.Forms.RadioButton rbtnComptesrendus;
        private System.Windows.Forms.RadioButton rbtnVisiteurs;
        private System.Windows.Forms.RadioButton rbtnPracticiens;
        private System.Windows.Forms.RadioButton rbtnMedicaments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Panel panel3;
    }
}