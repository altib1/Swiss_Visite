namespace Swiss_Visite
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMontantAutre = new System.Windows.Forms.Label();
            this.lblDateAutre = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblAutre = new System.Windows.Forms.Label();
            this.dtMois = new System.Windows.Forms.DateTimePicker();
            this.lblMois = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.lblmatricule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.bsMatricule = new System.Windows.Forms.BindingSource(this.components);
            this.bsNom = new System.Windows.Forms.BindingSource(this.components);
            this.bsMois = new System.Windows.Forms.BindingSource(this.components);
            this.dgvHorsforfait = new System.Windows.Forms.DataGridView();
            this.bsHorsforfait = new System.Windows.Forms.BindingSource(this.components);
            this.bsForfait = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.bsprenom = new System.Windows.Forms.BindingSource(this.components);
            this.tblVisiteur = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotalVehicule = new System.Windows.Forms.TextBox();
            this.txtMontantVehicule = new System.Windows.Forms.TextBox();
            this.txtQVehicule = new System.Windows.Forms.TextBox();
            this.txtTotalMidi = new System.Windows.Forms.TextBox();
            this.txtMontantMidi = new System.Windows.Forms.TextBox();
            this.txtQMidi = new System.Windows.Forms.TextBox();
            this.txtTotalNuit = new System.Windows.Forms.TextBox();
            this.lnlNuite = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblFrais = new System.Windows.Forms.Label();
            this.lblMontatnt = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRepasMidi = new System.Windows.Forms.Label();
            this.lblKilometrage = new System.Windows.Forms.Label();
            this.txtQNuit = new System.Windows.Forms.TextBox();
            this.txtMontantNuit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatricule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorsforfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHorsforfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsprenom)).BeginInit();
            this.tblVisiteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tblVisiteur);
            this.panel1.Controls.Add(this.txtPrenom);
            this.panel1.Controls.Add(this.dgvHorsforfait);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.lblAutre);
            this.panel1.Controls.Add(this.dtMois);
            this.panel1.Controls.Add(this.lblMois);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Controls.Add(this.txtMatricule);
            this.panel1.Controls.Add(this.lblmatricule);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbldescription);
            this.panel1.Controls.Add(this.lblTitre);
            this.panel1.Location = new System.Drawing.Point(69, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 566);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.19549F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.80451F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Controls.Add(this.lblMontantAutre, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDateAutre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLibelle, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 375);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 26);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // lblMontantAutre
            // 
            this.lblMontantAutre.AutoSize = true;
            this.lblMontantAutre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantAutre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMontantAutre.Location = new System.Drawing.Point(534, 3);
            this.lblMontantAutre.Name = "lblMontantAutre";
            this.lblMontantAutre.Size = new System.Drawing.Size(62, 16);
            this.lblMontantAutre.TabIndex = 12;
            this.lblMontantAutre.Text = "Montant";
            // 
            // lblDateAutre
            // 
            this.lblDateAutre.AutoSize = true;
            this.lblDateAutre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAutre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDateAutre.Location = new System.Drawing.Point(6, 3);
            this.lblDateAutre.Name = "lblDateAutre";
            this.lblDateAutre.Size = new System.Drawing.Size(41, 16);
            this.lblDateAutre.TabIndex = 14;
            this.lblDateAutre.Text = "Date";
            // 
            // lblLibelle
            // 
            this.lblLibelle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLibelle.Location = new System.Drawing.Point(156, 3);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(369, 20);
            this.lblLibelle.TabIndex = 13;
            this.lblLibelle.Text = "Libelle";
            this.lblLibelle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAutre
            // 
            this.lblAutre.AutoSize = true;
            this.lblAutre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAutre.Location = new System.Drawing.Point(298, 356);
            this.lblAutre.Name = "lblAutre";
            this.lblAutre.Size = new System.Drawing.Size(91, 16);
            this.lblAutre.TabIndex = 10;
            this.lblAutre.Text = "Autres Frais";
            // 
            // dtMois
            // 
            this.dtMois.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMois.Location = new System.Drawing.Point(86, 174);
            this.dtMois.Name = "dtMois";
            this.dtMois.Size = new System.Drawing.Size(200, 20);
            this.dtMois.TabIndex = 8;
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMois.Location = new System.Drawing.Point(34, 174);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(46, 16);
            this.lblMois.TabIndex = 7;
            this.lblMois.Text = "Mois : ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(249, 121);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(97, 20);
            this.txtNom.TabIndex = 6;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(161, 121);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(46, 16);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom : ";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(249, 81);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(388, 20);
            this.txtMatricule.TabIndex = 4;
            // 
            // lblmatricule
            // 
            this.lblmatricule.AutoSize = true;
            this.lblmatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatricule.Location = new System.Drawing.Point(161, 81);
            this.lblmatricule.Name = "lblmatricule";
            this.lblmatricule.Size = new System.Drawing.Size(68, 16);
            this.lblmatricule.TabIndex = 3;
            this.lblmatricule.Text = "Matricule :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(34, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visiteur";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbldescription.Location = new System.Drawing.Point(17, 34);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(641, 15);
            this.lbldescription.TabIndex = 1;
            this.lbldescription.Text = "A retourner, accompagné des justificatifs au plus tard le 10 du mois qui suit l\'e" +
    "ngagement des frais";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitre.Location = new System.Drawing.Point(184, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(298, 25);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "ETAT DE FRAIS ENGAGES";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSignature.Location = new System.Drawing.Point(617, 656);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(74, 16);
            this.lblSignature.TabIndex = 12;
            this.lblSignature.Text = "Signature";
            // 
            // bsMois
            // 
            this.bsMois.CurrentChanged += new System.EventHandler(this.BindingSource1_CurrentChanged);
            // 
            // dgvHorsforfait
            // 
            this.dgvHorsforfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorsforfait.Location = new System.Drawing.Point(7, 407);
            this.dgvHorsforfait.Name = "dgvHorsforfait";
            this.dgvHorsforfait.Size = new System.Drawing.Size(651, 150);
            this.dgvHorsforfait.TabIndex = 12;
            this.dgvHorsforfait.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(352, 121);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 14;
            // 
            // tblVisiteur
            // 
            this.tblVisiteur.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tblVisiteur.ColumnCount = 4;
            this.tblVisiteur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.1282F));
            this.tblVisiteur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.8718F));
            this.tblVisiteur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tblVisiteur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblVisiteur.Controls.Add(this.txtTotalVehicule, 3, 3);
            this.tblVisiteur.Controls.Add(this.txtMontantVehicule, 2, 3);
            this.tblVisiteur.Controls.Add(this.txtQVehicule, 1, 3);
            this.tblVisiteur.Controls.Add(this.txtTotalMidi, 3, 2);
            this.tblVisiteur.Controls.Add(this.txtMontantMidi, 2, 2);
            this.tblVisiteur.Controls.Add(this.txtQMidi, 1, 2);
            this.tblVisiteur.Controls.Add(this.txtTotalNuit, 3, 1);
            this.tblVisiteur.Controls.Add(this.lnlNuite, 0, 1);
            this.tblVisiteur.Controls.Add(this.lblQuantite, 1, 0);
            this.tblVisiteur.Controls.Add(this.lblFrais, 0, 0);
            this.tblVisiteur.Controls.Add(this.lblTotal, 3, 0);
            this.tblVisiteur.Controls.Add(this.lblRepasMidi, 0, 2);
            this.tblVisiteur.Controls.Add(this.lblKilometrage, 0, 3);
            this.tblVisiteur.Controls.Add(this.txtQNuit, 1, 1);
            this.tblVisiteur.Controls.Add(this.txtMontantNuit, 2, 1);
            this.tblVisiteur.Controls.Add(this.lblMontatnt, 2, 0);
            this.tblVisiteur.Location = new System.Drawing.Point(13, 224);
            this.tblVisiteur.Name = "tblVisiteur";
            this.tblVisiteur.Padding = new System.Windows.Forms.Padding(5);
            this.tblVisiteur.RowCount = 4;
            this.tblVisiteur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.42029F));
            this.tblVisiteur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.57971F));
            this.tblVisiteur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblVisiteur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblVisiteur.Size = new System.Drawing.Size(655, 129);
            this.tblVisiteur.TabIndex = 15;
            // 
            // txtTotalVehicule
            // 
            this.txtTotalVehicule.Location = new System.Drawing.Point(539, 96);
            this.txtTotalVehicule.Name = "txtTotalVehicule";
            this.txtTotalVehicule.Size = new System.Drawing.Size(101, 20);
            this.txtTotalVehicule.TabIndex = 24;
            // 
            // txtMontantVehicule
            // 
            this.txtMontantVehicule.Location = new System.Drawing.Point(238, 96);
            this.txtMontantVehicule.Name = "txtMontantVehicule";
            this.txtMontantVehicule.Size = new System.Drawing.Size(291, 20);
            this.txtMontantVehicule.TabIndex = 23;
            // 
            // txtQVehicule
            // 
            this.txtQVehicule.Location = new System.Drawing.Point(158, 96);
            this.txtQVehicule.Name = "txtQVehicule";
            this.txtQVehicule.Size = new System.Drawing.Size(71, 20);
            this.txtQVehicule.TabIndex = 22;
            // 
            // txtTotalMidi
            // 
            this.txtTotalMidi.Location = new System.Drawing.Point(539, 64);
            this.txtTotalMidi.Name = "txtTotalMidi";
            this.txtTotalMidi.Size = new System.Drawing.Size(101, 20);
            this.txtTotalMidi.TabIndex = 21;
            // 
            // txtMontantMidi
            // 
            this.txtMontantMidi.Location = new System.Drawing.Point(238, 64);
            this.txtMontantMidi.Name = "txtMontantMidi";
            this.txtMontantMidi.Size = new System.Drawing.Size(291, 20);
            this.txtMontantMidi.TabIndex = 20;
            // 
            // txtQMidi
            // 
            this.txtQMidi.Location = new System.Drawing.Point(158, 64);
            this.txtQMidi.Name = "txtQMidi";
            this.txtQMidi.Size = new System.Drawing.Size(71, 20);
            this.txtQMidi.TabIndex = 19;
            // 
            // txtTotalNuit
            // 
            this.txtTotalNuit.Location = new System.Drawing.Point(539, 42);
            this.txtTotalNuit.Name = "txtTotalNuit";
            this.txtTotalNuit.Size = new System.Drawing.Size(101, 20);
            this.txtTotalNuit.TabIndex = 18;
            // 
            // lnlNuite
            // 
            this.lnlNuite.AutoSize = true;
            this.lnlNuite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlNuite.Location = new System.Drawing.Point(11, 39);
            this.lnlNuite.Name = "lnlNuite";
            this.lnlNuite.Size = new System.Drawing.Size(47, 16);
            this.lnlNuite.TabIndex = 10;
            this.lnlNuite.Text = "Nuitée";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblQuantite.Location = new System.Drawing.Point(158, 8);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(65, 16);
            this.lblQuantite.TabIndex = 11;
            this.lblQuantite.Text = "Quantité";
            // 
            // lblFrais
            // 
            this.lblFrais.AutoSize = true;
            this.lblFrais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrais.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFrais.Location = new System.Drawing.Point(11, 8);
            this.lblFrais.Name = "lblFrais";
            this.lblFrais.Size = new System.Drawing.Size(121, 16);
            this.lblFrais.TabIndex = 10;
            this.lblFrais.Text = "Frais forfaitaires";
            // 
            // lblMontatnt
            // 
            this.lblMontatnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontatnt.AutoSize = true;
            this.lblMontatnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontatnt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMontatnt.Location = new System.Drawing.Point(238, 8);
            this.lblMontatnt.Name = "lblMontatnt";
            this.lblMontatnt.Size = new System.Drawing.Size(292, 28);
            this.lblMontatnt.TabIndex = 12;
            this.lblMontatnt.Text = "Montant unitaire";
            this.lblMontatnt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotal.Location = new System.Drawing.Point(539, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // lblRepasMidi
            // 
            this.lblRepasMidi.AutoSize = true;
            this.lblRepasMidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepasMidi.Location = new System.Drawing.Point(11, 61);
            this.lblRepasMidi.Name = "lblRepasMidi";
            this.lblRepasMidi.Size = new System.Drawing.Size(77, 16);
            this.lblRepasMidi.TabIndex = 14;
            this.lblRepasMidi.Text = "Repas Midi";
            // 
            // lblKilometrage
            // 
            this.lblKilometrage.AutoSize = true;
            this.lblKilometrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometrage.Location = new System.Drawing.Point(11, 93);
            this.lblKilometrage.Name = "lblKilometrage";
            this.lblKilometrage.Size = new System.Drawing.Size(80, 16);
            this.lblKilometrage.TabIndex = 15;
            this.lblKilometrage.Text = "Kilometrage";
            // 
            // txtQNuit
            // 
            this.txtQNuit.Location = new System.Drawing.Point(158, 42);
            this.txtQNuit.Name = "txtQNuit";
            this.txtQNuit.Size = new System.Drawing.Size(71, 20);
            this.txtQNuit.TabIndex = 16;
            // 
            // txtMontantNuit
            // 
            this.txtMontantNuit.Location = new System.Drawing.Point(238, 42);
            this.txtMontantNuit.Name = "txtMontantNuit";
            this.txtMontantNuit.Size = new System.Drawing.Size(291, 20);
            this.txtMontantNuit.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 709);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Visiteur";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatricule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorsforfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHorsforfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsprenom)).EndInit();
            this.tblVisiteur.ResumeLayout(false);
            this.tblVisiteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtMois;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label lblmatricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMontantAutre;
        private System.Windows.Forms.Label lblDateAutre;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblAutre;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.BindingSource bsMatricule;
        private System.Windows.Forms.BindingSource bsNom;
        private System.Windows.Forms.BindingSource bsMois;
        private System.Windows.Forms.DataGridView dgvHorsforfait;
        private System.Windows.Forms.BindingSource bsHorsforfait;
        private System.Windows.Forms.BindingSource bsForfait;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.BindingSource bsprenom;
        private System.Windows.Forms.TableLayoutPanel tblVisiteur;
        private System.Windows.Forms.TextBox txtTotalVehicule;
        private System.Windows.Forms.TextBox txtMontantVehicule;
        private System.Windows.Forms.TextBox txtQVehicule;
        private System.Windows.Forms.TextBox txtTotalMidi;
        private System.Windows.Forms.TextBox txtMontantMidi;
        private System.Windows.Forms.TextBox txtQMidi;
        private System.Windows.Forms.TextBox txtTotalNuit;
        private System.Windows.Forms.Label lnlNuite;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblFrais;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRepasMidi;
        private System.Windows.Forms.Label lblKilometrage;
        private System.Windows.Forms.TextBox txtQNuit;
        private System.Windows.Forms.TextBox txtMontantNuit;
        private System.Windows.Forms.Label lblMontatnt;
    }
}