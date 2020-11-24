namespace Swiss_Visite
{
    partial class frmConexion
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
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMotdePasse = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMotdepasse = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.BackColor = System.Drawing.Color.DimGray;
            this.lblIdentifiant.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIdentifiant.Location = new System.Drawing.Point(65, 101);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(76, 15);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // lblMotdePasse
            // 
            this.lblMotdePasse.AutoSize = true;
            this.lblMotdePasse.BackColor = System.Drawing.Color.DimGray;
            this.lblMotdePasse.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotdePasse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMotdePasse.Location = new System.Drawing.Point(65, 158);
            this.lblMotdePasse.Name = "lblMotdePasse";
            this.lblMotdePasse.Size = new System.Drawing.Size(94, 15);
            this.lblMotdePasse.TabIndex = 1;
            this.lblMotdePasse.Text = "Mot de passe";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(165, 99);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 2;
            this.txtIdentifiant.Text = "veynde";
            // 
            // txtMotdepasse
            // 
            this.txtMotdepasse.Location = new System.Drawing.Point(165, 156);
            this.txtMotdepasse.Name = "txtMotdepasse";
            this.txtMotdepasse.PasswordChar = '*';
            this.txtMotdepasse.Size = new System.Drawing.Size(100, 20);
            this.txtMotdepasse.TabIndex = 3;
            this.txtMotdepasse.Text = "i7sn3";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(68, 251);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(190, 251);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblIdentifiant);
            this.panel1.Controls.Add(this.lblMotdePasse);
            this.panel1.Controls.Add(this.txtIdentifiant);
            this.panel1.Controls.Add(this.txtMotdepasse);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 208);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // frmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(374, 360);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.panel1);
            this.Name = "frmConexion";
            this.Text = "frmConexion";
            this.Load += new System.EventHandler(this.FrmConexion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMotdePasse;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotdepasse;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
    }
}