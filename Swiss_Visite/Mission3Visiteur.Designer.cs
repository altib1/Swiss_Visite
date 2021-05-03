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
            this.cbmois = new System.Windows.Forms.ComboBox();
            this.txtQuantiteKilometres = new System.Windows.Forms.NumericUpDown();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjoutertrans = new System.Windows.Forms.Button();
            this.lblModetrans = new System.Windows.Forms.Label();
            this.lblqkilometrique = new System.Windows.Forms.Label();
            this.cboModeDeTransport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvfraiskilometriques = new System.Windows.Forms.DataGridView();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeDeTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalKilometrique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblVisiteur = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.numSoir = new System.Windows.Forms.NumericUpDown();
            this.numMidi = new System.Windows.Forms.NumericUpDown();
            this.txtTotalRepasSoir = new System.Windows.Forms.TextBox();
            this.txtMontantSoir = new System.Windows.Forms.TextBox();
            this.txtTotalMidi = new System.Windows.Forms.TextBox();
            this.txtMontantMidi = new System.Windows.Forms.TextBox();
            this.txtTotalNuit = new System.Windows.Forms.TextBox();
            this.lnlNuite = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblFrais = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRepasMidi = new System.Windows.Forms.Label();
            this.lblRepasSoir = new System.Windows.Forms.Label();
            this.txtMontantNuit = new System.Windows.Forms.TextBox();
            this.lblMontatnt = new System.Windows.Forms.Label();
            this.txtMontantForfaitnuite = new System.Windows.Forms.TextBox();
            this.txttotalForfaitnuite = new System.Windows.Forms.TextBox();
            this.numNuite = new System.Windows.Forms.NumericUpDown();
            this.numForfaitnuite = new System.Windows.Forms.NumericUpDown();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblMois = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.lblmatricule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnValiderfichefrais = new System.Windows.Forms.Button();
            this.btnAnnulerfraistransport = new System.Windows.Forms.Button();
            this.btnfraishorsforfait = new System.Windows.Forms.Button();
            this.bsMatricule = new System.Windows.Forms.BindingSource(this.components);
            this.bsNom = new System.Windows.Forms.BindingSource(this.components);
            this.bsMois = new System.Windows.Forms.BindingSource(this.components);
            this.bsHorsforfait = new System.Windows.Forms.BindingSource(this.components);
            this.bsForfait = new System.Windows.Forms.BindingSource(this.components);
            this.bsprenom = new System.Windows.Forms.BindingSource(this.components);
            this.bsNuit = new System.Windows.Forms.BindingSource(this.components);
            this.bsMidi = new System.Windows.Forms.BindingSource(this.components);
            this.bsSoir = new System.Windows.Forms.BindingSource(this.components);
            this.bsModedetransport = new System.Windows.Forms.BindingSource(this.components);
            this.bsdgvtransport = new System.Windows.Forms.BindingSource(this.components);
            this.bsForfaitnuite = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantiteKilometres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfraiskilometriques)).BeginInit();
            this.tblVisiteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMidi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNuite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForfaitnuite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatricule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHorsforfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsprenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMidi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSoir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModedetransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdgvtransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForfaitnuite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbmois);
            this.panel1.Controls.Add(this.txtQuantiteKilometres);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnAjoutertrans);
            this.panel1.Controls.Add(this.lblModetrans);
            this.panel1.Controls.Add(this.lblqkilometrique);
            this.panel1.Controls.Add(this.cboModeDeTransport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvfraiskilometriques);
            this.panel1.Controls.Add(this.tblVisiteur);
            this.panel1.Controls.Add(this.txtPrenom);
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
            this.panel1.Size = new System.Drawing.Size(670, 597);
            this.panel1.TabIndex = 0;
            // 
            // cbmois
            // 
            this.cbmois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmois.FormattingEnabled = true;
            this.cbmois.Location = new System.Drawing.Point(80, 174);
            this.cbmois.Name = "cbmois";
            this.cbmois.Size = new System.Drawing.Size(121, 21);
            this.cbmois.TabIndex = 28;
            // 
            // txtQuantiteKilometres
            // 
            this.txtQuantiteKilometres.Location = new System.Drawing.Point(109, 425);
            this.txtQuantiteKilometres.Name = "txtQuantiteKilometres";
            this.txtQuantiteKilometres.ReadOnly = true;
            this.txtQuantiteKilometres.Size = new System.Drawing.Size(120, 20);
            this.txtQuantiteKilometres.TabIndex = 27;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(336, 460);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(99, 23);
            this.btnSupprimer.TabIndex = 26;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(164, 460);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(112, 23);
            this.btnModifier.TabIndex = 25;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // btnAjoutertrans
            // 
            this.btnAjoutertrans.Location = new System.Drawing.Point(471, 422);
            this.btnAjoutertrans.Name = "btnAjoutertrans";
            this.btnAjoutertrans.Size = new System.Drawing.Size(136, 23);
            this.btnAjoutertrans.TabIndex = 24;
            this.btnAjoutertrans.Text = "Ajouter";
            this.btnAjoutertrans.UseVisualStyleBackColor = true;
            this.btnAjoutertrans.Click += new System.EventHandler(this.BtnAjoutertrans_Click);
            // 
            // lblModetrans
            // 
            this.lblModetrans.AutoSize = true;
            this.lblModetrans.Location = new System.Drawing.Point(311, 408);
            this.lblModetrans.Name = "lblModetrans";
            this.lblModetrans.Size = new System.Drawing.Size(93, 13);
            this.lblModetrans.TabIndex = 22;
            this.lblModetrans.Text = "Mode de transport";
            // 
            // lblqkilometrique
            // 
            this.lblqkilometrique.AutoSize = true;
            this.lblqkilometrique.Location = new System.Drawing.Point(128, 409);
            this.lblqkilometrique.Name = "lblqkilometrique";
            this.lblqkilometrique.Size = new System.Drawing.Size(47, 13);
            this.lblqkilometrique.TabIndex = 21;
            this.lblqkilometrique.Text = "Quantite";
            // 
            // cboModeDeTransport
            // 
            this.cboModeDeTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModeDeTransport.FormattingEnabled = true;
            this.cboModeDeTransport.Location = new System.Drawing.Point(259, 424);
            this.cboModeDeTransport.Name = "cboModeDeTransport";
            this.cboModeDeTransport.Size = new System.Drawing.Size(187, 21);
            this.cboModeDeTransport.TabIndex = 19;
            this.cboModeDeTransport.SelectedIndexChanged += new System.EventHandler(this.CboModeDeTransport_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(294, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Frais Kilometriques";
            // 
            // dgvfraiskilometriques
            // 
            this.dgvfraiskilometriques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfraiskilometriques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantite,
            this.ModeDeTransport,
            this.TotalKilometrique});
            this.dgvfraiskilometriques.Location = new System.Drawing.Point(3, 489);
            this.dgvfraiskilometriques.MultiSelect = false;
            this.dgvfraiskilometriques.Name = "dgvfraiskilometriques";
            this.dgvfraiskilometriques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfraiskilometriques.Size = new System.Drawing.Size(665, 101);
            this.dgvfraiskilometriques.TabIndex = 16;
            this.dgvfraiskilometriques.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            this.dgvfraiskilometriques.SelectionChanged += new System.EventHandler(this.Dgvfraiskilometriques_SelectionChanged);
            // 
            // Quantite
            // 
            this.Quantite.DataPropertyName = "QuantiteKilometrique";
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            this.Quantite.Width = 200;
            // 
            // ModeDeTransport
            // 
            this.ModeDeTransport.HeaderText = "Mode De Transport";
            this.ModeDeTransport.Name = "ModeDeTransport";
            this.ModeDeTransport.Width = 200;
            // 
            // TotalKilometrique
            // 
            this.TotalKilometrique.HeaderText = "Total";
            this.TotalKilometrique.Name = "TotalKilometrique";
            this.TotalKilometrique.Width = 200;
            // 
            // tblVisiteur
            // 
            this.tblVisiteur.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tblVisiteur.ColumnCount = 4;
            this.tblVisiteur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.1282F));
            this.tblVisiteur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.8718F));
            this.tblVisiteur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tblVisiteur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tblVisiteur.Controls.Add(this.label3, 0, 4);
            this.tblVisiteur.Controls.Add(this.numSoir, 1, 3);
            this.tblVisiteur.Controls.Add(this.numMidi, 1, 2);
            this.tblVisiteur.Controls.Add(this.txtTotalRepasSoir, 3, 3);
            this.tblVisiteur.Controls.Add(this.txtMontantSoir, 2, 3);
            this.tblVisiteur.Controls.Add(this.txtTotalMidi, 3, 2);
            this.tblVisiteur.Controls.Add(this.txtMontantMidi, 2, 2);
            this.tblVisiteur.Controls.Add(this.txtTotalNuit, 3, 1);
            this.tblVisiteur.Controls.Add(this.lnlNuite, 0, 1);
            this.tblVisiteur.Controls.Add(this.lblQuantite, 1, 0);
            this.tblVisiteur.Controls.Add(this.lblFrais, 0, 0);
            this.tblVisiteur.Controls.Add(this.lblTotal, 3, 0);
            this.tblVisiteur.Controls.Add(this.lblRepasMidi, 0, 2);
            this.tblVisiteur.Controls.Add(this.lblRepasSoir, 0, 3);
            this.tblVisiteur.Controls.Add(this.txtMontantNuit, 2, 1);
            this.tblVisiteur.Controls.Add(this.lblMontatnt, 2, 0);
            this.tblVisiteur.Controls.Add(this.txtMontantForfaitnuite, 2, 4);
            this.tblVisiteur.Controls.Add(this.txttotalForfaitnuite, 3, 4);
            this.tblVisiteur.Controls.Add(this.numNuite, 1, 1);
            this.tblVisiteur.Controls.Add(this.numForfaitnuite, 1, 4);
            this.tblVisiteur.Location = new System.Drawing.Point(13, 224);
            this.tblVisiteur.Name = "tblVisiteur";
            this.tblVisiteur.Padding = new System.Windows.Forms.Padding(5);
            this.tblVisiteur.RowCount = 5;
            this.tblVisiteur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.42029F));
            this.tblVisiteur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.57971F));
            this.tblVisiteur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblVisiteur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblVisiteur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblVisiteur.Size = new System.Drawing.Size(655, 156);
            this.tblVisiteur.TabIndex = 15;
            this.tblVisiteur.Paint += new System.Windows.Forms.PaintEventHandler(this.TblVisiteur_Paint_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "forfait Nuite";
            // 
            // numSoir
            // 
            this.numSoir.Location = new System.Drawing.Point(103, 100);
            this.numSoir.Name = "numSoir";
            this.numSoir.ReadOnly = true;
            this.numSoir.Size = new System.Drawing.Size(42, 20);
            this.numSoir.TabIndex = 30;
            this.numSoir.ValueChanged += new System.EventHandler(this.NumSoir_ValueChanged);
            // 
            // numMidi
            // 
            this.numMidi.Location = new System.Drawing.Point(103, 68);
            this.numMidi.Name = "numMidi";
            this.numMidi.ReadOnly = true;
            this.numMidi.Size = new System.Drawing.Size(42, 20);
            this.numMidi.TabIndex = 29;
            this.numMidi.ValueChanged += new System.EventHandler(this.NumMidi_ValueChanged);
            // 
            // txtTotalRepasSoir
            // 
            this.txtTotalRepasSoir.Location = new System.Drawing.Point(455, 100);
            this.txtTotalRepasSoir.Name = "txtTotalRepasSoir";
            this.txtTotalRepasSoir.ReadOnly = true;
            this.txtTotalRepasSoir.Size = new System.Drawing.Size(101, 20);
            this.txtTotalRepasSoir.TabIndex = 24;
            // 
            // txtMontantSoir
            // 
            this.txtMontantSoir.Location = new System.Drawing.Point(154, 100);
            this.txtMontantSoir.Name = "txtMontantSoir";
            this.txtMontantSoir.ReadOnly = true;
            this.txtMontantSoir.Size = new System.Drawing.Size(291, 20);
            this.txtMontantSoir.TabIndex = 23;
            // 
            // txtTotalMidi
            // 
            this.txtTotalMidi.Location = new System.Drawing.Point(455, 68);
            this.txtTotalMidi.Name = "txtTotalMidi";
            this.txtTotalMidi.ReadOnly = true;
            this.txtTotalMidi.Size = new System.Drawing.Size(101, 20);
            this.txtTotalMidi.TabIndex = 21;
            // 
            // txtMontantMidi
            // 
            this.txtMontantMidi.Location = new System.Drawing.Point(154, 68);
            this.txtMontantMidi.Name = "txtMontantMidi";
            this.txtMontantMidi.ReadOnly = true;
            this.txtMontantMidi.Size = new System.Drawing.Size(291, 20);
            this.txtMontantMidi.TabIndex = 20;
            // 
            // txtTotalNuit
            // 
            this.txtTotalNuit.Location = new System.Drawing.Point(455, 44);
            this.txtTotalNuit.Name = "txtTotalNuit";
            this.txtTotalNuit.ReadOnly = true;
            this.txtTotalNuit.Size = new System.Drawing.Size(101, 20);
            this.txtTotalNuit.TabIndex = 18;
            // 
            // lnlNuite
            // 
            this.lnlNuite.AutoSize = true;
            this.lnlNuite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlNuite.Location = new System.Drawing.Point(11, 41);
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
            this.lblQuantite.Location = new System.Drawing.Point(103, 8);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(37, 30);
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
            this.lblFrais.Size = new System.Drawing.Size(82, 30);
            this.lblFrais.TabIndex = 10;
            this.lblFrais.Text = "Frais forfaitaires";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotal.Location = new System.Drawing.Point(455, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // lblRepasMidi
            // 
            this.lblRepasMidi.AutoSize = true;
            this.lblRepasMidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepasMidi.Location = new System.Drawing.Point(11, 65);
            this.lblRepasMidi.Name = "lblRepasMidi";
            this.lblRepasMidi.Size = new System.Drawing.Size(77, 16);
            this.lblRepasMidi.TabIndex = 14;
            this.lblRepasMidi.Text = "Repas Midi";
            // 
            // lblRepasSoir
            // 
            this.lblRepasSoir.AutoSize = true;
            this.lblRepasSoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepasSoir.Location = new System.Drawing.Point(11, 97);
            this.lblRepasSoir.Name = "lblRepasSoir";
            this.lblRepasSoir.Size = new System.Drawing.Size(76, 16);
            this.lblRepasSoir.TabIndex = 15;
            this.lblRepasSoir.Text = "Repas Soir";
            this.lblRepasSoir.Click += new System.EventHandler(this.LblKilometrage_Click);
            // 
            // txtMontantNuit
            // 
            this.txtMontantNuit.Location = new System.Drawing.Point(154, 44);
            this.txtMontantNuit.Name = "txtMontantNuit";
            this.txtMontantNuit.ReadOnly = true;
            this.txtMontantNuit.Size = new System.Drawing.Size(291, 20);
            this.txtMontantNuit.TabIndex = 17;
            // 
            // lblMontatnt
            // 
            this.lblMontatnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontatnt.AutoSize = true;
            this.lblMontatnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontatnt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMontatnt.Location = new System.Drawing.Point(154, 8);
            this.lblMontatnt.Name = "lblMontatnt";
            this.lblMontatnt.Size = new System.Drawing.Size(292, 30);
            this.lblMontatnt.TabIndex = 12;
            this.lblMontatnt.Text = "Montant unitaire";
            this.lblMontatnt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMontantForfaitnuite
            // 
            this.txtMontantForfaitnuite.Location = new System.Drawing.Point(154, 130);
            this.txtMontantForfaitnuite.Name = "txtMontantForfaitnuite";
            this.txtMontantForfaitnuite.ReadOnly = true;
            this.txtMontantForfaitnuite.Size = new System.Drawing.Size(292, 20);
            this.txtMontantForfaitnuite.TabIndex = 26;
            // 
            // txttotalForfaitnuite
            // 
            this.txttotalForfaitnuite.Location = new System.Drawing.Point(455, 130);
            this.txttotalForfaitnuite.Name = "txttotalForfaitnuite";
            this.txttotalForfaitnuite.ReadOnly = true;
            this.txttotalForfaitnuite.Size = new System.Drawing.Size(101, 20);
            this.txttotalForfaitnuite.TabIndex = 27;
            // 
            // numNuite
            // 
            this.numNuite.Location = new System.Drawing.Point(103, 44);
            this.numNuite.Name = "numNuite";
            this.numNuite.ReadOnly = true;
            this.numNuite.Size = new System.Drawing.Size(42, 20);
            this.numNuite.TabIndex = 28;
            this.numNuite.ValueChanged += new System.EventHandler(this.NumNuite_ValueChanged);
            // 
            // numForfaitnuite
            // 
            this.numForfaitnuite.Location = new System.Drawing.Point(103, 130);
            this.numForfaitnuite.Name = "numForfaitnuite";
            this.numForfaitnuite.ReadOnly = true;
            this.numForfaitnuite.Size = new System.Drawing.Size(42, 20);
            this.numForfaitnuite.TabIndex = 31;
            this.numForfaitnuite.ValueChanged += new System.EventHandler(this.NumForfaitnuite_ValueChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(352, 121);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 14;
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
            this.txtNom.ReadOnly = true;
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
            this.txtMatricule.ReadOnly = true;
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
            this.label1.Size = new System.Drawing.Size(61, 16);
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
            // btnValiderfichefrais
            // 
            this.btnValiderfichefrais.Location = new System.Drawing.Point(625, 668);
            this.btnValiderfichefrais.Name = "btnValiderfichefrais";
            this.btnValiderfichefrais.Size = new System.Drawing.Size(114, 32);
            this.btnValiderfichefrais.TabIndex = 1;
            this.btnValiderfichefrais.Text = "Valider";
            this.btnValiderfichefrais.UseVisualStyleBackColor = true;
            this.btnValiderfichefrais.Click += new System.EventHandler(this.BtnValiderfichefrais_Click);
            // 
            // btnAnnulerfraistransport
            // 
            this.btnAnnulerfraistransport.Location = new System.Drawing.Point(510, 668);
            this.btnAnnulerfraistransport.Name = "btnAnnulerfraistransport";
            this.btnAnnulerfraistransport.Size = new System.Drawing.Size(98, 32);
            this.btnAnnulerfraistransport.TabIndex = 2;
            this.btnAnnulerfraistransport.Text = "Annuler";
            this.btnAnnulerfraistransport.UseVisualStyleBackColor = true;
            this.btnAnnulerfraistransport.Click += new System.EventHandler(this.BtnAnnulerfraistransport_Click);
            // 
            // btnfraishorsforfait
            // 
            this.btnfraishorsforfait.Location = new System.Drawing.Point(69, 668);
            this.btnfraishorsforfait.Name = "btnfraishorsforfait";
            this.btnfraishorsforfait.Size = new System.Drawing.Size(155, 49);
            this.btnfraishorsforfait.TabIndex = 4;
            this.btnfraishorsforfait.Text = "Ajouter des frais hors forfait";
            this.btnfraishorsforfait.UseVisualStyleBackColor = true;
            this.btnfraishorsforfait.Click += new System.EventHandler(this.Btnfraishorsforfait_Click);
            // 
            // bsMois
            // 
            this.bsMois.CurrentChanged += new System.EventHandler(this.BindingSource1_CurrentChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 747);
            this.Controls.Add(this.btnfraishorsforfait);
            this.Controls.Add(this.btnAnnulerfraistransport);
            this.Controls.Add(this.btnValiderfichefrais);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Fiche de remboursement";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantiteKilometres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfraiskilometriques)).EndInit();
            this.tblVisiteur.ResumeLayout(false);
            this.tblVisiteur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMidi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNuite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForfaitnuite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatricule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHorsforfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsprenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMidi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSoir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModedetransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsdgvtransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForfaitnuite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label lblmatricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.BindingSource bsMatricule;
        private System.Windows.Forms.BindingSource bsNom;
        private System.Windows.Forms.BindingSource bsMois;
        private System.Windows.Forms.BindingSource bsHorsforfait;
        private System.Windows.Forms.BindingSource bsForfait;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.BindingSource bsprenom;
        private System.Windows.Forms.TableLayoutPanel tblVisiteur;
        private System.Windows.Forms.TextBox txtTotalRepasSoir;
        private System.Windows.Forms.TextBox txtMontantSoir;
        private System.Windows.Forms.TextBox txtTotalMidi;
        private System.Windows.Forms.TextBox txtMontantMidi;
        private System.Windows.Forms.TextBox txtTotalNuit;
        private System.Windows.Forms.Label lnlNuite;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblFrais;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRepasMidi;
        private System.Windows.Forms.Label lblRepasSoir;
        private System.Windows.Forms.TextBox txtMontantNuit;
        private System.Windows.Forms.Label lblMontatnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsNuit;
        private System.Windows.Forms.BindingSource bsMidi;
        private System.Windows.Forms.BindingSource bsSoir;
        private System.Windows.Forms.ComboBox cboModeDeTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeDeTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalKilometrique;
        private System.Windows.Forms.BindingSource bsModedetransport;
        public System.Windows.Forms.DataGridView dgvfraiskilometriques;
        private System.Windows.Forms.Button btnAjoutertrans;
        private System.Windows.Forms.Label lblModetrans;
        private System.Windows.Forms.Label lblqkilometrique;
        private System.Windows.Forms.Button btnValiderfichefrais;
        private System.Windows.Forms.Button btnAnnulerfraistransport;
        private System.Windows.Forms.BindingSource bsdgvtransport;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.NumericUpDown txtQuantiteKilometres;
        private System.Windows.Forms.TextBox txtMontantForfaitnuite;
        private System.Windows.Forms.TextBox txttotalForfaitnuite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSoir;
        private System.Windows.Forms.NumericUpDown numMidi;
        private System.Windows.Forms.NumericUpDown numNuite;
        private System.Windows.Forms.NumericUpDown numForfaitnuite;
        private System.Windows.Forms.BindingSource bsForfaitnuite;
        private System.Windows.Forms.ComboBox cbmois;
        private System.Windows.Forms.Button btnfraishorsforfait;
    }
}