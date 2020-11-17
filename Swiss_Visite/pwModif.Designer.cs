namespace Swiss_Visite
{
    partial class pwModif
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
            this.motDePasse1 = new System.Windows.Forms.TextBox();
            this.lanelMP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MotDePasse2 = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // motDePasse1
            // 
            this.motDePasse1.Location = new System.Drawing.Point(273, 41);
            this.motDePasse1.Name = "motDePasse1";
            this.motDePasse1.Size = new System.Drawing.Size(134, 20);
            this.motDePasse1.TabIndex = 0;
            this.motDePasse1.TextChanged += new System.EventHandler(this.MotDePasse1_TextChanged);
            // 
            // lanelMP
            // 
            this.lanelMP.AutoSize = true;
            this.lanelMP.Location = new System.Drawing.Point(36, 44);
            this.lanelMP.Name = "lanelMP";
            this.lanelMP.Size = new System.Drawing.Size(175, 13);
            this.lanelMP.TabIndex = 2;
            this.lanelMP.Text = "Entrez votre nouveau mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirmez votre nouveau mot de passe";
            // 
            // MotDePasse2
            // 
            this.MotDePasse2.Location = new System.Drawing.Point(273, 84);
            this.MotDePasse2.Name = "MotDePasse2";
            this.MotDePasse2.Size = new System.Drawing.Size(134, 20);
            this.MotDePasse2.TabIndex = 4;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(79, 168);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // pwModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.MotDePasse2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lanelMP);
            this.Controls.Add(this.motDePasse1);
            this.Name = "pwModif";
            this.Text = "pwModif";
            this.Load += new System.EventHandler(this.PwModif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox motDePasse1;
        private System.Windows.Forms.Label lanelMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MotDePasse2;
        private System.Windows.Forms.Button btnValider;
    }
}