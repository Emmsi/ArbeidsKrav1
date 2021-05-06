
namespace ArbeidsKrav1
{
    partial class FormMain
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
            System.Windows.Forms.Label uRVLabel;
            System.Windows.Forms.Label rDC_IDLabel1;
            System.Windows.Forms.Label alarmLLabel;
            System.Windows.Forms.Label lRVLabel;
            System.Windows.Forms.Label location_IDLabel;
            System.Windows.Forms.Label dAU_IDLabel;
            System.Windows.Forms.Label alarmHLabel;
            System.Windows.Forms.Label comms_IDLabel1;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label scanFrequencyLabel;
            System.Windows.Forms.Label location_IDLabel1;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label type_IDLabel;
            System.Windows.Forms.Label tagnameLabel;
            System.Windows.Forms.Label maker_IDLabel;
            System.Windows.Forms.Label comms_IDLabel;
            System.Windows.Forms.Label dAU_IDLabel1;
            System.Windows.Forms.Label labelError;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelPick = new System.Windows.Forms.Panel();
            this.buttonConfiguration = new System.Windows.Forms.Button();
            this.buttonData = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.buttonCommsTypesGrid = new System.Windows.Forms.Button();
            this.buttonRDCGrid = new System.Windows.Forms.Button();
            this.buttonDAUGrid = new System.Windows.Forms.Button();
            this.buttonInstrumentTypesGrid = new System.Windows.Forms.Button();
            this.buttonInstrumentGrid = new System.Windows.Forms.Button();
            this.buttonDataLogGrid = new System.Windows.Forms.Button();
            this.buttonLogIDGrid = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.buttonManufacturerGrid = new System.Windows.Forms.Button();
            this.buttonLocationGrid = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.dAUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baudrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSQL = new System.Windows.Forms.BindingSource(this.components);
            this.softSensConfDBDataSet = new ArbeidsKrav1.SoftSensConfDBDataSet();
            this.labelStatusChange = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.communicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialPortMain = new System.IO.Ports.SerialPort(this.components);
            this.dataLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.communicationTableAdapter = new ArbeidsKrav1.SoftSensConfDBDataSetTableAdapters.CommunicationTableAdapter();
            this.dataLogTableAdapter = new ArbeidsKrav1.SoftSensConfDBDataSetTableAdapters.DataLogTableAdapter();
            this.dAUTableAdapter = new ArbeidsKrav1.SoftSensConfDBDataSetTableAdapters.DAUTableAdapter();
            this.instrumentTableAdapter = new ArbeidsKrav1.SoftSensConfDBDataSetTableAdapters.InstrumentTableAdapter();
            this.instrument_TypeTableAdapter = new ArbeidsKrav1.SoftSensConfDBDataSetTableAdapters.Instrument_TypeTableAdapter();
            this.locationTableAdapter = new ArbeidsKrav1.SoftSensConfDBDataSetTableAdapters.LocationTableAdapter();
            this.logIDTableAdapter = new ArbeidsKrav1.SoftSensConfDBDataSetTableAdapters.LogIDTableAdapter();
            this.manufacturerTableAdapter = new ArbeidsKrav1.SoftSensConfDBDataSetTableAdapters.ManufacturerTableAdapter();
            this.rDCTableAdapter = new ArbeidsKrav1.SoftSensConfDBDataSetTableAdapters.RDCTableAdapter();
            this.location_IDComboBox = new System.Windows.Forms.ComboBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.uRVTextBox = new System.Windows.Forms.TextBox();
            this.lRVTextBox = new System.Windows.Forms.TextBox();
            this.rDC_IDComboBox = new System.Windows.Forms.ComboBox();
            this.comms_IDComboBox = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.alarmLTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.labelBit = new System.Windows.Forms.Label();
            this.alarmHTextBox = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.location_IDTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.labelConnection = new System.Windows.Forms.Label();
            this.comboBoxBit = new System.Windows.Forms.ComboBox();
            this.scanFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.tagnameTextBox = new System.Windows.Forms.TextBox();
            this.radioButtonConnected = new System.Windows.Forms.RadioButton();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.type_IDTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comms_IDTextBox = new System.Windows.Forms.TextBox();
            this.ComboBoxFindDev = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelHeadSetup = new System.Windows.Forms.Label();
            this.maker_IDTextBox = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.dAU_IDTextBox = new System.Windows.Forms.TextBox();
            this.labelDAU = new System.Windows.Forms.Label();
            this.comboBoxFindTag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelConfiguration = new System.Windows.Forms.Panel();
            uRVLabel = new System.Windows.Forms.Label();
            rDC_IDLabel1 = new System.Windows.Forms.Label();
            alarmLLabel = new System.Windows.Forms.Label();
            lRVLabel = new System.Windows.Forms.Label();
            location_IDLabel = new System.Windows.Forms.Label();
            dAU_IDLabel = new System.Windows.Forms.Label();
            alarmHLabel = new System.Windows.Forms.Label();
            comms_IDLabel1 = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            scanFrequencyLabel = new System.Windows.Forms.Label();
            location_IDLabel1 = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            type_IDLabel = new System.Windows.Forms.Label();
            tagnameLabel = new System.Windows.Forms.Label();
            maker_IDLabel = new System.Windows.Forms.Label();
            comms_IDLabel = new System.Windows.Forms.Label();
            dAU_IDLabel1 = new System.Windows.Forms.Label();
            labelError = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensConfDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            this.panelConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // uRVLabel
            // 
            uRVLabel.AutoSize = true;
            uRVLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uRVLabel.Location = new System.Drawing.Point(451, 403);
            uRVLabel.Name = "uRVLabel";
            uRVLabel.Size = new System.Drawing.Size(210, 23);
            uRVLabel.TabIndex = 47;
            uRVLabel.Text = "Upper Range Value:";
            // 
            // rDC_IDLabel1
            // 
            rDC_IDLabel1.AutoSize = true;
            rDC_IDLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            rDC_IDLabel1.Location = new System.Drawing.Point(54, 265);
            rDC_IDLabel1.Name = "rDC_IDLabel1";
            rDC_IDLabel1.Size = new System.Drawing.Size(84, 23);
            rDC_IDLabel1.TabIndex = 16;
            rDC_IDLabel1.Text = "RDC ID:";
            // 
            // alarmLLabel
            // 
            alarmLLabel.AutoSize = true;
            alarmLLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alarmLLabel.Location = new System.Drawing.Point(451, 435);
            alarmLLabel.Name = "alarmLLabel";
            alarmLLabel.Size = new System.Drawing.Size(120, 23);
            alarmLLabel.TabIndex = 49;
            alarmLLabel.Text = "Alarm Low:";
            // 
            // lRVLabel
            // 
            lRVLabel.AutoSize = true;
            lRVLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lRVLabel.Location = new System.Drawing.Point(451, 371);
            lRVLabel.Name = "lRVLabel";
            lRVLabel.Size = new System.Drawing.Size(209, 23);
            lRVLabel.TabIndex = 45;
            lRVLabel.Text = "Lower Range Value:";
            // 
            // location_IDLabel
            // 
            location_IDLabel.AutoSize = true;
            location_IDLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            location_IDLabel.Location = new System.Drawing.Point(54, 299);
            location_IDLabel.Name = "location_IDLabel";
            location_IDLabel.Size = new System.Drawing.Size(99, 23);
            location_IDLabel.TabIndex = 16;
            location_IDLabel.Text = "Location:";
            // 
            // dAU_IDLabel
            // 
            dAU_IDLabel.AutoSize = true;
            dAU_IDLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            dAU_IDLabel.Location = new System.Drawing.Point(54, 143);
            dAU_IDLabel.Name = "dAU_IDLabel";
            dAU_IDLabel.Size = new System.Drawing.Size(130, 23);
            dAU_IDLabel.TabIndex = 0;
            dAU_IDLabel.Text = "Find Device:";
            // 
            // alarmHLabel
            // 
            alarmHLabel.AutoSize = true;
            alarmHLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alarmHLabel.Location = new System.Drawing.Point(451, 467);
            alarmHLabel.Name = "alarmHLabel";
            alarmHLabel.Size = new System.Drawing.Size(122, 23);
            alarmHLabel.TabIndex = 51;
            alarmHLabel.Text = "Alarm High:";
            // 
            // comms_IDLabel1
            // 
            comms_IDLabel1.AutoSize = true;
            comms_IDLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            comms_IDLabel1.Location = new System.Drawing.Point(54, 333);
            comms_IDLabel1.Name = "comms_IDLabel1";
            comms_IDLabel1.Size = new System.Drawing.Size(142, 23);
            comms_IDLabel1.TabIndex = 16;
            comms_IDLabel1.Text = "Comms Type:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel1.Location = new System.Drawing.Point(451, 339);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(122, 23);
            descriptionLabel1.TabIndex = 43;
            descriptionLabel1.Text = "Description:";
            // 
            // scanFrequencyLabel
            // 
            scanFrequencyLabel.AutoSize = true;
            scanFrequencyLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scanFrequencyLabel.Location = new System.Drawing.Point(451, 499);
            scanFrequencyLabel.Name = "scanFrequencyLabel";
            scanFrequencyLabel.Size = new System.Drawing.Size(174, 23);
            scanFrequencyLabel.TabIndex = 53;
            scanFrequencyLabel.Text = "Scan Frequency:";
            // 
            // location_IDLabel1
            // 
            location_IDLabel1.AutoSize = true;
            location_IDLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            location_IDLabel1.Location = new System.Drawing.Point(451, 307);
            location_IDLabel1.Name = "location_IDLabel1";
            location_IDLabel1.Size = new System.Drawing.Size(99, 23);
            location_IDLabel1.TabIndex = 41;
            location_IDLabel1.Text = "Location:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            descriptionLabel.Location = new System.Drawing.Point(54, 367);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(122, 23);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // type_IDLabel
            // 
            type_IDLabel.AutoSize = true;
            type_IDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            type_IDLabel.Location = new System.Drawing.Point(451, 531);
            type_IDLabel.Name = "type_IDLabel";
            type_IDLabel.Size = new System.Drawing.Size(168, 23);
            type_IDLabel.TabIndex = 55;
            type_IDLabel.Text = "Instrument Type:";
            // 
            // tagnameLabel
            // 
            tagnameLabel.AutoSize = true;
            tagnameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tagnameLabel.Location = new System.Drawing.Point(451, 275);
            tagnameLabel.Name = "tagnameLabel";
            tagnameLabel.Size = new System.Drawing.Size(108, 23);
            tagnameLabel.TabIndex = 39;
            tagnameLabel.Text = "Tagname:";
            // 
            // maker_IDLabel
            // 
            maker_IDLabel.AutoSize = true;
            maker_IDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maker_IDLabel.Location = new System.Drawing.Point(451, 563);
            maker_IDLabel.Name = "maker_IDLabel";
            maker_IDLabel.Size = new System.Drawing.Size(147, 23);
            maker_IDLabel.TabIndex = 57;
            maker_IDLabel.Text = "Manufacturer:";
            // 
            // comms_IDLabel
            // 
            comms_IDLabel.AutoSize = true;
            comms_IDLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comms_IDLabel.Location = new System.Drawing.Point(451, 243);
            comms_IDLabel.Name = "comms_IDLabel";
            comms_IDLabel.Size = new System.Drawing.Size(116, 23);
            comms_IDLabel.TabIndex = 37;
            comms_IDLabel.Text = "Comms ID:";
            // 
            // dAU_IDLabel1
            // 
            dAU_IDLabel1.AutoSize = true;
            dAU_IDLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dAU_IDLabel1.Location = new System.Drawing.Point(451, 211);
            dAU_IDLabel1.Name = "dAU_IDLabel1";
            dAU_IDLabel1.Size = new System.Drawing.Size(84, 23);
            dAU_IDLabel1.TabIndex = 35;
            dAU_IDLabel1.Text = "DAU ID:";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelError.Location = new System.Drawing.Point(462, 151);
            labelError.Name = "labelError";
            labelError.Size = new System.Drawing.Size(52, 23);
            labelError.TabIndex = 63;
            labelError.Text = "Error";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.White;
            this.panelButtons.Controls.Add(this.panelPick);
            this.panelButtons.Controls.Add(this.buttonConfiguration);
            this.panelButtons.Controls.Add(this.buttonData);
            this.panelButtons.Controls.Add(this.buttonDashboard);
            this.panelButtons.Controls.Add(this.pictureBoxLogo);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(196, 605);
            this.panelButtons.TabIndex = 0;
            // 
            // panelPick
            // 
            this.panelPick.BackColor = System.Drawing.Color.Black;
            this.panelPick.Location = new System.Drawing.Point(186, 145);
            this.panelPick.Name = "panelPick";
            this.panelPick.Size = new System.Drawing.Size(10, 109);
            this.panelPick.TabIndex = 2;
            // 
            // buttonConfiguration
            // 
            this.buttonConfiguration.FlatAppearance.BorderSize = 0;
            this.buttonConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguration.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfiguration.ForeColor = System.Drawing.Color.Black;
            this.buttonConfiguration.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfiguration.Image")));
            this.buttonConfiguration.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConfiguration.Location = new System.Drawing.Point(3, 358);
            this.buttonConfiguration.Name = "buttonConfiguration";
            this.buttonConfiguration.Size = new System.Drawing.Size(190, 109);
            this.buttonConfiguration.TabIndex = 3;
            this.buttonConfiguration.Text = "Configuration";
            this.buttonConfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonConfiguration.UseVisualStyleBackColor = true;
            this.buttonConfiguration.Click += new System.EventHandler(this.buttonSetup_Click);
            // 
            // buttonData
            // 
            this.buttonData.FlatAppearance.BorderSize = 0;
            this.buttonData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonData.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonData.ForeColor = System.Drawing.Color.Black;
            this.buttonData.Image = ((System.Drawing.Image)(resources.GetObject("buttonData.Image")));
            this.buttonData.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonData.Location = new System.Drawing.Point(3, 251);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(190, 106);
            this.buttonData.TabIndex = 2;
            this.buttonData.Text = "Data Editing";
            this.buttonData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.buttonData_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.Black;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDashboard.Location = new System.Drawing.Point(3, 145);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(190, 109);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Data Viewing";
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Image = global::ArbeidsKrav1.Properties.Resources.USN_logotype;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(196, 113);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.DarkGray;
            this.panelDashboard.Controls.Add(this.buttonCommsTypesGrid);
            this.panelDashboard.Controls.Add(this.buttonRDCGrid);
            this.panelDashboard.Controls.Add(this.buttonDAUGrid);
            this.panelDashboard.Controls.Add(this.buttonInstrumentTypesGrid);
            this.panelDashboard.Controls.Add(this.buttonInstrumentGrid);
            this.panelDashboard.Controls.Add(this.buttonDataLogGrid);
            this.panelDashboard.Controls.Add(this.buttonLogIDGrid);
            this.panelDashboard.Controls.Add(this.dataGridViewAdmin);
            this.panelDashboard.Controls.Add(this.buttonManufacturerGrid);
            this.panelDashboard.Controls.Add(this.buttonLocationGrid);
            this.panelDashboard.Controls.Add(this.label11);
            this.panelDashboard.Location = new System.Drawing.Point(197, 4);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(891, 595);
            this.panelDashboard.TabIndex = 39;
            // 
            // buttonCommsTypesGrid
            // 
            this.buttonCommsTypesGrid.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonCommsTypesGrid.Location = new System.Drawing.Point(46, 440);
            this.buttonCommsTypesGrid.Name = "buttonCommsTypesGrid";
            this.buttonCommsTypesGrid.Size = new System.Drawing.Size(197, 33);
            this.buttonCommsTypesGrid.TabIndex = 33;
            this.buttonCommsTypesGrid.Text = "View Communication Types";
            this.buttonCommsTypesGrid.UseVisualStyleBackColor = true;
            this.buttonCommsTypesGrid.Click += new System.EventHandler(this.buttonCommsTypesGrid_Click);
            // 
            // buttonRDCGrid
            // 
            this.buttonRDCGrid.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonRDCGrid.Location = new System.Drawing.Point(46, 404);
            this.buttonRDCGrid.Name = "buttonRDCGrid";
            this.buttonRDCGrid.Size = new System.Drawing.Size(197, 33);
            this.buttonRDCGrid.TabIndex = 32;
            this.buttonRDCGrid.Text = "View RDCs";
            this.buttonRDCGrid.UseVisualStyleBackColor = true;
            this.buttonRDCGrid.Click += new System.EventHandler(this.buttonRDCGrid_Click);
            // 
            // buttonDAUGrid
            // 
            this.buttonDAUGrid.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonDAUGrid.Location = new System.Drawing.Point(249, 404);
            this.buttonDAUGrid.Name = "buttonDAUGrid";
            this.buttonDAUGrid.Size = new System.Drawing.Size(197, 33);
            this.buttonDAUGrid.TabIndex = 31;
            this.buttonDAUGrid.Text = "View DAUs";
            this.buttonDAUGrid.UseVisualStyleBackColor = true;
            this.buttonDAUGrid.Click += new System.EventHandler(this.buttonDAUGrid_Click);
            // 
            // buttonInstrumentTypesGrid
            // 
            this.buttonInstrumentTypesGrid.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonInstrumentTypesGrid.Location = new System.Drawing.Point(452, 443);
            this.buttonInstrumentTypesGrid.Name = "buttonInstrumentTypesGrid";
            this.buttonInstrumentTypesGrid.Size = new System.Drawing.Size(197, 33);
            this.buttonInstrumentTypesGrid.TabIndex = 30;
            this.buttonInstrumentTypesGrid.Text = "View Instrument Types";
            this.buttonInstrumentTypesGrid.UseVisualStyleBackColor = true;
            this.buttonInstrumentTypesGrid.Click += new System.EventHandler(this.buttonInstrumentTypesGrid_Click);
            // 
            // buttonInstrumentGrid
            // 
            this.buttonInstrumentGrid.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonInstrumentGrid.Location = new System.Drawing.Point(452, 404);
            this.buttonInstrumentGrid.Name = "buttonInstrumentGrid";
            this.buttonInstrumentGrid.Size = new System.Drawing.Size(197, 33);
            this.buttonInstrumentGrid.TabIndex = 29;
            this.buttonInstrumentGrid.Text = "View Instruments";
            this.buttonInstrumentGrid.UseVisualStyleBackColor = true;
            this.buttonInstrumentGrid.Click += new System.EventHandler(this.buttonInstrumentGrid_Click);
            // 
            // buttonDataLogGrid
            // 
            this.buttonDataLogGrid.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonDataLogGrid.Location = new System.Drawing.Point(249, 482);
            this.buttonDataLogGrid.Name = "buttonDataLogGrid";
            this.buttonDataLogGrid.Size = new System.Drawing.Size(197, 33);
            this.buttonDataLogGrid.TabIndex = 28;
            this.buttonDataLogGrid.Text = "View Data Logs";
            this.buttonDataLogGrid.UseVisualStyleBackColor = true;
            this.buttonDataLogGrid.Click += new System.EventHandler(this.buttonDataLogGrid_Click);
            // 
            // buttonLogIDGrid
            // 
            this.buttonLogIDGrid.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonLogIDGrid.Location = new System.Drawing.Point(452, 482);
            this.buttonLogIDGrid.Name = "buttonLogIDGrid";
            this.buttonLogIDGrid.Size = new System.Drawing.Size(197, 33);
            this.buttonLogIDGrid.TabIndex = 27;
            this.buttonLogIDGrid.Text = "View Log IDs";
            this.buttonLogIDGrid.UseVisualStyleBackColor = true;
            this.buttonLogIDGrid.Click += new System.EventHandler(this.buttonLogIDGrid_Click);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(46, 107);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(800, 291);
            this.dataGridViewAdmin.TabIndex = 26;
            this.dataGridViewAdmin.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_RowValidated);
            this.dataGridViewAdmin.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_RowValidated);
            // 
            // buttonManufacturerGrid
            // 
            this.buttonManufacturerGrid.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonManufacturerGrid.Location = new System.Drawing.Point(46, 479);
            this.buttonManufacturerGrid.Name = "buttonManufacturerGrid";
            this.buttonManufacturerGrid.Size = new System.Drawing.Size(197, 33);
            this.buttonManufacturerGrid.TabIndex = 25;
            this.buttonManufacturerGrid.Text = "View Manufacturers";
            this.buttonManufacturerGrid.UseVisualStyleBackColor = true;
            this.buttonManufacturerGrid.Click += new System.EventHandler(this.buttonManufacturerGrid_Click);
            // 
            // buttonLocationGrid
            // 
            this.buttonLocationGrid.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.buttonLocationGrid.Location = new System.Drawing.Point(249, 443);
            this.buttonLocationGrid.Name = "buttonLocationGrid";
            this.buttonLocationGrid.Size = new System.Drawing.Size(197, 33);
            this.buttonLocationGrid.TabIndex = 24;
            this.buttonLocationGrid.Text = "View Locations";
            this.buttonLocationGrid.UseVisualStyleBackColor = true;
            this.buttonLocationGrid.Click += new System.EventHandler(this.buttonLocationGrid_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(279, 47);
            this.label11.TabIndex = 17;
            this.label11.Text = "Data Viewing";
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.DarkGray;
            this.panelData.Controls.Add(this.dataGridViewMain);
            this.panelData.Controls.Add(this.labelStatusChange);
            this.panelData.Controls.Add(this.labelData);
            this.panelData.Location = new System.Drawing.Point(197, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(897, 605);
            this.panelData.TabIndex = 2;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToOrderColumns = true;
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.AutoGenerateColumns = false;
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dAUIDDataGridViewTextBoxColumn,
            this.rDCIDDataGridViewTextBoxColumn,
            this.locationIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.commsIDDataGridViewTextBoxColumn,
            this.cOMportDataGridViewTextBoxColumn,
            this.baudrateDataGridViewTextBoxColumn});
            this.dataGridViewMain.DataSource = this.dAUBindingSource;
            this.dataGridViewMain.Location = new System.Drawing.Point(46, 111);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(800, 330);
            this.dataGridViewMain.TabIndex = 32;
            // 
            // dAUIDDataGridViewTextBoxColumn
            // 
            this.dAUIDDataGridViewTextBoxColumn.DataPropertyName = "DAU_ID";
            this.dAUIDDataGridViewTextBoxColumn.HeaderText = "DAU_ID";
            this.dAUIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dAUIDDataGridViewTextBoxColumn.Name = "dAUIDDataGridViewTextBoxColumn";
            this.dAUIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rDCIDDataGridViewTextBoxColumn
            // 
            this.rDCIDDataGridViewTextBoxColumn.DataPropertyName = "RDC_ID";
            this.rDCIDDataGridViewTextBoxColumn.HeaderText = "RDC_ID";
            this.rDCIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rDCIDDataGridViewTextBoxColumn.Name = "rDCIDDataGridViewTextBoxColumn";
            // 
            // locationIDDataGridViewTextBoxColumn
            // 
            this.locationIDDataGridViewTextBoxColumn.DataPropertyName = "Location_ID";
            this.locationIDDataGridViewTextBoxColumn.HeaderText = "Location_ID";
            this.locationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationIDDataGridViewTextBoxColumn.Name = "locationIDDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // commsIDDataGridViewTextBoxColumn
            // 
            this.commsIDDataGridViewTextBoxColumn.DataPropertyName = "Comms_ID";
            this.commsIDDataGridViewTextBoxColumn.HeaderText = "Comms_ID";
            this.commsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commsIDDataGridViewTextBoxColumn.Name = "commsIDDataGridViewTextBoxColumn";
            // 
            // cOMportDataGridViewTextBoxColumn
            // 
            this.cOMportDataGridViewTextBoxColumn.DataPropertyName = "COMport";
            this.cOMportDataGridViewTextBoxColumn.HeaderText = "COMport";
            this.cOMportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOMportDataGridViewTextBoxColumn.Name = "cOMportDataGridViewTextBoxColumn";
            // 
            // baudrateDataGridViewTextBoxColumn
            // 
            this.baudrateDataGridViewTextBoxColumn.DataPropertyName = "Baudrate";
            this.baudrateDataGridViewTextBoxColumn.HeaderText = "Baudrate";
            this.baudrateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baudrateDataGridViewTextBoxColumn.Name = "baudrateDataGridViewTextBoxColumn";
            // 
            // dAUBindingSource
            // 
            this.dAUBindingSource.DataMember = "DAU";
            this.dAUBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // bindingSourceSQL
            // 
            this.bindingSourceSQL.DataSource = this.softSensConfDBDataSet;
            this.bindingSourceSQL.Position = 0;
            // 
            // softSensConfDBDataSet
            // 
            this.softSensConfDBDataSet.DataSetName = "SoftSensConfDBDataSet";
            this.softSensConfDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelStatusChange
            // 
            this.labelStatusChange.AutoSize = true;
            this.labelStatusChange.Location = new System.Drawing.Point(708, 73);
            this.labelStatusChange.Name = "labelStatusChange";
            this.labelStatusChange.Size = new System.Drawing.Size(0, 24);
            this.labelStatusChange.TabIndex = 31;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(44, 26);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(252, 47);
            this.labelData.TabIndex = 18;
            this.labelData.Text = "Data Editing";
            // 
            // communicationBindingSource
            // 
            this.communicationBindingSource.DataMember = "Communication";
            this.communicationBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // rDCBindingSource
            // 
            this.rDCBindingSource.DataMember = "RDC";
            this.rDCBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // dataLogBindingSource
            // 
            this.dataLogBindingSource.DataMember = "DataLog";
            this.dataLogBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // instrumentBindingSource
            // 
            this.instrumentBindingSource.DataMember = "Instrument";
            this.instrumentBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // instrumentTypeBindingSource
            // 
            this.instrumentTypeBindingSource.DataMember = "Instrument Type";
            this.instrumentTypeBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // logIDBindingSource
            // 
            this.logIDBindingSource.DataMember = "LogID";
            this.logIDBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // communicationTableAdapter
            // 
            this.communicationTableAdapter.ClearBeforeFill = true;
            // 
            // dataLogTableAdapter
            // 
            this.dataLogTableAdapter.ClearBeforeFill = true;
            // 
            // dAUTableAdapter
            // 
            this.dAUTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentTableAdapter
            // 
            this.instrumentTableAdapter.ClearBeforeFill = true;
            // 
            // instrument_TypeTableAdapter
            // 
            this.instrument_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // logIDTableAdapter
            // 
            this.logIDTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // rDCTableAdapter
            // 
            this.rDCTableAdapter.ClearBeforeFill = true;
            // 
            // location_IDComboBox
            // 
            this.location_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Location_ID", true));
            this.location_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationBindingSource, "AreaCode", true));
            this.location_IDComboBox.DataSource = this.locationBindingSource;
            this.location_IDComboBox.DisplayMember = "AreaCode";
            this.location_IDComboBox.Enabled = false;
            this.location_IDComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_IDComboBox.FormattingEnabled = true;
            this.location_IDComboBox.Location = new System.Drawing.Point(207, 299);
            this.location_IDComboBox.Name = "location_IDComboBox";
            this.location_IDComboBox.Size = new System.Drawing.Size(172, 28);
            this.location_IDComboBox.TabIndex = 17;
            this.location_IDComboBox.ValueMember = "Location_ID";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(208, 559);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(121, 29);
            this.buttonDisconnect.TabIndex = 11;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // uRVTextBox
            // 
            this.uRVTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.uRVTextBox.Location = new System.Drawing.Point(679, 403);
            this.uRVTextBox.Name = "uRVTextBox";
            this.uRVTextBox.Size = new System.Drawing.Size(171, 26);
            this.uRVTextBox.TabIndex = 48;
            // 
            // lRVTextBox
            // 
            this.lRVTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lRVTextBox.Location = new System.Drawing.Point(679, 371);
            this.lRVTextBox.Name = "lRVTextBox";
            this.lRVTextBox.Size = new System.Drawing.Size(171, 26);
            this.lRVTextBox.TabIndex = 46;
            // 
            // rDC_IDComboBox
            // 
            this.rDC_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "RDC_ID", true));
            this.rDC_IDComboBox.DataSource = this.rDCBindingSource;
            this.rDC_IDComboBox.DisplayMember = "RDC_ID";
            this.rDC_IDComboBox.Enabled = false;
            this.rDC_IDComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDC_IDComboBox.FormattingEnabled = true;
            this.rDC_IDComboBox.Location = new System.Drawing.Point(207, 265);
            this.rDC_IDComboBox.Name = "rDC_IDComboBox";
            this.rDC_IDComboBox.Size = new System.Drawing.Size(172, 28);
            this.rDC_IDComboBox.TabIndex = 17;
            this.rDC_IDComboBox.ValueMember = "RDC_ID";
            // 
            // comms_IDComboBox
            // 
            this.comms_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Comms_ID", true));
            this.comms_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.communicationBindingSource, "CommsType", true));
            this.comms_IDComboBox.DataSource = this.communicationBindingSource;
            this.comms_IDComboBox.DisplayMember = "CommsType";
            this.comms_IDComboBox.Enabled = false;
            this.comms_IDComboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comms_IDComboBox.FormattingEnabled = true;
            this.comms_IDComboBox.Location = new System.Drawing.Point(207, 333);
            this.comms_IDComboBox.Name = "comms_IDComboBox";
            this.comms_IDComboBox.Size = new System.Drawing.Size(172, 28);
            this.comms_IDComboBox.TabIndex = 17;
            this.comms_IDComboBox.ValueMember = "Comms_ID";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(71, 559);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(121, 29);
            this.buttonConnect.TabIndex = 10;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // alarmLTextBox
            // 
            this.alarmLTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.alarmLTextBox.Location = new System.Drawing.Point(679, 435);
            this.alarmLTextBox.Name = "alarmLTextBox";
            this.alarmLTextBox.Size = new System.Drawing.Size(171, 26);
            this.alarmLTextBox.TabIndex = 50;
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.descriptionTextBox1.Location = new System.Drawing.Point(679, 339);
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(171, 26);
            this.descriptionTextBox1.TabIndex = 44;
            // 
            // labelBit
            // 
            this.labelBit.AutoSize = true;
            this.labelBit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBit.Location = new System.Drawing.Point(67, 513);
            this.labelBit.Name = "labelBit";
            this.labelBit.Size = new System.Drawing.Size(101, 23);
            this.labelBit.TabIndex = 9;
            this.labelBit.Text = "Baudrate";
            // 
            // alarmHTextBox
            // 
            this.alarmHTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.alarmHTextBox.Location = new System.Drawing.Point(679, 467);
            this.alarmHTextBox.Name = "alarmHTextBox";
            this.alarmHTextBox.Size = new System.Drawing.Size(171, 26);
            this.alarmHTextBox.TabIndex = 52;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(67, 478);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(104, 23);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "COM Port";
            // 
            // location_IDTextBox
            // 
            this.location_IDTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.location_IDTextBox.Location = new System.Drawing.Point(679, 307);
            this.location_IDTextBox.Name = "location_IDTextBox";
            this.location_IDTextBox.Size = new System.Drawing.Size(171, 26);
            this.location_IDTextBox.TabIndex = 42;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Description", true));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(207, 367);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(172, 46);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnection.Location = new System.Drawing.Point(46, 431);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(156, 30);
            this.labelConnection.TabIndex = 20;
            this.labelConnection.Text = "Connection";
            // 
            // comboBoxBit
            // 
            this.comboBoxBit.FormattingEnabled = true;
            this.comboBoxBit.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200"});
            this.comboBoxBit.Location = new System.Drawing.Point(207, 510);
            this.comboBoxBit.Name = "comboBoxBit";
            this.comboBoxBit.Size = new System.Drawing.Size(121, 32);
            this.comboBoxBit.TabIndex = 7;
            // 
            // scanFrequencyTextBox
            // 
            this.scanFrequencyTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.scanFrequencyTextBox.Location = new System.Drawing.Point(679, 499);
            this.scanFrequencyTextBox.Name = "scanFrequencyTextBox";
            this.scanFrequencyTextBox.Size = new System.Drawing.Size(171, 26);
            this.scanFrequencyTextBox.TabIndex = 54;
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.buttonChange.Location = new System.Drawing.Point(207, 177);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(83, 28);
            this.buttonChange.TabIndex = 18;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // tagnameTextBox
            // 
            this.tagnameTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tagnameTextBox.Location = new System.Drawing.Point(679, 275);
            this.tagnameTextBox.Name = "tagnameTextBox";
            this.tagnameTextBox.Size = new System.Drawing.Size(171, 26);
            this.tagnameTextBox.TabIndex = 40;
            // 
            // radioButtonConnected
            // 
            this.radioButtonConnected.AutoSize = true;
            this.radioButtonConnected.Location = new System.Drawing.Point(48, 564);
            this.radioButtonConnected.Name = "radioButtonConnected";
            this.radioButtonConnected.Size = new System.Drawing.Size(17, 16);
            this.radioButtonConnected.TabIndex = 26;
            this.radioButtonConnected.TabStop = true;
            this.radioButtonConnected.UseVisualStyleBackColor = true;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(208, 471);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 32);
            this.comboBoxPort.TabIndex = 6;
            this.comboBoxPort.Enter += new System.EventHandler(this.comboBoxPort_Enter);
            // 
            // type_IDTextBox
            // 
            this.type_IDTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.type_IDTextBox.Location = new System.Drawing.Point(679, 531);
            this.type_IDTextBox.Name = "type_IDTextBox";
            this.type_IDTextBox.Size = new System.Drawing.Size(171, 26);
            this.type_IDTextBox.TabIndex = 56;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.buttonSave.Location = new System.Drawing.Point(296, 177);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(81, 28);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // comms_IDTextBox
            // 
            this.comms_IDTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.comms_IDTextBox.Location = new System.Drawing.Point(679, 243);
            this.comms_IDTextBox.Name = "comms_IDTextBox";
            this.comms_IDTextBox.Size = new System.Drawing.Size(171, 26);
            this.comms_IDTextBox.TabIndex = 38;
            // 
            // ComboBoxFindDev
            // 
            this.ComboBoxFindDev.DisplayMember = "DAU_ID";
            this.ComboBoxFindDev.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxFindDev.FormattingEnabled = true;
            this.ComboBoxFindDev.Location = new System.Drawing.Point(207, 140);
            this.ComboBoxFindDev.Name = "ComboBoxFindDev";
            this.ComboBoxFindDev.Size = new System.Drawing.Size(172, 28);
            this.ComboBoxFindDev.TabIndex = 16;
            this.ComboBoxFindDev.ValueMember = "DAU_ID";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.buttonCancel.Location = new System.Drawing.Point(296, 211);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 28);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelHeadSetup
            // 
            this.labelHeadSetup.AutoSize = true;
            this.labelHeadSetup.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadSetup.Location = new System.Drawing.Point(59, 25);
            this.labelHeadSetup.Name = "labelHeadSetup";
            this.labelHeadSetup.Size = new System.Drawing.Size(129, 47);
            this.labelHeadSetup.TabIndex = 17;
            this.labelHeadSetup.Text = "Setup";
            // 
            // maker_IDTextBox
            // 
            this.maker_IDTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.maker_IDTextBox.Location = new System.Drawing.Point(679, 563);
            this.maker_IDTextBox.Name = "maker_IDTextBox";
            this.maker_IDTextBox.Size = new System.Drawing.Size(171, 26);
            this.maker_IDTextBox.TabIndex = 58;
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.buttonNew.Location = new System.Drawing.Point(207, 211);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(83, 28);
            this.buttonNew.TabIndex = 21;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // dAU_IDTextBox
            // 
            this.dAU_IDTextBox.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dAU_IDTextBox.Location = new System.Drawing.Point(679, 211);
            this.dAU_IDTextBox.Name = "dAU_IDTextBox";
            this.dAU_IDTextBox.Size = new System.Drawing.Size(171, 26);
            this.dAU_IDTextBox.TabIndex = 36;
            // 
            // labelDAU
            // 
            this.labelDAU.AutoSize = true;
            this.labelDAU.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDAU.Location = new System.Drawing.Point(54, 106);
            this.labelDAU.Name = "labelDAU";
            this.labelDAU.Size = new System.Drawing.Size(138, 30);
            this.labelDAU.TabIndex = 34;
            this.labelDAU.Text = "DAU Setup";
            // 
            // comboBoxFindTag
            // 
            this.comboBoxFindTag.DisplayMember = "Tagname";
            this.comboBoxFindTag.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFindTag.FormattingEnabled = true;
            this.comboBoxFindTag.Location = new System.Drawing.Point(679, 146);
            this.comboBoxFindTag.Name = "comboBoxFindTag";
            this.comboBoxFindTag.Size = new System.Drawing.Size(171, 28);
            this.comboBoxFindTag.TabIndex = 61;
            this.comboBoxFindTag.ValueMember = "Tagname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 30);
            this.label4.TabIndex = 62;
            this.label4.Text = "Instrument Setup";
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.BackColor = System.Drawing.Color.DarkGray;
            this.panelConfiguration.Controls.Add(labelError);
            this.panelConfiguration.Controls.Add(this.label4);
            this.panelConfiguration.Controls.Add(this.comboBoxFindTag);
            this.panelConfiguration.Controls.Add(this.labelDAU);
            this.panelConfiguration.Controls.Add(dAU_IDLabel1);
            this.panelConfiguration.Controls.Add(this.dAU_IDTextBox);
            this.panelConfiguration.Controls.Add(this.buttonNew);
            this.panelConfiguration.Controls.Add(this.maker_IDTextBox);
            this.panelConfiguration.Controls.Add(this.labelHeadSetup);
            this.panelConfiguration.Controls.Add(comms_IDLabel);
            this.panelConfiguration.Controls.Add(this.buttonCancel);
            this.panelConfiguration.Controls.Add(maker_IDLabel);
            this.panelConfiguration.Controls.Add(this.ComboBoxFindDev);
            this.panelConfiguration.Controls.Add(this.comms_IDTextBox);
            this.panelConfiguration.Controls.Add(this.buttonSave);
            this.panelConfiguration.Controls.Add(this.type_IDTextBox);
            this.panelConfiguration.Controls.Add(this.comboBoxPort);
            this.panelConfiguration.Controls.Add(tagnameLabel);
            this.panelConfiguration.Controls.Add(this.radioButtonConnected);
            this.panelConfiguration.Controls.Add(type_IDLabel);
            this.panelConfiguration.Controls.Add(descriptionLabel);
            this.panelConfiguration.Controls.Add(this.tagnameTextBox);
            this.panelConfiguration.Controls.Add(this.buttonChange);
            this.panelConfiguration.Controls.Add(this.scanFrequencyTextBox);
            this.panelConfiguration.Controls.Add(this.comboBoxBit);
            this.panelConfiguration.Controls.Add(location_IDLabel1);
            this.panelConfiguration.Controls.Add(this.labelConnection);
            this.panelConfiguration.Controls.Add(scanFrequencyLabel);
            this.panelConfiguration.Controls.Add(this.descriptionTextBox);
            this.panelConfiguration.Controls.Add(this.location_IDTextBox);
            this.panelConfiguration.Controls.Add(this.labelPort);
            this.panelConfiguration.Controls.Add(this.alarmHTextBox);
            this.panelConfiguration.Controls.Add(this.labelBit);
            this.panelConfiguration.Controls.Add(descriptionLabel1);
            this.panelConfiguration.Controls.Add(comms_IDLabel1);
            this.panelConfiguration.Controls.Add(alarmHLabel);
            this.panelConfiguration.Controls.Add(dAU_IDLabel);
            this.panelConfiguration.Controls.Add(this.descriptionTextBox1);
            this.panelConfiguration.Controls.Add(location_IDLabel);
            this.panelConfiguration.Controls.Add(this.alarmLTextBox);
            this.panelConfiguration.Controls.Add(this.buttonConnect);
            this.panelConfiguration.Controls.Add(lRVLabel);
            this.panelConfiguration.Controls.Add(this.comms_IDComboBox);
            this.panelConfiguration.Controls.Add(alarmLLabel);
            this.panelConfiguration.Controls.Add(this.rDC_IDComboBox);
            this.panelConfiguration.Controls.Add(this.lRVTextBox);
            this.panelConfiguration.Controls.Add(rDC_IDLabel1);
            this.panelConfiguration.Controls.Add(this.uRVTextBox);
            this.panelConfiguration.Controls.Add(this.buttonDisconnect);
            this.panelConfiguration.Controls.Add(uRVLabel);
            this.panelConfiguration.Controls.Add(this.location_IDComboBox);
            this.panelConfiguration.Location = new System.Drawing.Point(198, 1);
            this.panelConfiguration.Name = "panelConfiguration";
            this.panelConfiguration.Size = new System.Drawing.Size(893, 604);
            this.panelConfiguration.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1091, 605);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelConfiguration);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensConfDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            this.panelConfiguration.ResumeLayout(false);
            this.panelConfiguration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.Button buttonConfiguration;
        private System.Windows.Forms.Panel panelPick;
        private System.Windows.Forms.Panel panelData;
        private System.IO.Ports.SerialPort serialPortMain;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelStatusChange;
        private System.Windows.Forms.BindingSource bindingSourceSQL;
        private SoftSensConfDBDataSet softSensConfDBDataSet;
        private System.Windows.Forms.BindingSource communicationBindingSource;
        private SoftSensConfDBDataSetTableAdapters.CommunicationTableAdapter communicationTableAdapter;
        private System.Windows.Forms.BindingSource dataLogBindingSource;
        private SoftSensConfDBDataSetTableAdapters.DataLogTableAdapter dataLogTableAdapter;
        private System.Windows.Forms.BindingSource dAUBindingSource;
        private SoftSensConfDBDataSetTableAdapters.DAUTableAdapter dAUTableAdapter;
        private System.Windows.Forms.BindingSource instrumentBindingSource;
        private SoftSensConfDBDataSetTableAdapters.InstrumentTableAdapter instrumentTableAdapter;
        private System.Windows.Forms.BindingSource instrumentTypeBindingSource;
        private SoftSensConfDBDataSetTableAdapters.Instrument_TypeTableAdapter instrument_TypeTableAdapter;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private SoftSensConfDBDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource logIDBindingSource;
        private SoftSensConfDBDataSetTableAdapters.LogIDTableAdapter logIDTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private SoftSensConfDBDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource rDCBindingSource;
        private SoftSensConfDBDataSetTableAdapters.RDCTableAdapter rDCTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button buttonManufacturerGrid;
        private System.Windows.Forms.Button buttonLocationGrid;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baudrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonCommsTypesGrid;
        private System.Windows.Forms.Button buttonRDCGrid;
        private System.Windows.Forms.Button buttonDAUGrid;
        private System.Windows.Forms.Button buttonInstrumentTypesGrid;
        private System.Windows.Forms.Button buttonInstrumentGrid;
        private System.Windows.Forms.Button buttonDataLogGrid;
        private System.Windows.Forms.Button buttonLogIDGrid;
        private System.Windows.Forms.ComboBox location_IDComboBox;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox uRVTextBox;
        private System.Windows.Forms.TextBox lRVTextBox;
        private System.Windows.Forms.ComboBox rDC_IDComboBox;
        private System.Windows.Forms.ComboBox comms_IDComboBox;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox alarmLTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox1;
        private System.Windows.Forms.Label labelBit;
        private System.Windows.Forms.TextBox alarmHTextBox;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox location_IDTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.ComboBox comboBoxBit;
        private System.Windows.Forms.TextBox scanFrequencyTextBox;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox tagnameTextBox;
        private System.Windows.Forms.RadioButton radioButtonConnected;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.TextBox type_IDTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox comms_IDTextBox;
        private System.Windows.Forms.ComboBox ComboBoxFindDev;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelHeadSetup;
        private System.Windows.Forms.TextBox maker_IDTextBox;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox dAU_IDTextBox;
        private System.Windows.Forms.Label labelDAU;
        private System.Windows.Forms.ComboBox comboBoxFindTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelConfiguration;
    }
}

