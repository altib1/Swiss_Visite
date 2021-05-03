namespace Swiss_Visite
{
    partial class FormMenuMission3
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
            this.label1 = new System.Windows.Forms.Label();
            this.bsNom = new System.Windows.Forms.BindingSource(this.components);
            this.btncreer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvfichesfrais = new System.Windows.Forms.DataGridView();
            this.cmbMois = new System.Windows.Forms.ComboBox();
            this.lblmois = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.bsComboMois = new System.Windows.Forms.BindingSource(this.components);
            this.lblNom = new System.Windows.Forms.Label();
            this.bsfichefrais = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfichesfrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsComboMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsfichefrais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bonjour ";
            // 
            // btncreer
            // 
            this.btncreer.Location = new System.Drawing.Point(13, 80);
            this.btncreer.Name = "btncreer";
            this.btncreer.Size = new System.Drawing.Size(172, 37);
            this.btncreer.TabIndex = 2;
            this.btncreer.Text = "creer une fiche";
            this.btncreer.UseVisualStyleBackColor = true;
            this.btncreer.Click += new System.EventHandler(this.Btncreer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Le Menu";
            // 
            // dgvfichesfrais
            // 
            this.dgvfichesfrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfichesfrais.Location = new System.Drawing.Point(215, 80);
            this.dgvfichesfrais.Name = "dgvfichesfrais";
            this.dgvfichesfrais.Size = new System.Drawing.Size(573, 358);
            this.dgvfichesfrais.TabIndex = 4;
            this.dgvfichesfrais.CurrentCellChanged += new System.EventHandler(this.dgvfichesfrais_CurrentCellChanged);
            // 
            // cmbMois
            // 
            this.cmbMois.FormattingEnabled = true;
            this.cmbMois.Location = new System.Drawing.Point(528, 26);
            this.cmbMois.Name = "cmbMois";
            this.cmbMois.Size = new System.Drawing.Size(121, 21);
            this.cmbMois.TabIndex = 5;
            // 
            // lblmois
            // 
            this.lblmois.AutoSize = true;
            this.lblmois.Location = new System.Drawing.Point(399, 29);
            this.lblmois.Name = "lblmois";
            this.lblmois.Size = new System.Drawing.Size(108, 13);
            this.lblmois.TabIndex = 6;
            this.lblmois.Text = "Selectionner un mois ";
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(13, 134);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(172, 37);
            this.btnModif.TabIndex = 7;
            this.btnModif.Text = "Modifier une fiche";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(116, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(0, 29);
            this.lblNom.TabIndex = 8;
            // 
            // FormMenuMission3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.lblmois);
            this.Controls.Add(this.cmbMois);
            this.Controls.Add(this.dgvfichesfrais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncreer);
            this.Controls.Add(this.label1);
            this.Name = "FormMenuMission3";
            this.Text = "FormMenuMission3";
            this.Load += new System.EventHandler(this.FormMenuMission3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfichesfrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsComboMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsfichefrais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsNom;
        private System.Windows.Forms.Button btncreer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvfichesfrais;
        private System.Windows.Forms.ComboBox cmbMois;
        private System.Windows.Forms.Label lblmois;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.BindingSource bsComboMois;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.BindingSource bsfichefrais;
    }
}