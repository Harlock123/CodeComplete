﻿namespace TAICodeComplete
{
    partial class frmMain
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
            this.cmboServers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboDatabases = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboTables = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEnumerateLocalSQLServers = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtManualConnectionString = new System.Windows.Forms.TextBox();
            this.btnSSPI = new System.Windows.Forms.Button();
            this.lblOneMoment = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.txtUSER = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkGenReadAsDataSet = new System.Windows.Forms.CheckBox();
            this.chkGenUpdate = new System.Windows.Forms.CheckBox();
            this.chkGenRead = new System.Windows.Forms.CheckBox();
            this.chkGenDelete = new System.Windows.Forms.CheckBox();
            this.chkGenFastAdd = new System.Windows.Forms.CheckBox();
            this.chkGenAdd = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCMDTimeout = new System.Windows.Forms.TextBox();
            this.txtDerivedConnectionString = new System.Windows.Forms.TextBox();
            this.btnShowConnectionString = new System.Windows.Forms.Button();
            this.chkGenerateInsertStatements = new System.Windows.Forms.CheckBox();
            this.chkDOJAVASCRIPTUI = new System.Windows.Forms.CheckBox();
            this.chkXAMLFromOrUserControl = new System.Windows.Forms.CheckBox();
            this.chkPostProcessWSresultlist = new System.Windows.Forms.CheckBox();
            this.chkINotifyCrap = new System.Windows.Forms.CheckBox();
            this.chkGenerateDeacivateOn = new System.Windows.Forms.CheckBox();
            this.chkGenerateWebMethods = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInterfaceOBJPrefix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManualServerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRegenerateBaseClass = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.sciBaseTableCode = new ScintillaNET.Scintilla();
            this.btnSaveBaseCodeTableToFile = new System.Windows.Forms.Button();
            this.chkBaseTableCodeFolding = new System.Windows.Forms.CheckBox();
            this.chkBaseTableLineNumbers = new System.Windows.Forms.CheckBox();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.sciBaseTableTSCode = new ScintillaNET.Scintilla();
            this.btnSaveTSCode = new System.Windows.Forms.Button();
            this.chkBaseTableTSCodeFolding = new System.Windows.Forms.CheckBox();
            this.chkBaseTableTSLineNumbers = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.scintillaWebMethodCode = new ScintillaNET.Scintilla();
            this.btnSaveWebMethodsToFile = new System.Windows.Forms.Button();
            this.chkWebMethodCodeFolding = new System.Windows.Forms.CheckBox();
            this.chkWebMethodLineNumbers = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.scintillaWEBAPICode = new ScintillaNET.Scintilla();
            this.btnSaveWEBAPI = new System.Windows.Forms.Button();
            this.chkCodeFoldWEBAPI = new System.Windows.Forms.CheckBox();
            this.chkLineNumsWEBAPI = new System.Windows.Forms.CheckBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.scintillaJSCode = new ScintillaNET.Scintilla();
            this.btnSaveJSToFile = new System.Windows.Forms.Button();
            this.chkJSCodeFolding = new System.Windows.Forms.CheckBox();
            this.chkJSLineNumbers = new System.Windows.Forms.CheckBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.scintillaRestCode = new ScintillaNET.Scintilla();
            this.btnRestSaveToFile = new System.Windows.Forms.Button();
            this.chkRestCodeFolding = new System.Windows.Forms.CheckBox();
            this.chkRestLineNumbers = new System.Windows.Forms.CheckBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.btnFiddleIt = new System.Windows.Forms.Button();
            this.scintillaHTMLCode = new ScintillaNET.Scintilla();
            this.btnSaveHTML = new System.Windows.Forms.Button();
            this.chkHTMLCodeFolding = new System.Windows.Forms.CheckBox();
            this.chkHTMLLineNumbers = new System.Windows.Forms.CheckBox();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.scintillaCSSCode = new ScintillaNET.Scintilla();
            this.btnsaveCSS = new System.Windows.Forms.Button();
            this.chkCSSCodeFolding = new System.Windows.Forms.CheckBox();
            this.chkCSSLineNumbers = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.scintillaXAML = new ScintillaNET.Scintilla();
            this.btnSaveXaml = new System.Windows.Forms.Button();
            this.chkXAMLCodeFoldingXaml = new System.Windows.Forms.CheckBox();
            this.chkLineNumbersXAML = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnShowTestForm = new System.Windows.Forms.Button();
            this.scintillaWFCode = new ScintillaNET.Scintilla();
            this.btnWFSaveToFile = new System.Windows.Forms.Button();
            this.chkWFCodeFolding = new System.Windows.Forms.CheckBox();
            this.chkWFLineNumbers = new System.Windows.Forms.CheckBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.sciSQLCode = new ScintillaNET.Scintilla();
            this.btnSaveSQLToFile = new System.Windows.Forms.Button();
            this.chkSQLCodeFolding = new System.Windows.Forms.CheckBox();
            this.chkSQLLineNumber = new System.Windows.Forms.CheckBox();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.chkPad = new System.Windows.Forms.CheckBox();
            this.btnStringify = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtStringIfy = new System.Windows.Forms.TextBox();
            this.sciStringify = new ScintillaNET.Scintilla();
            this.chkStringifyCodeFolding = new System.Windows.Forms.CheckBox();
            this.chkStringifyLineNumbers = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnSQLPRETTY = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCRAPPYSQLCODE = new System.Windows.Forms.TextBox();
            this.SQLCODEPRETTY = new ScintillaNET.Scintilla();
            this.chkSQLCODEPRETTYFOLDING = new System.Windows.Forms.CheckBox();
            this.chkSQLCODEPRETTYLINENUMBERS = new System.Windows.Forms.CheckBox();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.btnDoBase64Encode = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.SCINTILLABASE64 = new ScintillaNET.Scintilla();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.btnMakeDispatchCase = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObjectTypeAndName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnProcessMethodNames = new System.Windows.Forms.Button();
            this.txtMethodNames = new System.Windows.Forms.TextBox();
            this.scintillaMMakerCode = new ScintillaNET.Scintilla();
            this.cbMMakerCodeFold = new System.Windows.Forms.CheckBox();
            this.cbMMakerLineNumbers = new System.Windows.Forms.CheckBox();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.lblworking = new System.Windows.Forms.Label();
            this.btnMakeBaseJava = new System.Windows.Forms.Button();
            this.txtLMSTUDIOAddress = new System.Windows.Forms.TextBox();
            this.btnConnectLMStudio = new System.Windows.Forms.Button();
            this.sciAICode = new ScintillaNET.Scintilla();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.backgroundworkerThread = new System.ComponentModel.BackgroundWorker();
            this.chkCodeFoldingAI = new System.Windows.Forms.CheckBox();
            this.chkLineNumbersAI = new System.Windows.Forms.CheckBox();
            this.btnMakeBasePython = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmboServers
            // 
            this.cmboServers.FormattingEnabled = true;
            this.cmboServers.Location = new System.Drawing.Point(6, 52);
            this.cmboServers.Name = "cmboServers";
            this.cmboServers.Size = new System.Drawing.Size(167, 21);
            this.cmboServers.TabIndex = 0;
            this.cmboServers.SelectedIndexChanged += new System.EventHandler(this.HandleServerSelection);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servers Visible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Databases Within Selected Server";
            // 
            // cmboDatabases
            // 
            this.cmboDatabases.FormattingEnabled = true;
            this.cmboDatabases.Location = new System.Drawing.Point(6, 92);
            this.cmboDatabases.Name = "cmboDatabases";
            this.cmboDatabases.Size = new System.Drawing.Size(197, 21);
            this.cmboDatabases.TabIndex = 2;
            this.cmboDatabases.SelectedIndexChanged += new System.EventHandler(this.HandleDatabaseSelection);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tables in the selected database";
            // 
            // cmboTables
            // 
            this.cmboTables.FormattingEnabled = true;
            this.cmboTables.Location = new System.Drawing.Point(6, 132);
            this.cmboTables.Name = "cmboTables";
            this.cmboTables.Size = new System.Drawing.Size(197, 21);
            this.cmboTables.TabIndex = 4;
            this.cmboTables.SelectedIndexChanged += new System.EventHandler(this.HandleTableSelection);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage13);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage12);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage14);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage15);
            this.tabControl1.Controls.Add(this.tabPage16);
            this.tabControl1.Controls.Add(this.tabPage17);
            this.tabControl1.Location = new System.Drawing.Point(2, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1126, 545);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.btnEnumerateLocalSQLServers);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.txtManualConnectionString);
            this.tabPage1.Controls.Add(this.btnSSPI);
            this.tabPage1.Controls.Add(this.lblOneMoment);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtPASSWORD);
            this.tabPage1.Controls.Add(this.txtUSER);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtManualServerName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dgrid);
            this.tabPage1.Controls.Add(this.cmboServers);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmboTables);
            this.tabPage1.Controls.Add(this.cmboDatabases);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1118, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection Parameters";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(229, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "SSPI to use windows logon";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(230, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "to use credentials below or Click";
            // 
            // btnEnumerateLocalSQLServers
            // 
            this.btnEnumerateLocalSQLServers.Image = global::TAICodeComplete.Properties.Resources.Binoculors;
            this.btnEnumerateLocalSQLServers.Location = new System.Drawing.Point(176, 49);
            this.btnEnumerateLocalSQLServers.Name = "btnEnumerateLocalSQLServers";
            this.btnEnumerateLocalSQLServers.Size = new System.Drawing.Size(28, 26);
            this.btnEnumerateLocalSQLServers.TabIndex = 20;
            this.btnEnumerateLocalSQLServers.UseVisualStyleBackColor = true;
            this.btnEnumerateLocalSQLServers.Click += new System.EventHandler(this.btnEnumerateLocalSQLServers_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(392, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Type in  or Paste a manual connection string here if thats available pressing ent" +
    "er ";
            // 
            // txtManualConnectionString
            // 
            this.txtManualConnectionString.Location = new System.Drawing.Point(7, 6);
            this.txtManualConnectionString.Name = "txtManualConnectionString";
            this.txtManualConnectionString.Size = new System.Drawing.Size(432, 20);
            this.txtManualConnectionString.TabIndex = 18;
            this.txtManualConnectionString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleManualConnectionStringKeyDown);
            // 
            // btnSSPI
            // 
            this.btnSSPI.Location = new System.Drawing.Point(390, 73);
            this.btnSSPI.Margin = new System.Windows.Forms.Padding(2);
            this.btnSSPI.Name = "btnSSPI";
            this.btnSSPI.Size = new System.Drawing.Size(48, 22);
            this.btnSSPI.TabIndex = 17;
            this.btnSSPI.Text = "SSPI";
            this.btnSSPI.UseVisualStyleBackColor = true;
            this.btnSSPI.Click += new System.EventHandler(this.btnSSPI_Click);
            // 
            // lblOneMoment
            // 
            this.lblOneMoment.AutoSize = true;
            this.lblOneMoment.BackColor = System.Drawing.Color.White;
            this.lblOneMoment.Location = new System.Drawing.Point(6, 55);
            this.lblOneMoment.Name = "lblOneMoment";
            this.lblOneMoment.Size = new System.Drawing.Size(169, 13);
            this.lblOneMoment.TabIndex = 16;
            this.lblOneMoment.Text = "One Moment Enumerating Servers";
            this.lblOneMoment.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "when using a manual server connection";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Attempt to use this Login ID and Password";
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Location = new System.Drawing.Point(306, 116);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.PasswordChar = '*';
            this.txtPASSWORD.Size = new System.Drawing.Size(132, 20);
            this.txtPASSWORD.TabIndex = 13;
            // 
            // txtUSER
            // 
            this.txtUSER.Location = new System.Drawing.Point(232, 116);
            this.txtUSER.Name = "txtUSER";
            this.txtUSER.Size = new System.Drawing.Size(70, 20);
            this.txtUSER.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.chkGenReadAsDataSet);
            this.panel1.Controls.Add(this.chkGenUpdate);
            this.panel1.Controls.Add(this.chkGenRead);
            this.panel1.Controls.Add(this.chkGenDelete);
            this.panel1.Controls.Add(this.chkGenFastAdd);
            this.panel1.Controls.Add(this.chkGenAdd);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtCMDTimeout);
            this.panel1.Controls.Add(this.txtDerivedConnectionString);
            this.panel1.Controls.Add(this.btnShowConnectionString);
            this.panel1.Controls.Add(this.chkGenerateInsertStatements);
            this.panel1.Controls.Add(this.chkDOJAVASCRIPTUI);
            this.panel1.Controls.Add(this.chkXAMLFromOrUserControl);
            this.panel1.Controls.Add(this.chkPostProcessWSresultlist);
            this.panel1.Controls.Add(this.chkINotifyCrap);
            this.panel1.Controls.Add(this.chkGenerateDeacivateOn);
            this.panel1.Controls.Add(this.chkGenerateWebMethods);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtInterfaceOBJPrefix);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(445, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 165);
            this.panel1.TabIndex = 11;
            // 
            // chkGenReadAsDataSet
            // 
            this.chkGenReadAsDataSet.AutoSize = true;
            this.chkGenReadAsDataSet.Checked = true;
            this.chkGenReadAsDataSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenReadAsDataSet.Location = new System.Drawing.Point(360, 103);
            this.chkGenReadAsDataSet.Name = "chkGenReadAsDataSet";
            this.chkGenReadAsDataSet.Size = new System.Drawing.Size(188, 17);
            this.chkGenReadAsDataSet.TabIndex = 28;
            this.chkGenReadAsDataSet.Text = "Generate ReadasDataSet Method";
            this.chkGenReadAsDataSet.UseVisualStyleBackColor = true;
            // 
            // chkGenUpdate
            // 
            this.chkGenUpdate.AutoSize = true;
            this.chkGenUpdate.Checked = true;
            this.chkGenUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenUpdate.Location = new System.Drawing.Point(360, 118);
            this.chkGenUpdate.Name = "chkGenUpdate";
            this.chkGenUpdate.Size = new System.Drawing.Size(147, 17);
            this.chkGenUpdate.TabIndex = 27;
            this.chkGenUpdate.Text = "Generate Update Method";
            this.chkGenUpdate.UseVisualStyleBackColor = true;
            // 
            // chkGenRead
            // 
            this.chkGenRead.AutoSize = true;
            this.chkGenRead.Checked = true;
            this.chkGenRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenRead.Location = new System.Drawing.Point(360, 88);
            this.chkGenRead.Name = "chkGenRead";
            this.chkGenRead.Size = new System.Drawing.Size(138, 17);
            this.chkGenRead.TabIndex = 26;
            this.chkGenRead.Text = "Generate Read Method";
            this.chkGenRead.UseVisualStyleBackColor = true;
            // 
            // chkGenDelete
            // 
            this.chkGenDelete.AutoSize = true;
            this.chkGenDelete.Checked = true;
            this.chkGenDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenDelete.Location = new System.Drawing.Point(360, 73);
            this.chkGenDelete.Name = "chkGenDelete";
            this.chkGenDelete.Size = new System.Drawing.Size(143, 17);
            this.chkGenDelete.TabIndex = 25;
            this.chkGenDelete.Text = "Generate Delete Method";
            this.chkGenDelete.UseVisualStyleBackColor = true;
            // 
            // chkGenFastAdd
            // 
            this.chkGenFastAdd.AutoSize = true;
            this.chkGenFastAdd.Checked = true;
            this.chkGenFastAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenFastAdd.Location = new System.Drawing.Point(360, 57);
            this.chkGenFastAdd.Name = "chkGenFastAdd";
            this.chkGenFastAdd.Size = new System.Drawing.Size(151, 17);
            this.chkGenFastAdd.TabIndex = 24;
            this.chkGenFastAdd.Text = "Generate FastAdd Method";
            this.chkGenFastAdd.UseVisualStyleBackColor = true;
            // 
            // chkGenAdd
            // 
            this.chkGenAdd.AutoSize = true;
            this.chkGenAdd.Checked = true;
            this.chkGenAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenAdd.Location = new System.Drawing.Point(360, 42);
            this.chkGenAdd.Name = "chkGenAdd";
            this.chkGenAdd.Size = new System.Drawing.Size(131, 17);
            this.chkGenAdd.TabIndex = 23;
            this.chkGenAdd.Text = "Generate Add Method";
            this.chkGenAdd.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(308, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Default Command Timeout ";
            // 
            // txtCMDTimeout
            // 
            this.txtCMDTimeout.Location = new System.Drawing.Point(311, 6);
            this.txtCMDTimeout.Name = "txtCMDTimeout";
            this.txtCMDTimeout.Size = new System.Drawing.Size(57, 20);
            this.txtCMDTimeout.TabIndex = 21;
            this.txtCMDTimeout.Text = "300";
            // 
            // txtDerivedConnectionString
            // 
            this.txtDerivedConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDerivedConnectionString.Location = new System.Drawing.Point(6, 137);
            this.txtDerivedConnectionString.Name = "txtDerivedConnectionString";
            this.txtDerivedConnectionString.Size = new System.Drawing.Size(657, 20);
            this.txtDerivedConnectionString.TabIndex = 20;
            // 
            // btnShowConnectionString
            // 
            this.btnShowConnectionString.Location = new System.Drawing.Point(6, 111);
            this.btnShowConnectionString.Name = "btnShowConnectionString";
            this.btnShowConnectionString.Size = new System.Drawing.Size(180, 23);
            this.btnShowConnectionString.TabIndex = 19;
            this.btnShowConnectionString.Text = "Show Derived Connection String";
            this.btnShowConnectionString.UseVisualStyleBackColor = true;
            this.btnShowConnectionString.Click += new System.EventHandler(this.btnShowConnectionString_Click);
            // 
            // chkGenerateInsertStatements
            // 
            this.chkGenerateInsertStatements.AutoSize = true;
            this.chkGenerateInsertStatements.Location = new System.Drawing.Point(166, 91);
            this.chkGenerateInsertStatements.Name = "chkGenerateInsertStatements";
            this.chkGenerateInsertStatements.Size = new System.Drawing.Size(155, 17);
            this.chkGenerateInsertStatements.TabIndex = 18;
            this.chkGenerateInsertStatements.Text = "Generate Insert Statements";
            this.chkGenerateInsertStatements.UseVisualStyleBackColor = true;
            // 
            // chkDOJAVASCRIPTUI
            // 
            this.chkDOJAVASCRIPTUI.AutoSize = true;
            this.chkDOJAVASCRIPTUI.Checked = true;
            this.chkDOJAVASCRIPTUI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDOJAVASCRIPTUI.Location = new System.Drawing.Point(502, 6);
            this.chkDOJAVASCRIPTUI.Name = "chkDOJAVASCRIPTUI";
            this.chkDOJAVASCRIPTUI.Size = new System.Drawing.Size(161, 17);
            this.chkDOJAVASCRIPTUI.TabIndex = 17;
            this.chkDOJAVASCRIPTUI.Text = "Use JQ UI controls w/HTML";
            this.chkDOJAVASCRIPTUI.UseVisualStyleBackColor = true;
            // 
            // chkXAMLFromOrUserControl
            // 
            this.chkXAMLFromOrUserControl.AutoSize = true;
            this.chkXAMLFromOrUserControl.Checked = true;
            this.chkXAMLFromOrUserControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkXAMLFromOrUserControl.Location = new System.Drawing.Point(6, 91);
            this.chkXAMLFromOrUserControl.Name = "chkXAMLFromOrUserControl";
            this.chkXAMLFromOrUserControl.Size = new System.Drawing.Size(154, 17);
            this.chkXAMLFromOrUserControl.TabIndex = 16;
            this.chkXAMLFromOrUserControl.Text = "GenerateXAMLUserControl";
            this.chkXAMLFromOrUserControl.UseVisualStyleBackColor = true;
            // 
            // chkPostProcessWSresultlist
            // 
            this.chkPostProcessWSresultlist.AutoSize = true;
            this.chkPostProcessWSresultlist.Checked = true;
            this.chkPostProcessWSresultlist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPostProcessWSresultlist.Location = new System.Drawing.Point(85, 68);
            this.chkPostProcessWSresultlist.Name = "chkPostProcessWSresultlist";
            this.chkPostProcessWSresultlist.Size = new System.Drawing.Size(268, 17);
            this.chkPostProcessWSresultlist.TabIndex = 15;
            this.chkPostProcessWSresultlist.Text = "Generate PostProcess Method On Web Service list";
            this.chkPostProcessWSresultlist.UseVisualStyleBackColor = true;
            // 
            // chkINotifyCrap
            // 
            this.chkINotifyCrap.AutoSize = true;
            this.chkINotifyCrap.Location = new System.Drawing.Point(6, 68);
            this.chkINotifyCrap.Name = "chkINotifyCrap";
            this.chkINotifyCrap.Size = new System.Drawing.Size(73, 17);
            this.chkINotifyCrap.TabIndex = 14;
            this.chkINotifyCrap.Text = "Do INotify";
            this.chkINotifyCrap.UseVisualStyleBackColor = true;
            // 
            // chkGenerateDeacivateOn
            // 
            this.chkGenerateDeacivateOn.AutoSize = true;
            this.chkGenerateDeacivateOn.Location = new System.Drawing.Point(22, 44);
            this.chkGenerateDeacivateOn.Name = "chkGenerateDeacivateOn";
            this.chkGenerateDeacivateOn.Size = new System.Drawing.Size(164, 17);
            this.chkGenerateDeacivateOn.TabIndex = 13;
            this.chkGenerateDeacivateOn.Text = "Generate Deactivate OnField";
            this.chkGenerateDeacivateOn.UseVisualStyleBackColor = true;
            // 
            // chkGenerateWebMethods
            // 
            this.chkGenerateWebMethods.AutoSize = true;
            this.chkGenerateWebMethods.Checked = true;
            this.chkGenerateWebMethods.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenerateWebMethods.Location = new System.Drawing.Point(6, 24);
            this.chkGenerateWebMethods.Name = "chkGenerateWebMethods";
            this.chkGenerateWebMethods.Size = new System.Drawing.Size(140, 17);
            this.chkGenerateWebMethods.TabIndex = 12;
            this.chkGenerateWebMethods.Text = "Generate Web Methods";
            this.chkGenerateWebMethods.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Interface Objects Prefix";
            // 
            // txtInterfaceOBJPrefix
            // 
            this.txtInterfaceOBJPrefix.Location = new System.Drawing.Point(182, 6);
            this.txtInterfaceOBJPrefix.Name = "txtInterfaceOBJPrefix";
            this.txtInterfaceOBJPrefix.Size = new System.Drawing.Size(118, 20);
            this.txtInterfaceOBJPrefix.TabIndex = 10;
            this.txtInterfaceOBJPrefix.Text = "obj";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Code Generation Options";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "or";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type server name and hit enter ";
            // 
            // txtManualServerName
            // 
            this.txtManualServerName.Location = new System.Drawing.Point(231, 52);
            this.txtManualServerName.Name = "txtManualServerName";
            this.txtManualServerName.Size = new System.Drawing.Size(207, 20);
            this.txtManualServerName.TabIndex = 8;
            this.txtManualServerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandletxtManualServerNameKeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Field information for selected table";
            // 
            // dgrid
            // 
            this.dgrid.AllowUserToAddRows = false;
            this.dgrid.AllowUserToDeleteRows = false;
            this.dgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Location = new System.Drawing.Point(7, 177);
            this.dgrid.Name = "dgrid";
            this.dgrid.ReadOnly = true;
            this.dgrid.RowHeadersWidth = 82;
            this.dgrid.Size = new System.Drawing.Size(1105, 320);
            this.dgrid.TabIndex = 6;
            this.dgrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage2.Controls.Add(this.btnRegenerateBaseClass);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtClassName);
            this.tabPage2.Controls.Add(this.sciBaseTableCode);
            this.tabPage2.Controls.Add(this.btnSaveBaseCodeTableToFile);
            this.tabPage2.Controls.Add(this.chkBaseTableCodeFolding);
            this.tabPage2.Controls.Add(this.chkBaseTableLineNumbers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Base Code c#";
            // 
            // btnRegenerateBaseClass
            // 
            this.btnRegenerateBaseClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegenerateBaseClass.Location = new System.Drawing.Point(767, 6);
            this.btnRegenerateBaseClass.Name = "btnRegenerateBaseClass";
            this.btnRegenerateBaseClass.Size = new System.Drawing.Size(121, 23);
            this.btnRegenerateBaseClass.TabIndex = 7;
            this.btnRegenerateBaseClass.Text = "Regenerate Class";
            this.btnRegenerateBaseClass.UseVisualStyleBackColor = true;
            this.btnRegenerateBaseClass.Click += new System.EventHandler(this.btnRegenerateBaseClass_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "The Class Will Be Named";
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassName.Location = new System.Drawing.Point(604, 6);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(156, 20);
            this.txtClassName.TabIndex = 5;
            // 
            // sciBaseTableCode
            // 
            this.sciBaseTableCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sciBaseTableCode.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.sciBaseTableCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sciBaseTableCode.Lexer = ScintillaNET.Lexer.Cpp;
            this.sciBaseTableCode.Location = new System.Drawing.Point(10, 32);
            this.sciBaseTableCode.Name = "sciBaseTableCode";
            this.sciBaseTableCode.Size = new System.Drawing.Size(1102, 473);
            this.sciBaseTableCode.TabIndex = 4;
            // 
            // btnSaveBaseCodeTableToFile
            // 
            this.btnSaveBaseCodeTableToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveBaseCodeTableToFile.Location = new System.Drawing.Point(1037, 5);
            this.btnSaveBaseCodeTableToFile.Name = "btnSaveBaseCodeTableToFile";
            this.btnSaveBaseCodeTableToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBaseCodeTableToFile.TabIndex = 3;
            this.btnSaveBaseCodeTableToFile.Text = "Save To File";
            this.btnSaveBaseCodeTableToFile.UseVisualStyleBackColor = true;
            this.btnSaveBaseCodeTableToFile.Click += new System.EventHandler(this.btnSaveBaseCodeTableToFile_Click);
            // 
            // chkBaseTableCodeFolding
            // 
            this.chkBaseTableCodeFolding.AutoSize = true;
            this.chkBaseTableCodeFolding.Location = new System.Drawing.Point(103, 6);
            this.chkBaseTableCodeFolding.Name = "chkBaseTableCodeFolding";
            this.chkBaseTableCodeFolding.Size = new System.Drawing.Size(118, 17);
            this.chkBaseTableCodeFolding.TabIndex = 2;
            this.chkBaseTableCodeFolding.Text = "Show Code Folding";
            this.chkBaseTableCodeFolding.UseVisualStyleBackColor = true;
            this.chkBaseTableCodeFolding.CheckedChanged += new System.EventHandler(this.HandleBaseTableCodeFoldingChanged);
            // 
            // chkBaseTableLineNumbers
            // 
            this.chkBaseTableLineNumbers.AutoSize = true;
            this.chkBaseTableLineNumbers.Location = new System.Drawing.Point(6, 6);
            this.chkBaseTableLineNumbers.Name = "chkBaseTableLineNumbers";
            this.chkBaseTableLineNumbers.Size = new System.Drawing.Size(91, 17);
            this.chkBaseTableLineNumbers.TabIndex = 1;
            this.chkBaseTableLineNumbers.Text = "Line Numbers";
            this.chkBaseTableLineNumbers.UseVisualStyleBackColor = true;
            this.chkBaseTableLineNumbers.CheckedChanged += new System.EventHandler(this.HandleBaseTableLineNumberChanged);
            // 
            // tabPage13
            // 
            this.tabPage13.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage13.Controls.Add(this.sciBaseTableTSCode);
            this.tabPage13.Controls.Add(this.btnSaveTSCode);
            this.tabPage13.Controls.Add(this.chkBaseTableTSCodeFolding);
            this.tabPage13.Controls.Add(this.chkBaseTableTSLineNumbers);
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(1118, 519);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "Base Code ts";
            // 
            // sciBaseTableTSCode
            // 
            this.sciBaseTableTSCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sciBaseTableTSCode.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sciBaseTableTSCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sciBaseTableTSCode.Location = new System.Drawing.Point(7, 30);
            this.sciBaseTableTSCode.Name = "sciBaseTableTSCode";
            this.sciBaseTableTSCode.Size = new System.Drawing.Size(1106, 478);
            this.sciBaseTableTSCode.TabIndex = 8;
            // 
            // btnSaveTSCode
            // 
            this.btnSaveTSCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTSCode.Location = new System.Drawing.Point(1038, 3);
            this.btnSaveTSCode.Name = "btnSaveTSCode";
            this.btnSaveTSCode.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTSCode.TabIndex = 7;
            this.btnSaveTSCode.Text = "Save To File";
            this.btnSaveTSCode.UseVisualStyleBackColor = true;
            this.btnSaveTSCode.Click += new System.EventHandler(this.btnSaveTSCode_Click);
            // 
            // chkBaseTableTSCodeFolding
            // 
            this.chkBaseTableTSCodeFolding.AutoSize = true;
            this.chkBaseTableTSCodeFolding.Location = new System.Drawing.Point(104, 7);
            this.chkBaseTableTSCodeFolding.Name = "chkBaseTableTSCodeFolding";
            this.chkBaseTableTSCodeFolding.Size = new System.Drawing.Size(118, 17);
            this.chkBaseTableTSCodeFolding.TabIndex = 6;
            this.chkBaseTableTSCodeFolding.Text = "Show Code Folding";
            this.chkBaseTableTSCodeFolding.UseVisualStyleBackColor = true;
            this.chkBaseTableTSCodeFolding.CheckedChanged += new System.EventHandler(this.chkBaseTableTSCodeFolding_CheckedChanged);
            // 
            // chkBaseTableTSLineNumbers
            // 
            this.chkBaseTableTSLineNumbers.AutoSize = true;
            this.chkBaseTableTSLineNumbers.Location = new System.Drawing.Point(7, 7);
            this.chkBaseTableTSLineNumbers.Name = "chkBaseTableTSLineNumbers";
            this.chkBaseTableTSLineNumbers.Size = new System.Drawing.Size(91, 17);
            this.chkBaseTableTSLineNumbers.TabIndex = 5;
            this.chkBaseTableTSLineNumbers.Text = "Line Numbers";
            this.chkBaseTableTSLineNumbers.UseVisualStyleBackColor = true;
            this.chkBaseTableTSLineNumbers.CheckedChanged += new System.EventHandler(this.chkBaseTableTSLineNumbers_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage3.Controls.Add(this.scintillaWebMethodCode);
            this.tabPage3.Controls.Add(this.btnSaveWebMethodsToFile);
            this.tabPage3.Controls.Add(this.chkWebMethodCodeFolding);
            this.tabPage3.Controls.Add(this.chkWebMethodLineNumbers);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1118, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Web Method";
            // 
            // scintillaWebMethodCode
            // 
            this.scintillaWebMethodCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaWebMethodCode.BackColor = System.Drawing.SystemColors.Info;
            this.scintillaWebMethodCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scintillaWebMethodCode.Location = new System.Drawing.Point(3, 29);
            this.scintillaWebMethodCode.Name = "scintillaWebMethodCode";
            this.scintillaWebMethodCode.Size = new System.Drawing.Size(1110, 479);
            this.scintillaWebMethodCode.TabIndex = 7;
            // 
            // btnSaveWebMethodsToFile
            // 
            this.btnSaveWebMethodsToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveWebMethodsToFile.Location = new System.Drawing.Point(1038, 3);
            this.btnSaveWebMethodsToFile.Name = "btnSaveWebMethodsToFile";
            this.btnSaveWebMethodsToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWebMethodsToFile.TabIndex = 6;
            this.btnSaveWebMethodsToFile.Text = "Save To File";
            this.btnSaveWebMethodsToFile.UseVisualStyleBackColor = true;
            this.btnSaveWebMethodsToFile.Click += new System.EventHandler(this.btnSaveWebMethodsToFile_Click);
            // 
            // chkWebMethodCodeFolding
            // 
            this.chkWebMethodCodeFolding.AutoSize = true;
            this.chkWebMethodCodeFolding.Location = new System.Drawing.Point(105, 6);
            this.chkWebMethodCodeFolding.Name = "chkWebMethodCodeFolding";
            this.chkWebMethodCodeFolding.Size = new System.Drawing.Size(118, 17);
            this.chkWebMethodCodeFolding.TabIndex = 5;
            this.chkWebMethodCodeFolding.Text = "Show Code Folding";
            this.chkWebMethodCodeFolding.UseVisualStyleBackColor = true;
            this.chkWebMethodCodeFolding.CheckedChanged += new System.EventHandler(this.HandleWebMethodCodeFoldingCheckChanged);
            // 
            // chkWebMethodLineNumbers
            // 
            this.chkWebMethodLineNumbers.AutoSize = true;
            this.chkWebMethodLineNumbers.Location = new System.Drawing.Point(8, 6);
            this.chkWebMethodLineNumbers.Name = "chkWebMethodLineNumbers";
            this.chkWebMethodLineNumbers.Size = new System.Drawing.Size(91, 17);
            this.chkWebMethodLineNumbers.TabIndex = 4;
            this.chkWebMethodLineNumbers.Text = "Line Numbers";
            this.chkWebMethodLineNumbers.UseVisualStyleBackColor = true;
            this.chkWebMethodLineNumbers.CheckedChanged += new System.EventHandler(this.HandleWebMethodLineNumberCheckChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage7.Controls.Add(this.scintillaWEBAPICode);
            this.tabPage7.Controls.Add(this.btnSaveWEBAPI);
            this.tabPage7.Controls.Add(this.chkCodeFoldWEBAPI);
            this.tabPage7.Controls.Add(this.chkLineNumsWEBAPI);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1118, 519);
            this.tabPage7.TabIndex = 15;
            this.tabPage7.Text = "WebAPI";
            // 
            // scintillaWEBAPICode
            // 
            this.scintillaWEBAPICode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaWEBAPICode.BackColor = System.Drawing.SystemColors.Info;
            this.scintillaWEBAPICode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scintillaWEBAPICode.Location = new System.Drawing.Point(6, 30);
            this.scintillaWEBAPICode.Name = "scintillaWEBAPICode";
            this.scintillaWEBAPICode.Size = new System.Drawing.Size(1107, 481);
            this.scintillaWEBAPICode.TabIndex = 11;
            // 
            // btnSaveWEBAPI
            // 
            this.btnSaveWEBAPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveWEBAPI.Location = new System.Drawing.Point(1038, 3);
            this.btnSaveWEBAPI.Name = "btnSaveWEBAPI";
            this.btnSaveWEBAPI.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWEBAPI.TabIndex = 10;
            this.btnSaveWEBAPI.Text = "Save To File";
            this.btnSaveWEBAPI.UseVisualStyleBackColor = true;
            // 
            // chkCodeFoldWEBAPI
            // 
            this.chkCodeFoldWEBAPI.AutoSize = true;
            this.chkCodeFoldWEBAPI.Location = new System.Drawing.Point(103, 7);
            this.chkCodeFoldWEBAPI.Name = "chkCodeFoldWEBAPI";
            this.chkCodeFoldWEBAPI.Size = new System.Drawing.Size(118, 17);
            this.chkCodeFoldWEBAPI.TabIndex = 9;
            this.chkCodeFoldWEBAPI.Text = "Show Code Folding";
            this.chkCodeFoldWEBAPI.UseVisualStyleBackColor = true;
            // 
            // chkLineNumsWEBAPI
            // 
            this.chkLineNumsWEBAPI.AutoSize = true;
            this.chkLineNumsWEBAPI.Location = new System.Drawing.Point(6, 7);
            this.chkLineNumsWEBAPI.Name = "chkLineNumsWEBAPI";
            this.chkLineNumsWEBAPI.Size = new System.Drawing.Size(91, 17);
            this.chkLineNumsWEBAPI.TabIndex = 8;
            this.chkLineNumsWEBAPI.Text = "Line Numbers";
            this.chkLineNumsWEBAPI.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage10.Controls.Add(this.scintillaJSCode);
            this.tabPage10.Controls.Add(this.btnSaveJSToFile);
            this.tabPage10.Controls.Add(this.chkJSCodeFolding);
            this.tabPage10.Controls.Add(this.chkJSLineNumbers);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(1118, 519);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "JavaScript";
            // 
            // scintillaJSCode
            // 
            this.scintillaJSCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaJSCode.BackColor = System.Drawing.SystemColors.Info;
            this.scintillaJSCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scintillaJSCode.Location = new System.Drawing.Point(5, 30);
            this.scintillaJSCode.Name = "scintillaJSCode";
            this.scintillaJSCode.Size = new System.Drawing.Size(1108, 478);
            this.scintillaJSCode.TabIndex = 11;
            // 
            // btnSaveJSToFile
            // 
            this.btnSaveJSToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveJSToFile.Location = new System.Drawing.Point(1038, 3);
            this.btnSaveJSToFile.Name = "btnSaveJSToFile";
            this.btnSaveJSToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveJSToFile.TabIndex = 10;
            this.btnSaveJSToFile.Text = "Save To File";
            this.btnSaveJSToFile.UseVisualStyleBackColor = true;
            // 
            // chkJSCodeFolding
            // 
            this.chkJSCodeFolding.AutoSize = true;
            this.chkJSCodeFolding.Location = new System.Drawing.Point(107, 7);
            this.chkJSCodeFolding.Name = "chkJSCodeFolding";
            this.chkJSCodeFolding.Size = new System.Drawing.Size(118, 17);
            this.chkJSCodeFolding.TabIndex = 9;
            this.chkJSCodeFolding.Text = "Show Code Folding";
            this.chkJSCodeFolding.UseVisualStyleBackColor = true;
            // 
            // chkJSLineNumbers
            // 
            this.chkJSLineNumbers.AutoSize = true;
            this.chkJSLineNumbers.Location = new System.Drawing.Point(10, 7);
            this.chkJSLineNumbers.Name = "chkJSLineNumbers";
            this.chkJSLineNumbers.Size = new System.Drawing.Size(91, 17);
            this.chkJSLineNumbers.TabIndex = 8;
            this.chkJSLineNumbers.Text = "Line Numbers";
            this.chkJSLineNumbers.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage9.Controls.Add(this.scintillaRestCode);
            this.tabPage9.Controls.Add(this.btnRestSaveToFile);
            this.tabPage9.Controls.Add(this.chkRestCodeFolding);
            this.tabPage9.Controls.Add(this.chkRestLineNumbers);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1118, 519);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "REST";
            // 
            // scintillaRestCode
            // 
            this.scintillaRestCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaRestCode.BackColor = System.Drawing.SystemColors.Info;
            this.scintillaRestCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scintillaRestCode.Location = new System.Drawing.Point(6, 28);
            this.scintillaRestCode.Name = "scintillaRestCode";
            this.scintillaRestCode.Size = new System.Drawing.Size(1109, 477);
            this.scintillaRestCode.TabIndex = 11;
            // 
            // btnRestSaveToFile
            // 
            this.btnRestSaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestSaveToFile.Location = new System.Drawing.Point(1040, 3);
            this.btnRestSaveToFile.Name = "btnRestSaveToFile";
            this.btnRestSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.btnRestSaveToFile.TabIndex = 10;
            this.btnRestSaveToFile.Text = "Save To File";
            this.btnRestSaveToFile.UseVisualStyleBackColor = true;
            this.btnRestSaveToFile.Click += new System.EventHandler(this.btnRestSaveToFile_Click);
            // 
            // chkRestCodeFolding
            // 
            this.chkRestCodeFolding.AutoSize = true;
            this.chkRestCodeFolding.Location = new System.Drawing.Point(107, 7);
            this.chkRestCodeFolding.Name = "chkRestCodeFolding";
            this.chkRestCodeFolding.Size = new System.Drawing.Size(118, 17);
            this.chkRestCodeFolding.TabIndex = 9;
            this.chkRestCodeFolding.Text = "Show Code Folding";
            this.chkRestCodeFolding.UseVisualStyleBackColor = true;
            this.chkRestCodeFolding.CheckedChanged += new System.EventHandler(this.HandlechkRestCodeFoldingCheckChanged);
            // 
            // chkRestLineNumbers
            // 
            this.chkRestLineNumbers.AutoSize = true;
            this.chkRestLineNumbers.Location = new System.Drawing.Point(10, 7);
            this.chkRestLineNumbers.Name = "chkRestLineNumbers";
            this.chkRestLineNumbers.Size = new System.Drawing.Size(91, 17);
            this.chkRestLineNumbers.TabIndex = 8;
            this.chkRestLineNumbers.Text = "Line Numbers";
            this.chkRestLineNumbers.UseVisualStyleBackColor = true;
            this.chkRestLineNumbers.CheckedChanged += new System.EventHandler(this.HandlechkRestLineNumbersCheckChanged);
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage11.Controls.Add(this.btnFiddleIt);
            this.tabPage11.Controls.Add(this.scintillaHTMLCode);
            this.tabPage11.Controls.Add(this.btnSaveHTML);
            this.tabPage11.Controls.Add(this.chkHTMLCodeFolding);
            this.tabPage11.Controls.Add(this.chkHTMLLineNumbers);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(1118, 519);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "HTML";
            // 
            // btnFiddleIt
            // 
            this.btnFiddleIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiddleIt.Location = new System.Drawing.Point(957, 3);
            this.btnFiddleIt.Name = "btnFiddleIt";
            this.btnFiddleIt.Size = new System.Drawing.Size(75, 23);
            this.btnFiddleIt.TabIndex = 16;
            this.btnFiddleIt.Text = "Preview It";
            this.btnFiddleIt.UseVisualStyleBackColor = true;
            this.btnFiddleIt.Click += new System.EventHandler(this.btnFiddleIt_Click);
            // 
            // scintillaHTMLCode
            // 
            this.scintillaHTMLCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaHTMLCode.BackColor = System.Drawing.SystemColors.Info;
            this.scintillaHTMLCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scintillaHTMLCode.Location = new System.Drawing.Point(3, 28);
            this.scintillaHTMLCode.Name = "scintillaHTMLCode";
            this.scintillaHTMLCode.Size = new System.Drawing.Size(1110, 480);
            this.scintillaHTMLCode.TabIndex = 15;
            // 
            // btnSaveHTML
            // 
            this.btnSaveHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveHTML.Location = new System.Drawing.Point(1038, 3);
            this.btnSaveHTML.Name = "btnSaveHTML";
            this.btnSaveHTML.Size = new System.Drawing.Size(75, 23);
            this.btnSaveHTML.TabIndex = 14;
            this.btnSaveHTML.Text = "Save To File";
            this.btnSaveHTML.UseVisualStyleBackColor = true;
            this.btnSaveHTML.Click += new System.EventHandler(this.btnSaveHTML_Click);
            // 
            // chkHTMLCodeFolding
            // 
            this.chkHTMLCodeFolding.AutoSize = true;
            this.chkHTMLCodeFolding.Location = new System.Drawing.Point(107, 7);
            this.chkHTMLCodeFolding.Name = "chkHTMLCodeFolding";
            this.chkHTMLCodeFolding.Size = new System.Drawing.Size(118, 17);
            this.chkHTMLCodeFolding.TabIndex = 13;
            this.chkHTMLCodeFolding.Text = "Show Code Folding";
            this.chkHTMLCodeFolding.UseVisualStyleBackColor = true;
            this.chkHTMLCodeFolding.CheckedChanged += new System.EventHandler(this.HandleHTMLCodeFoldingChecked);
            // 
            // chkHTMLLineNumbers
            // 
            this.chkHTMLLineNumbers.AutoSize = true;
            this.chkHTMLLineNumbers.Location = new System.Drawing.Point(10, 7);
            this.chkHTMLLineNumbers.Name = "chkHTMLLineNumbers";
            this.chkHTMLLineNumbers.Size = new System.Drawing.Size(91, 17);
            this.chkHTMLLineNumbers.TabIndex = 12;
            this.chkHTMLLineNumbers.Text = "Line Numbers";
            this.chkHTMLLineNumbers.UseVisualStyleBackColor = true;
            this.chkHTMLLineNumbers.CheckedChanged += new System.EventHandler(this.HandleHTMLLineNumbersChecked);
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage12.Controls.Add(this.scintillaCSSCode);
            this.tabPage12.Controls.Add(this.btnsaveCSS);
            this.tabPage12.Controls.Add(this.chkCSSCodeFolding);
            this.tabPage12.Controls.Add(this.chkCSSLineNumbers);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(1118, 519);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "CSS";
            // 
            // scintillaCSSCode
            // 
            this.scintillaCSSCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaCSSCode.BackColor = System.Drawing.SystemColors.Info;
            this.scintillaCSSCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scintillaCSSCode.Location = new System.Drawing.Point(5, 30);
            this.scintillaCSSCode.Name = "scintillaCSSCode";
            this.scintillaCSSCode.Size = new System.Drawing.Size(1108, 478);
            this.scintillaCSSCode.TabIndex = 19;
            // 
            // btnsaveCSS
            // 
            this.btnsaveCSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsaveCSS.Location = new System.Drawing.Point(1038, 3);
            this.btnsaveCSS.Name = "btnsaveCSS";
            this.btnsaveCSS.Size = new System.Drawing.Size(75, 23);
            this.btnsaveCSS.TabIndex = 18;
            this.btnsaveCSS.Text = "Save To File";
            this.btnsaveCSS.UseVisualStyleBackColor = true;
            this.btnsaveCSS.Click += new System.EventHandler(this.btnsaveCSS_Click);
            // 
            // chkCSSCodeFolding
            // 
            this.chkCSSCodeFolding.AutoSize = true;
            this.chkCSSCodeFolding.Location = new System.Drawing.Point(107, 7);
            this.chkCSSCodeFolding.Name = "chkCSSCodeFolding";
            this.chkCSSCodeFolding.Size = new System.Drawing.Size(118, 17);
            this.chkCSSCodeFolding.TabIndex = 17;
            this.chkCSSCodeFolding.Text = "Show Code Folding";
            this.chkCSSCodeFolding.UseVisualStyleBackColor = true;
            this.chkCSSCodeFolding.CheckedChanged += new System.EventHandler(this.HandleCSSCodeFoldingChecked);
            // 
            // chkCSSLineNumbers
            // 
            this.chkCSSLineNumbers.AutoSize = true;
            this.chkCSSLineNumbers.Location = new System.Drawing.Point(10, 7);
            this.chkCSSLineNumbers.Name = "chkCSSLineNumbers";
            this.chkCSSLineNumbers.Size = new System.Drawing.Size(91, 17);
            this.chkCSSLineNumbers.TabIndex = 16;
            this.chkCSSLineNumbers.Text = "Line Numbers";
            this.chkCSSLineNumbers.UseVisualStyleBackColor = true;
            this.chkCSSLineNumbers.CheckedChanged += new System.EventHandler(this.HandleCSSLineNumbersChecked);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage4.Controls.Add(this.scintillaXAML);
            this.tabPage4.Controls.Add(this.btnSaveXaml);
            this.tabPage4.Controls.Add(this.chkXAMLCodeFoldingXaml);
            this.tabPage4.Controls.Add(this.chkLineNumbersXAML);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1118, 519);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "XAML";
            // 
            // scintillaXAML
            // 
            this.scintillaXAML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaXAML.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scintillaXAML.Location = new System.Drawing.Point(7, 30);
            this.scintillaXAML.Name = "scintillaXAML";
            this.scintillaXAML.Size = new System.Drawing.Size(1106, 478);
            this.scintillaXAML.TabIndex = 12;
            // 
            // btnSaveXaml
            // 
            this.btnSaveXaml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveXaml.Location = new System.Drawing.Point(1038, 6);
            this.btnSaveXaml.Name = "btnSaveXaml";
            this.btnSaveXaml.Size = new System.Drawing.Size(75, 23);
            this.btnSaveXaml.TabIndex = 11;
            this.btnSaveXaml.Text = "Save To File";
            this.btnSaveXaml.UseVisualStyleBackColor = true;
            this.btnSaveXaml.Click += new System.EventHandler(this.btnSaveXaml_Click);
            // 
            // chkXAMLCodeFoldingXaml
            // 
            this.chkXAMLCodeFoldingXaml.AutoSize = true;
            this.chkXAMLCodeFoldingXaml.Location = new System.Drawing.Point(104, 6);
            this.chkXAMLCodeFoldingXaml.Name = "chkXAMLCodeFoldingXaml";
            this.chkXAMLCodeFoldingXaml.Size = new System.Drawing.Size(118, 17);
            this.chkXAMLCodeFoldingXaml.TabIndex = 10;
            this.chkXAMLCodeFoldingXaml.Text = "Show Code Folding";
            this.chkXAMLCodeFoldingXaml.UseVisualStyleBackColor = true;
            this.chkXAMLCodeFoldingXaml.CheckedChanged += new System.EventHandler(this.HandleXAMLCodeFoldingChanged);
            // 
            // chkLineNumbersXAML
            // 
            this.chkLineNumbersXAML.AutoSize = true;
            this.chkLineNumbersXAML.Location = new System.Drawing.Point(7, 6);
            this.chkLineNumbersXAML.Name = "chkLineNumbersXAML";
            this.chkLineNumbersXAML.Size = new System.Drawing.Size(91, 17);
            this.chkLineNumbersXAML.TabIndex = 9;
            this.chkLineNumbersXAML.Text = "Line Numbers";
            this.chkLineNumbersXAML.UseVisualStyleBackColor = true;
            this.chkLineNumbersXAML.CheckedChanged += new System.EventHandler(this.HandleXamlLineNumberCheckChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tabPage5.Controls.Add(this.btnShowTestForm);
            this.tabPage5.Controls.Add(this.scintillaWFCode);
            this.tabPage5.Controls.Add(this.btnWFSaveToFile);
            this.tabPage5.Controls.Add(this.chkWFCodeFolding);
            this.tabPage5.Controls.Add(this.chkWFLineNumbers);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1118, 519);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "WinForms";
            // 
            // btnShowTestForm
            // 
            this.btnShowTestForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowTestForm.Location = new System.Drawing.Point(922, 4);
            this.btnShowTestForm.Name = "btnShowTestForm";
            this.btnShowTestForm.Size = new System.Drawing.Size(110, 23);
            this.btnShowTestForm.TabIndex = 9;
            this.btnShowTestForm.Text = "Show Test Form";
            this.btnShowTestForm.UseVisualStyleBackColor = true;
            this.btnShowTestForm.Click += new System.EventHandler(this.btnShowTestForm_Click);
            // 
            // scintillaWFCode
            // 
            this.scintillaWFCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaWFCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scintillaWFCode.Location = new System.Drawing.Point(6, 29);
            this.scintillaWFCode.Name = "scintillaWFCode";
            this.scintillaWFCode.Size = new System.Drawing.Size(1104, 478);
            this.scintillaWFCode.TabIndex = 8;
            // 
            // btnWFSaveToFile
            // 
            this.btnWFSaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWFSaveToFile.Location = new System.Drawing.Point(1038, 4);
            this.btnWFSaveToFile.Name = "btnWFSaveToFile";
            this.btnWFSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.btnWFSaveToFile.TabIndex = 7;
            this.btnWFSaveToFile.Text = "Save To File";
            this.btnWFSaveToFile.UseVisualStyleBackColor = true;
            this.btnWFSaveToFile.Click += new System.EventHandler(this.btnWFSaveToFile_Click);
            // 
            // chkWFCodeFolding
            // 
            this.chkWFCodeFolding.AutoSize = true;
            this.chkWFCodeFolding.Location = new System.Drawing.Point(106, 8);
            this.chkWFCodeFolding.Name = "chkWFCodeFolding";
            this.chkWFCodeFolding.Size = new System.Drawing.Size(118, 17);
            this.chkWFCodeFolding.TabIndex = 6;
            this.chkWFCodeFolding.Text = "Show Code Folding";
            this.chkWFCodeFolding.UseVisualStyleBackColor = true;
            this.chkWFCodeFolding.CheckedChanged += new System.EventHandler(this.HandleWinformsUICodeFoldingChanged);
            // 
            // chkWFLineNumbers
            // 
            this.chkWFLineNumbers.AutoSize = true;
            this.chkWFLineNumbers.Location = new System.Drawing.Point(9, 8);
            this.chkWFLineNumbers.Name = "chkWFLineNumbers";
            this.chkWFLineNumbers.Size = new System.Drawing.Size(91, 17);
            this.chkWFLineNumbers.TabIndex = 5;
            this.chkWFLineNumbers.Text = "Line Numbers";
            this.chkWFLineNumbers.UseVisualStyleBackColor = true;
            this.chkWFLineNumbers.CheckedChanged += new System.EventHandler(this.HandleWinformsLineNumberCheckChanged);
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage8.Controls.Add(this.sciSQLCode);
            this.tabPage8.Controls.Add(this.btnSaveSQLToFile);
            this.tabPage8.Controls.Add(this.chkSQLCodeFolding);
            this.tabPage8.Controls.Add(this.chkSQLLineNumber);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1118, 519);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "SQL Code";
            // 
            // sciSQLCode
            // 
            this.sciSQLCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sciSQLCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sciSQLCode.Location = new System.Drawing.Point(7, 30);
            this.sciSQLCode.Name = "sciSQLCode";
            this.sciSQLCode.Size = new System.Drawing.Size(1106, 478);
            this.sciSQLCode.TabIndex = 8;
            // 
            // btnSaveSQLToFile
            // 
            this.btnSaveSQLToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSQLToFile.Location = new System.Drawing.Point(1038, 7);
            this.btnSaveSQLToFile.Name = "btnSaveSQLToFile";
            this.btnSaveSQLToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSQLToFile.TabIndex = 7;
            this.btnSaveSQLToFile.Text = "Save To File";
            this.btnSaveSQLToFile.UseVisualStyleBackColor = true;
            this.btnSaveSQLToFile.Click += new System.EventHandler(this.btnSaveSQLToFile_Click);
            // 
            // chkSQLCodeFolding
            // 
            this.chkSQLCodeFolding.AutoSize = true;
            this.chkSQLCodeFolding.Location = new System.Drawing.Point(104, 7);
            this.chkSQLCodeFolding.Name = "chkSQLCodeFolding";
            this.chkSQLCodeFolding.Size = new System.Drawing.Size(118, 17);
            this.chkSQLCodeFolding.TabIndex = 6;
            this.chkSQLCodeFolding.Text = "Show Code Folding";
            this.chkSQLCodeFolding.UseVisualStyleBackColor = true;
            this.chkSQLCodeFolding.CheckedChanged += new System.EventHandler(this.chkSQLCodeFolding_CheckedChanged);
            // 
            // chkSQLLineNumber
            // 
            this.chkSQLLineNumber.AutoSize = true;
            this.chkSQLLineNumber.Location = new System.Drawing.Point(7, 7);
            this.chkSQLLineNumber.Name = "chkSQLLineNumber";
            this.chkSQLLineNumber.Size = new System.Drawing.Size(91, 17);
            this.chkSQLLineNumber.TabIndex = 5;
            this.chkSQLLineNumber.Text = "Line Numbers";
            this.chkSQLLineNumber.UseVisualStyleBackColor = true;
            this.chkSQLLineNumber.CheckedChanged += new System.EventHandler(this.chkSQLLineNumber_CheckedChanged);
            // 
            // tabPage14
            // 
            this.tabPage14.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage14.Controls.Add(this.chkPad);
            this.tabPage14.Controls.Add(this.btnStringify);
            this.tabPage14.Controls.Add(this.textBox1);
            this.tabPage14.Controls.Add(this.txtStringIfy);
            this.tabPage14.Controls.Add(this.sciStringify);
            this.tabPage14.Controls.Add(this.chkStringifyCodeFolding);
            this.tabPage14.Controls.Add(this.chkStringifyLineNumbers);
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Size = new System.Drawing.Size(1118, 519);
            this.tabPage14.TabIndex = 13;
            this.tabPage14.Text = "Stringify";
            // 
            // chkPad
            // 
            this.chkPad.Location = new System.Drawing.Point(7, 122);
            this.chkPad.Name = "chkPad";
            this.chkPad.Size = new System.Drawing.Size(162, 24);
            this.chkPad.TabIndex = 0;
            this.chkPad.Text = "Pad The Produced Strings";
            // 
            // btnStringify
            // 
            this.btnStringify.Location = new System.Drawing.Point(94, 75);
            this.btnStringify.Name = "btnStringify";
            this.btnStringify.Size = new System.Drawing.Size(75, 23);
            this.btnStringify.TabIndex = 10;
            this.btnStringify.Text = "Stringify";
            this.btnStringify.UseVisualStyleBackColor = true;
            this.btnStringify.Click += new System.EventHandler(this.btnStringify_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(147, 60);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Paste the desired long piece of text into the box on the right. Then click the ST" +
    "RINGIFY button below";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStringIfy
            // 
            this.txtStringIfy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStringIfy.Location = new System.Drawing.Point(270, 9);
            this.txtStringIfy.Multiline = true;
            this.txtStringIfy.Name = "txtStringIfy";
            this.txtStringIfy.Size = new System.Drawing.Size(843, 185);
            this.txtStringIfy.TabIndex = 8;
            // 
            // sciStringify
            // 
            this.sciStringify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sciStringify.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.sciStringify.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sciStringify.Lexer = ScintillaNET.Lexer.Cpp;
            this.sciStringify.Location = new System.Drawing.Point(6, 199);
            this.sciStringify.Name = "sciStringify";
            this.sciStringify.Size = new System.Drawing.Size(1109, 314);
            this.sciStringify.TabIndex = 7;
            // 
            // chkStringifyCodeFolding
            // 
            this.chkStringifyCodeFolding.AutoSize = true;
            this.chkStringifyCodeFolding.Location = new System.Drawing.Point(104, 183);
            this.chkStringifyCodeFolding.Name = "chkStringifyCodeFolding";
            this.chkStringifyCodeFolding.Size = new System.Drawing.Size(118, 17);
            this.chkStringifyCodeFolding.TabIndex = 6;
            this.chkStringifyCodeFolding.Text = "Show Code Folding";
            this.chkStringifyCodeFolding.UseVisualStyleBackColor = true;
            this.chkStringifyCodeFolding.CheckedChanged += new System.EventHandler(this.handlechkStringifyCodeFoldingCheckChanged);
            // 
            // chkStringifyLineNumbers
            // 
            this.chkStringifyLineNumbers.AutoSize = true;
            this.chkStringifyLineNumbers.Location = new System.Drawing.Point(7, 183);
            this.chkStringifyLineNumbers.Name = "chkStringifyLineNumbers";
            this.chkStringifyLineNumbers.Size = new System.Drawing.Size(91, 17);
            this.chkStringifyLineNumbers.TabIndex = 5;
            this.chkStringifyLineNumbers.Text = "Line Numbers";
            this.chkStringifyLineNumbers.UseVisualStyleBackColor = true;
            this.chkStringifyLineNumbers.CheckedChanged += new System.EventHandler(this.handlechkStringifyLineNumberCheckChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Thistle;
            this.tabPage6.Controls.Add(this.btnSQLPRETTY);
            this.tabPage6.Controls.Add(this.textBox2);
            this.tabPage6.Controls.Add(this.txtCRAPPYSQLCODE);
            this.tabPage6.Controls.Add(this.SQLCODEPRETTY);
            this.tabPage6.Controls.Add(this.chkSQLCODEPRETTYFOLDING);
            this.tabPage6.Controls.Add(this.chkSQLCODEPRETTYLINENUMBERS);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1118, 519);
            this.tabPage6.TabIndex = 14;
            this.tabPage6.Text = "SQL Beautiful";
            // 
            // btnSQLPRETTY
            // 
            this.btnSQLPRETTY.Location = new System.Drawing.Point(60, 73);
            this.btnSQLPRETTY.Name = "btnSQLPRETTY";
            this.btnSQLPRETTY.Size = new System.Drawing.Size(147, 23);
            this.btnSQLPRETTY.TabIndex = 16;
            this.btnSQLPRETTY.Text = "Make It Pretty";
            this.btnSQLPRETTY.UseVisualStyleBackColor = true;
            this.btnSQLPRETTY.Click += new System.EventHandler(this.btnSQLPRETTY_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 7);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(147, 60);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Paste the UGLY SQL Code into the text box on the right and click Make It Pretty t" +
    "o format it in a more readable manner";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCRAPPYSQLCODE
            // 
            this.txtCRAPPYSQLCODE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCRAPPYSQLCODE.Location = new System.Drawing.Point(227, 7);
            this.txtCRAPPYSQLCODE.Multiline = true;
            this.txtCRAPPYSQLCODE.Name = "txtCRAPPYSQLCODE";
            this.txtCRAPPYSQLCODE.Size = new System.Drawing.Size(886, 185);
            this.txtCRAPPYSQLCODE.TabIndex = 14;
            // 
            // SQLCODEPRETTY
            // 
            this.SQLCODEPRETTY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLCODEPRETTY.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.SQLCODEPRETTY.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLCODEPRETTY.Lexer = ScintillaNET.Lexer.Sql;
            this.SQLCODEPRETTY.Location = new System.Drawing.Point(6, 198);
            this.SQLCODEPRETTY.Name = "SQLCODEPRETTY";
            this.SQLCODEPRETTY.Size = new System.Drawing.Size(1107, 314);
            this.SQLCODEPRETTY.TabIndex = 13;
            // 
            // chkSQLCODEPRETTYFOLDING
            // 
            this.chkSQLCODEPRETTYFOLDING.AutoSize = true;
            this.chkSQLCODEPRETTYFOLDING.Location = new System.Drawing.Point(103, 181);
            this.chkSQLCODEPRETTYFOLDING.Name = "chkSQLCODEPRETTYFOLDING";
            this.chkSQLCODEPRETTYFOLDING.Size = new System.Drawing.Size(118, 17);
            this.chkSQLCODEPRETTYFOLDING.TabIndex = 12;
            this.chkSQLCODEPRETTYFOLDING.Text = "Show Code Folding";
            this.chkSQLCODEPRETTYFOLDING.UseVisualStyleBackColor = true;
            // 
            // chkSQLCODEPRETTYLINENUMBERS
            // 
            this.chkSQLCODEPRETTYLINENUMBERS.AutoSize = true;
            this.chkSQLCODEPRETTYLINENUMBERS.Location = new System.Drawing.Point(6, 181);
            this.chkSQLCODEPRETTYLINENUMBERS.Name = "chkSQLCODEPRETTYLINENUMBERS";
            this.chkSQLCODEPRETTYLINENUMBERS.Size = new System.Drawing.Size(91, 17);
            this.chkSQLCODEPRETTYLINENUMBERS.TabIndex = 11;
            this.chkSQLCODEPRETTYLINENUMBERS.Text = "Line Numbers";
            this.chkSQLCODEPRETTYLINENUMBERS.UseVisualStyleBackColor = true;
            this.chkSQLCODEPRETTYLINENUMBERS.CheckedChanged += new System.EventHandler(this.HandleSQLCodePrettyLineNumbersCheckChanged);
            // 
            // tabPage15
            // 
            this.tabPage15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage15.Controls.Add(this.btnDoBase64Encode);
            this.tabPage15.Controls.Add(this.textBox3);
            this.tabPage15.Controls.Add(this.txtBase64);
            this.tabPage15.Controls.Add(this.SCINTILLABASE64);
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(1118, 519);
            this.tabPage15.TabIndex = 16;
            this.tabPage15.Text = "BASE64Encode";
            // 
            // btnDoBase64Encode
            // 
            this.btnDoBase64Encode.Location = new System.Drawing.Point(60, 73);
            this.btnDoBase64Encode.Name = "btnDoBase64Encode";
            this.btnDoBase64Encode.Size = new System.Drawing.Size(147, 23);
            this.btnDoBase64Encode.TabIndex = 20;
            this.btnDoBase64Encode.Text = "Do The Job";
            this.btnDoBase64Encode.UseVisualStyleBackColor = true;
            this.btnDoBase64Encode.Click += new System.EventHandler(this.btnDoBase64Encode_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 7);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(147, 60);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "Paste the UGLY BASE64 String into the text box on the right and click Do The Job " +
    "to format it in a more readable manner";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBase64
            // 
            this.txtBase64.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBase64.Location = new System.Drawing.Point(227, 7);
            this.txtBase64.Multiline = true;
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.Size = new System.Drawing.Size(886, 185);
            this.txtBase64.TabIndex = 18;
            // 
            // SCINTILLABASE64
            // 
            this.SCINTILLABASE64.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SCINTILLABASE64.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.SCINTILLABASE64.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCINTILLABASE64.Lexer = ScintillaNET.Lexer.Cpp;
            this.SCINTILLABASE64.Location = new System.Drawing.Point(6, 198);
            this.SCINTILLABASE64.Name = "SCINTILLABASE64";
            this.SCINTILLABASE64.Size = new System.Drawing.Size(1107, 314);
            this.SCINTILLABASE64.TabIndex = 17;
            // 
            // tabPage16
            // 
            this.tabPage16.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage16.Controls.Add(this.btnMakeDispatchCase);
            this.tabPage16.Controls.Add(this.label13);
            this.tabPage16.Controls.Add(this.txtObjectTypeAndName);
            this.tabPage16.Controls.Add(this.label12);
            this.tabPage16.Controls.Add(this.btnProcessMethodNames);
            this.tabPage16.Controls.Add(this.txtMethodNames);
            this.tabPage16.Controls.Add(this.scintillaMMakerCode);
            this.tabPage16.Controls.Add(this.cbMMakerCodeFold);
            this.tabPage16.Controls.Add(this.cbMMakerLineNumbers);
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(1118, 519);
            this.tabPage16.TabIndex = 17;
            this.tabPage16.Text = "Method Maker";
            // 
            // btnMakeDispatchCase
            // 
            this.btnMakeDispatchCase.Location = new System.Drawing.Point(685, 18);
            this.btnMakeDispatchCase.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeDispatchCase.Name = "btnMakeDispatchCase";
            this.btnMakeDispatchCase.Size = new System.Drawing.Size(128, 34);
            this.btnMakeDispatchCase.TabIndex = 17;
            this.btnMakeDispatchCase.Text = "Make Dispatch Case";
            this.btnMakeDispatchCase.UseVisualStyleBackColor = true;
            this.btnMakeDispatchCase.Click += new System.EventHandler(this.btnMakeDispatchCase_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(628, 54);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Object Type and Name to hand into metrhods";
            // 
            // txtObjectTypeAndName
            // 
            this.txtObjectTypeAndName.Location = new System.Drawing.Point(631, 70);
            this.txtObjectTypeAndName.Margin = new System.Windows.Forms.Padding(2);
            this.txtObjectTypeAndName.Name = "txtObjectTypeAndName";
            this.txtObjectTypeAndName.Size = new System.Drawing.Size(335, 20);
            this.txtObjectTypeAndName.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Method Names to Make Each on their own line";
            // 
            // btnProcessMethodNames
            // 
            this.btnProcessMethodNames.Location = new System.Drawing.Point(575, 18);
            this.btnProcessMethodNames.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcessMethodNames.Name = "btnProcessMethodNames";
            this.btnProcessMethodNames.Size = new System.Drawing.Size(106, 34);
            this.btnProcessMethodNames.TabIndex = 13;
            this.btnProcessMethodNames.Text = "Make Methods";
            this.btnProcessMethodNames.UseVisualStyleBackColor = true;
            this.btnProcessMethodNames.Click += new System.EventHandler(this.btnProcessMethodNames_Click);
            // 
            // txtMethodNames
            // 
            this.txtMethodNames.Location = new System.Drawing.Point(14, 18);
            this.txtMethodNames.Margin = new System.Windows.Forms.Padding(2);
            this.txtMethodNames.Multiline = true;
            this.txtMethodNames.Name = "txtMethodNames";
            this.txtMethodNames.Size = new System.Drawing.Size(558, 123);
            this.txtMethodNames.TabIndex = 12;
            // 
            // scintillaMMakerCode
            // 
            this.scintillaMMakerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaMMakerCode.BackColor = System.Drawing.Color.LightSteelBlue;
            this.scintillaMMakerCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scintillaMMakerCode.Location = new System.Drawing.Point(7, 165);
            this.scintillaMMakerCode.Name = "scintillaMMakerCode";
            this.scintillaMMakerCode.Size = new System.Drawing.Size(1106, 352);
            this.scintillaMMakerCode.TabIndex = 11;
            // 
            // cbMMakerCodeFold
            // 
            this.cbMMakerCodeFold.AutoSize = true;
            this.cbMMakerCodeFold.Location = new System.Drawing.Point(105, 145);
            this.cbMMakerCodeFold.Name = "cbMMakerCodeFold";
            this.cbMMakerCodeFold.Size = new System.Drawing.Size(118, 17);
            this.cbMMakerCodeFold.TabIndex = 10;
            this.cbMMakerCodeFold.Text = "Show Code Folding";
            this.cbMMakerCodeFold.UseVisualStyleBackColor = true;
            // 
            // cbMMakerLineNumbers
            // 
            this.cbMMakerLineNumbers.AutoSize = true;
            this.cbMMakerLineNumbers.Location = new System.Drawing.Point(8, 145);
            this.cbMMakerLineNumbers.Name = "cbMMakerLineNumbers";
            this.cbMMakerLineNumbers.Size = new System.Drawing.Size(91, 17);
            this.cbMMakerLineNumbers.TabIndex = 9;
            this.cbMMakerLineNumbers.Text = "Line Numbers";
            this.cbMMakerLineNumbers.UseVisualStyleBackColor = true;
            this.cbMMakerLineNumbers.CheckedChanged += new System.EventHandler(this.HandlecbMMakerLineNumbersCheckedChanged);
            // 
            // tabPage17
            // 
            this.tabPage17.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage17.Controls.Add(this.btnMakeBasePython);
            this.tabPage17.Controls.Add(this.chkCodeFoldingAI);
            this.tabPage17.Controls.Add(this.chkLineNumbersAI);
            this.tabPage17.Controls.Add(this.lblworking);
            this.tabPage17.Controls.Add(this.btnMakeBaseJava);
            this.tabPage17.Controls.Add(this.txtLMSTUDIOAddress);
            this.tabPage17.Controls.Add(this.btnConnectLMStudio);
            this.tabPage17.Controls.Add(this.sciAICode);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(1118, 519);
            this.tabPage17.TabIndex = 18;
            this.tabPage17.Text = "AI";
            // 
            // lblworking
            // 
            this.lblworking.AutoSize = true;
            this.lblworking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblworking.Location = new System.Drawing.Point(437, 13);
            this.lblworking.Name = "lblworking";
            this.lblworking.Size = new System.Drawing.Size(438, 20);
            this.lblworking.TabIndex = 9;
            this.lblworking.Text = "One moment talking to the AI layer this may take a bit";
            this.lblworking.Visible = false;
            // 
            // btnMakeBaseJava
            // 
            this.btnMakeBaseJava.Location = new System.Drawing.Point(8, 37);
            this.btnMakeBaseJava.Name = "btnMakeBaseJava";
            this.btnMakeBaseJava.Size = new System.Drawing.Size(140, 23);
            this.btnMakeBaseJava.TabIndex = 8;
            this.btnMakeBaseJava.Text = "Make Base Java";
            this.btnMakeBaseJava.UseVisualStyleBackColor = true;
            this.btnMakeBaseJava.Click += new System.EventHandler(this.btnMakeBaseJava_Click);
            // 
            // txtLMSTUDIOAddress
            // 
            this.txtLMSTUDIOAddress.Location = new System.Drawing.Point(154, 10);
            this.txtLMSTUDIOAddress.Name = "txtLMSTUDIOAddress";
            this.txtLMSTUDIOAddress.Size = new System.Drawing.Size(266, 20);
            this.txtLMSTUDIOAddress.TabIndex = 7;
            this.txtLMSTUDIOAddress.Text = "http://127.0.0.1:1234";
            // 
            // btnConnectLMStudio
            // 
            this.btnConnectLMStudio.Location = new System.Drawing.Point(7, 7);
            this.btnConnectLMStudio.Name = "btnConnectLMStudio";
            this.btnConnectLMStudio.Size = new System.Drawing.Size(141, 23);
            this.btnConnectLMStudio.TabIndex = 6;
            this.btnConnectLMStudio.Text = "Connect LMSTUDIO";
            this.btnConnectLMStudio.UseVisualStyleBackColor = true;
            this.btnConnectLMStudio.Click += new System.EventHandler(this.btnConnectLMStudio_Click);
            // 
            // sciAICode
            // 
            this.sciAICode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sciAICode.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.sciAICode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sciAICode.Lexer = ScintillaNET.Lexer.Cpp;
            this.sciAICode.Location = new System.Drawing.Point(132, 68);
            this.sciAICode.Name = "sciAICode";
            this.sciAICode.Size = new System.Drawing.Size(980, 448);
            this.sciAICode.TabIndex = 5;
            // 
            // backgroundworkerThread
            // 
            this.backgroundworkerThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.HandleBackgroundWorker_DoWork);
            this.backgroundworkerThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.HandleBackgroundWorker_Completed);
            // 
            // chkCodeFoldingAI
            // 
            this.chkCodeFoldingAI.AutoSize = true;
            this.chkCodeFoldingAI.Checked = true;
            this.chkCodeFoldingAI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCodeFoldingAI.Location = new System.Drawing.Point(9, 90);
            this.chkCodeFoldingAI.Name = "chkCodeFoldingAI";
            this.chkCodeFoldingAI.Size = new System.Drawing.Size(118, 17);
            this.chkCodeFoldingAI.TabIndex = 11;
            this.chkCodeFoldingAI.Text = "Show Code Folding";
            this.chkCodeFoldingAI.UseVisualStyleBackColor = true;
            this.chkCodeFoldingAI.CheckedChanged += new System.EventHandler(this.HandleAICodeFoldingCheckChanged);
            // 
            // chkLineNumbersAI
            // 
            this.chkLineNumbersAI.AutoSize = true;
            this.chkLineNumbersAI.Location = new System.Drawing.Point(9, 67);
            this.chkLineNumbersAI.Name = "chkLineNumbersAI";
            this.chkLineNumbersAI.Size = new System.Drawing.Size(91, 17);
            this.chkLineNumbersAI.TabIndex = 10;
            this.chkLineNumbersAI.Text = "Line Numbers";
            this.chkLineNumbersAI.UseVisualStyleBackColor = true;
            this.chkLineNumbersAI.CheckedChanged += new System.EventHandler(this.HandleAILineNumbersChanged);
            // 
            // btnMakeBasePython
            // 
            this.btnMakeBasePython.Location = new System.Drawing.Point(154, 39);
            this.btnMakeBasePython.Name = "btnMakeBasePython";
            this.btnMakeBasePython.Size = new System.Drawing.Size(140, 23);
            this.btnMakeBasePython.TabIndex = 12;
            this.btnMakeBasePython.Text = "Make Base Python";
            this.btnMakeBasePython.UseVisualStyleBackColor = true;
            this.btnMakeBasePython.Click += new System.EventHandler(this.btnMakeBasePython_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 552);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeComplete (automated code generator and support Toolset)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage13.ResumeLayout(false);
            this.tabPage13.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage14.ResumeLayout(false);
            this.tabPage14.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage15.ResumeLayout(false);
            this.tabPage15.PerformLayout();
            this.tabPage16.ResumeLayout(false);
            this.tabPage16.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.tabPage17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboServers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboDatabases;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboTables;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        //private ScintillaNET.Scintilla sciBaseTableCode;
        private System.Windows.Forms.CheckBox chkBaseTableLineNumbers;
        private System.Windows.Forms.CheckBox chkBaseTableCodeFolding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManualServerName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkWebMethodCodeFolding;
        private System.Windows.Forms.CheckBox chkWebMethodLineNumbers;
        //private ScintillaNET.Scintilla scintillaWebMethodCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInterfaceOBJPrefix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkGenerateWebMethods;
        private System.Windows.Forms.CheckBox chkGenerateDeacivateOn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnSaveBaseCodeTableToFile;
        private System.Windows.Forms.Button btnSaveWebMethodsToFile;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.CheckBox chkINotifyCrap;
        private ScintillaNET.Scintilla sciBaseTableCode;
        private ScintillaNET.Scintilla scintillaWebMethodCode;
        private System.Windows.Forms.CheckBox chkPostProcessWSresultlist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.TextBox txtUSER;
        private System.Windows.Forms.Label label10;
        //private TAIGridControl2.TAIGridControl TAIGridDocDef;
        private ScintillaNET.Scintilla scintillaWFCode;
        private System.Windows.Forms.Button btnWFSaveToFile;
        private System.Windows.Forms.CheckBox chkWFCodeFolding;
        private System.Windows.Forms.CheckBox chkWFLineNumbers;
        private ScintillaNET.Scintilla scintillaXAML;
        private System.Windows.Forms.Button btnSaveXaml;
        private System.Windows.Forms.CheckBox chkXAMLCodeFoldingXaml;
        private System.Windows.Forms.CheckBox chkLineNumbersXAML;
        private System.Windows.Forms.CheckBox chkXAMLFromOrUserControl;
        //private TAIGridControl2.TAIGridControl taigLookupListGrid;
        private System.Windows.Forms.TabPage tabPage8;
        private ScintillaNET.Scintilla sciSQLCode;
        private System.Windows.Forms.Button btnSaveSQLToFile;
        private System.Windows.Forms.CheckBox chkSQLCodeFolding;
        private System.Windows.Forms.CheckBox chkSQLLineNumber;
        private System.ComponentModel.BackgroundWorker backgroundworkerThread;
        private System.Windows.Forms.Label lblOneMoment;
        private System.Windows.Forms.TabPage tabPage9;
        private ScintillaNET.Scintilla scintillaRestCode;
        private System.Windows.Forms.Button btnRestSaveToFile;
        private System.Windows.Forms.CheckBox chkRestCodeFolding;
        private System.Windows.Forms.CheckBox chkRestLineNumbers;
        private System.Windows.Forms.TabPage tabPage10;
        private ScintillaNET.Scintilla scintillaJSCode;
        private System.Windows.Forms.Button btnSaveJSToFile;
        private System.Windows.Forms.CheckBox chkJSCodeFolding;
        private System.Windows.Forms.CheckBox chkJSLineNumbers;
        private System.Windows.Forms.TabPage tabPage11;
        private ScintillaNET.Scintilla scintillaHTMLCode;
        private System.Windows.Forms.Button btnSaveHTML;
        private System.Windows.Forms.CheckBox chkHTMLCodeFolding;
        private System.Windows.Forms.CheckBox chkHTMLLineNumbers;
        private System.Windows.Forms.TabPage tabPage12;
        private ScintillaNET.Scintilla scintillaCSSCode;
        private System.Windows.Forms.Button btnsaveCSS;
        private System.Windows.Forms.CheckBox chkCSSCodeFolding;
        private System.Windows.Forms.CheckBox chkCSSLineNumbers;
        private System.Windows.Forms.Button btnFiddleIt;
        private System.Windows.Forms.CheckBox chkDOJAVASCRIPTUI;
        private System.Windows.Forms.TabPage tabPage13;
        private ScintillaNET.Scintilla sciBaseTableTSCode;
        private System.Windows.Forms.Button btnSaveTSCode;
        private System.Windows.Forms.CheckBox chkBaseTableTSCodeFolding;
        private System.Windows.Forms.CheckBox chkBaseTableTSLineNumbers;
        private System.Windows.Forms.CheckBox chkGenerateInsertStatements;
        private System.Windows.Forms.Button btnSSPI;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtManualConnectionString;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.Button btnStringify;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtStringIfy;
        private ScintillaNET.Scintilla sciStringify;
        private System.Windows.Forms.CheckBox chkStringifyCodeFolding;
        private System.Windows.Forms.CheckBox chkStringifyLineNumbers;
        private System.Windows.Forms.Button btnEnumerateLocalSQLServers;
        private System.Windows.Forms.CheckBox chkPad;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnSQLPRETTY;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCRAPPYSQLCODE;
        private ScintillaNET.Scintilla SQLCODEPRETTY;
        private System.Windows.Forms.CheckBox chkSQLCODEPRETTYFOLDING;
        private System.Windows.Forms.CheckBox chkSQLCODEPRETTYLINENUMBERS;
        private System.Windows.Forms.Button btnShowConnectionString;
        private System.Windows.Forms.TextBox txtDerivedConnectionString;
        private System.Windows.Forms.TabPage tabPage7;
        private ScintillaNET.Scintilla scintillaWEBAPICode;
        private System.Windows.Forms.Button btnSaveWEBAPI;
        private System.Windows.Forms.CheckBox chkCodeFoldWEBAPI;
        private System.Windows.Forms.CheckBox chkLineNumsWEBAPI;
        private System.Windows.Forms.Button btnShowTestForm;
        private System.Windows.Forms.Button btnRegenerateBaseClass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.Button btnDoBase64Encode;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtBase64;
        private ScintillaNET.Scintilla SCINTILLABASE64;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.TextBox txtMethodNames;
        private ScintillaNET.Scintilla scintillaMMakerCode;
        private System.Windows.Forms.CheckBox cbMMakerCodeFold;
        private System.Windows.Forms.CheckBox cbMMakerLineNumbers;
        private System.Windows.Forms.Button btnProcessMethodNames;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtObjectTypeAndName;
        private System.Windows.Forms.Button btnMakeDispatchCase;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCMDTimeout;
        private System.Windows.Forms.CheckBox chkGenUpdate;
        private System.Windows.Forms.CheckBox chkGenRead;
        private System.Windows.Forms.CheckBox chkGenDelete;
        private System.Windows.Forms.CheckBox chkGenFastAdd;
        private System.Windows.Forms.CheckBox chkGenAdd;
        private System.Windows.Forms.CheckBox chkGenReadAsDataSet;
        private System.Windows.Forms.TabPage tabPage17;
        private ScintillaNET.Scintilla sciAICode;
        private System.Windows.Forms.TextBox txtLMSTUDIOAddress;
        private System.Windows.Forms.Button btnConnectLMStudio;
        private System.Windows.Forms.Button btnMakeBaseJava;
        private System.Windows.Forms.Label lblworking;
        private System.Windows.Forms.CheckBox chkCodeFoldingAI;
        private System.Windows.Forms.CheckBox chkLineNumbersAI;
        private System.Windows.Forms.Button btnMakeBasePython;
    }
}

