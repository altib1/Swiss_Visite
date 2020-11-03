namespace Swiss_Visite
{
    partial class consultationForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Rue = new System.Windows.Forms.TextBox();
            this.CP = new System.Windows.Forms.TextBox();
            this.Ville = new System.Windows.Forms.TextBox();
            this.DateEmbauche = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rue";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CP";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ville";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DateEmbauche";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // Nom
            // 
            this.Nom.Enabled = false;
            this.Nom.Location = new System.Drawing.Point(135, 38);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 20);
            this.Nom.TabIndex = 7;
            this.Nom.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Prenom
            // 
            this.Prenom.Enabled = false;
            this.Prenom.Location = new System.Drawing.Point(135, 81);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(100, 20);
            this.Prenom.TabIndex = 8;
            this.Prenom.TextChanged += new System.EventHandler(this.Prenom_TextChanged);
            // 
            // Rue
            // 
            this.Rue.Enabled = false;
            this.Rue.Location = new System.Drawing.Point(135, 128);
            this.Rue.Name = "Rue";
            this.Rue.Size = new System.Drawing.Size(100, 20);
            this.Rue.TabIndex = 9;
            this.Rue.TextChanged += new System.EventHandler(this.Rue_TextChanged);
            // 
            // CP
            // 
            this.CP.Enabled = false;
            this.CP.Location = new System.Drawing.Point(135, 165);
            this.CP.MaxLength = 5;
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(100, 20);
            this.CP.TabIndex = 10;
            this.CP.TextChanged += new System.EventHandler(this.CP_TextChanged);
            // 
            // Ville
            // 
            this.Ville.Enabled = false;
            this.Ville.Location = new System.Drawing.Point(135, 209);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(100, 20);
            this.Ville.TabIndex = 11;
            this.Ville.TextChanged += new System.EventHandler(this.Ville_TextChanged);
            // 
            // DateEmbauche
            // 
            this.DateEmbauche.Enabled = false;
            this.DateEmbauche.Location = new System.Drawing.Point(135, 254);
            this.DateEmbauche.Name = "DateEmbauche";
            this.DateEmbauche.Size = new System.Drawing.Size(100, 20);
            this.DateEmbauche.TabIndex = 12;
            this.DateEmbauche.TextChanged += new System.EventHandler(this.DateEmbauche_TextChanged);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(160, 318);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 13;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(48, 318);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.Btn_Click);
            // 
            // consultationForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.DateEmbauche);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.CP);
            this.Controls.Add(this.Rue);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "consultationForm1";
            this.Text = "consultationForm1";
            this.Load += new System.EventHandler(this.ConsultationForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Rue;
        private System.Windows.Forms.TextBox CP;
        private System.Windows.Forms.TextBox Ville;
        private System.Windows.Forms.TextBox DateEmbauche;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnOk;
    }
}