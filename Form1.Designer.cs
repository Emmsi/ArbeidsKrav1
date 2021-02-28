
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelPick = new System.Windows.Forms.Panel();
            this.buttonConfiguration = new System.Windows.Forms.Button();
            this.buttonData = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.labelStatusChange = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tabControlGraph = new System.Windows.Forms.TabControl();
            this.tabPageRaw = new System.Windows.Forms.TabPage();
            this.buttonSaveDataRaw = new System.Windows.Forms.Button();
            this.textBoxDataRaw = new System.Windows.Forms.TextBox();
            this.buttonStopAutoRaw = new System.Windows.Forms.Button();
            this.buttonStartAutoRaw = new System.Windows.Forms.Button();
            this.chartRaw = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageScaled = new System.Windows.Forms.TabPage();
            this.buttonSaveDataScaled = new System.Windows.Forms.Button();
            this.buttonStopAutoScaled = new System.Windows.Forms.Button();
            this.buttonStartAutoScaled = new System.Windows.Forms.Button();
            this.textBoxDataScaled = new System.Windows.Forms.TextBox();
            this.chartScaled = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelData = new System.Windows.Forms.Label();
            this.panelConfiguration = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.buttonPassword = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelSerial = new System.Windows.Forms.Label();
            this.labelCommand = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelAH = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.labelAL = new System.Windows.Forms.Label();
            this.textBoxAH = new System.Windows.Forms.TextBox();
            this.textBoxAL = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxTagname = new System.Windows.Forms.TextBox();
            this.radioButtonConnected = new System.Windows.Forms.RadioButton();
            this.labelTagname = new System.Windows.Forms.Label();
            this.labelLRV = new System.Windows.Forms.Label();
            this.labelConfiguration = new System.Windows.Forms.Label();
            this.labelConnection = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelHeadSetup = new System.Windows.Forms.Label();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelBit = new System.Windows.Forms.Label();
            this.comboBoxBit = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.serialPortMain = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogConfig = new System.Windows.Forms.SaveFileDialog();
            this.timerSerialReceiveRaw = new System.Windows.Forms.Timer(this.components);
            this.timerChartAddRaw = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogData = new System.Windows.Forms.SaveFileDialog();
            this.timerSerialReceiveScaled = new System.Windows.Forms.Timer(this.components);
            this.timerChartAddScaled = new System.Windows.Forms.Timer(this.components);
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelDashboard.SuspendLayout();
            this.panelData.SuspendLayout();
            this.tabControlGraph.SuspendLayout();
            this.tabPageRaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRaw)).BeginInit();
            this.tabPageScaled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartScaled)).BeginInit();
            this.panelConfiguration.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.SuspendLayout();
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
            this.buttonData.Text = "Monitoring";
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
            this.buttonDashboard.Text = "Dashboard";
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
            this.panelDashboard.Controls.Add(this.label11);
            this.panelDashboard.Location = new System.Drawing.Point(197, 4);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(891, 595);
            this.panelDashboard.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 47);
            this.label11.TabIndex = 17;
            this.label11.Text = "Dashboard";
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.DarkGray;
            this.panelData.Controls.Add(this.labelStatusChange);
            this.panelData.Controls.Add(this.labelStatus);
            this.panelData.Controls.Add(this.tabControlGraph);
            this.panelData.Controls.Add(this.labelData);
            this.panelData.Location = new System.Drawing.Point(197, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(897, 605);
            this.panelData.TabIndex = 2;
            // 
            // labelStatusChange
            // 
            this.labelStatusChange.AutoSize = true;
            this.labelStatusChange.Location = new System.Drawing.Point(708, 73);
            this.labelStatusChange.Name = "labelStatusChange";
            this.labelStatusChange.Size = new System.Drawing.Size(0, 24);
            this.labelStatusChange.TabIndex = 31;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(629, 71);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(73, 29);
            this.labelStatus.TabIndex = 30;
            this.labelStatus.Text = "Status:";
            // 
            // tabControlGraph
            // 
            this.tabControlGraph.Controls.Add(this.tabPageRaw);
            this.tabControlGraph.Controls.Add(this.tabPageScaled);
            this.tabControlGraph.Location = new System.Drawing.Point(34, 111);
            this.tabControlGraph.Name = "tabControlGraph";
            this.tabControlGraph.SelectedIndex = 0;
            this.tabControlGraph.Size = new System.Drawing.Size(831, 468);
            this.tabControlGraph.TabIndex = 22;
            // 
            // tabPageRaw
            // 
            this.tabPageRaw.Controls.Add(this.buttonSaveDataRaw);
            this.tabPageRaw.Controls.Add(this.textBoxDataRaw);
            this.tabPageRaw.Controls.Add(this.buttonStopAutoRaw);
            this.tabPageRaw.Controls.Add(this.buttonStartAutoRaw);
            this.tabPageRaw.Controls.Add(this.chartRaw);
            this.tabPageRaw.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageRaw.Location = new System.Drawing.Point(4, 33);
            this.tabPageRaw.Name = "tabPageRaw";
            this.tabPageRaw.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRaw.Size = new System.Drawing.Size(823, 431);
            this.tabPageRaw.TabIndex = 0;
            this.tabPageRaw.Text = "Raw Data";
            this.tabPageRaw.UseVisualStyleBackColor = true;
            // 
            // buttonSaveDataRaw
            // 
            this.buttonSaveDataRaw.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveDataRaw.Location = new System.Drawing.Point(697, 318);
            this.buttonSaveDataRaw.Name = "buttonSaveDataRaw";
            this.buttonSaveDataRaw.Size = new System.Drawing.Size(96, 32);
            this.buttonSaveDataRaw.TabIndex = 25;
            this.buttonSaveDataRaw.Text = "Save";
            this.buttonSaveDataRaw.UseVisualStyleBackColor = true;
            this.buttonSaveDataRaw.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // textBoxDataRaw
            // 
            this.textBoxDataRaw.Location = new System.Drawing.Point(595, 93);
            this.textBoxDataRaw.Multiline = true;
            this.textBoxDataRaw.Name = "textBoxDataRaw";
            this.textBoxDataRaw.ReadOnly = true;
            this.textBoxDataRaw.Size = new System.Drawing.Size(199, 171);
            this.textBoxDataRaw.TabIndex = 23;
            // 
            // buttonStopAutoRaw
            // 
            this.buttonStopAutoRaw.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopAutoRaw.Location = new System.Drawing.Point(595, 318);
            this.buttonStopAutoRaw.Name = "buttonStopAutoRaw";
            this.buttonStopAutoRaw.Size = new System.Drawing.Size(96, 32);
            this.buttonStopAutoRaw.TabIndex = 24;
            this.buttonStopAutoRaw.Text = "Stop Auto";
            this.buttonStopAutoRaw.UseVisualStyleBackColor = true;
            this.buttonStopAutoRaw.Click += new System.EventHandler(this.buttonStopAuto_Click);
            // 
            // buttonStartAutoRaw
            // 
            this.buttonStartAutoRaw.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartAutoRaw.Location = new System.Drawing.Point(595, 278);
            this.buttonStartAutoRaw.Name = "buttonStartAutoRaw";
            this.buttonStartAutoRaw.Size = new System.Drawing.Size(96, 34);
            this.buttonStartAutoRaw.TabIndex = 22;
            this.buttonStartAutoRaw.Text = "Start Auto";
            this.buttonStartAutoRaw.UseVisualStyleBackColor = true;
            this.buttonStartAutoRaw.Click += new System.EventHandler(this.buttonAutoGraph_Click);
            // 
            // chartRaw
            // 
            chartArea5.Name = "ChartArea1";
            this.chartRaw.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartRaw.Legends.Add(legend5);
            this.chartRaw.Location = new System.Drawing.Point(2, 57);
            this.chartRaw.Name = "chartRaw";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Raw Data";
            this.chartRaw.Series.Add(series5);
            this.chartRaw.Size = new System.Drawing.Size(587, 316);
            this.chartRaw.TabIndex = 0;
            this.chartRaw.Text = "chartMain";
            // 
            // tabPageScaled
            // 
            this.tabPageScaled.Controls.Add(this.buttonSaveDataScaled);
            this.tabPageScaled.Controls.Add(this.buttonStopAutoScaled);
            this.tabPageScaled.Controls.Add(this.buttonStartAutoScaled);
            this.tabPageScaled.Controls.Add(this.textBoxDataScaled);
            this.tabPageScaled.Controls.Add(this.chartScaled);
            this.tabPageScaled.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageScaled.Location = new System.Drawing.Point(4, 25);
            this.tabPageScaled.Name = "tabPageScaled";
            this.tabPageScaled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScaled.Size = new System.Drawing.Size(823, 439);
            this.tabPageScaled.TabIndex = 1;
            this.tabPageScaled.Text = "Scaled Data";
            this.tabPageScaled.UseVisualStyleBackColor = true;
            // 
            // buttonSaveDataScaled
            // 
            this.buttonSaveDataScaled.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveDataScaled.Location = new System.Drawing.Point(697, 318);
            this.buttonSaveDataScaled.Name = "buttonSaveDataScaled";
            this.buttonSaveDataScaled.Size = new System.Drawing.Size(96, 32);
            this.buttonSaveDataScaled.TabIndex = 29;
            this.buttonSaveDataScaled.Text = "Save";
            this.buttonSaveDataScaled.UseVisualStyleBackColor = true;
            this.buttonSaveDataScaled.Click += new System.EventHandler(this.buttonSaveDataScaled_Click);
            // 
            // buttonStopAutoScaled
            // 
            this.buttonStopAutoScaled.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopAutoScaled.Location = new System.Drawing.Point(595, 318);
            this.buttonStopAutoScaled.Name = "buttonStopAutoScaled";
            this.buttonStopAutoScaled.Size = new System.Drawing.Size(96, 32);
            this.buttonStopAutoScaled.TabIndex = 28;
            this.buttonStopAutoScaled.Text = "Stop Auto";
            this.buttonStopAutoScaled.UseVisualStyleBackColor = true;
            this.buttonStopAutoScaled.Click += new System.EventHandler(this.buttonStopAutoScaled_Click);
            // 
            // buttonStartAutoScaled
            // 
            this.buttonStartAutoScaled.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartAutoScaled.Location = new System.Drawing.Point(595, 278);
            this.buttonStartAutoScaled.Name = "buttonStartAutoScaled";
            this.buttonStartAutoScaled.Size = new System.Drawing.Size(96, 34);
            this.buttonStartAutoScaled.TabIndex = 27;
            this.buttonStartAutoScaled.Text = "Start Auto";
            this.buttonStartAutoScaled.UseVisualStyleBackColor = true;
            this.buttonStartAutoScaled.Click += new System.EventHandler(this.buttonAutoGraphScaled_Click);
            // 
            // textBoxDataScaled
            // 
            this.textBoxDataScaled.Location = new System.Drawing.Point(595, 93);
            this.textBoxDataScaled.Multiline = true;
            this.textBoxDataScaled.Name = "textBoxDataScaled";
            this.textBoxDataScaled.ReadOnly = true;
            this.textBoxDataScaled.Size = new System.Drawing.Size(199, 171);
            this.textBoxDataScaled.TabIndex = 23;
            // 
            // chartScaled
            // 
            chartArea6.Name = "ChartArea1";
            this.chartScaled.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartScaled.Legends.Add(legend6);
            this.chartScaled.Location = new System.Drawing.Point(2, 57);
            this.chartScaled.Name = "chartScaled";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Scaled Data";
            this.chartScaled.Series.Add(series6);
            this.chartScaled.Size = new System.Drawing.Size(587, 316);
            this.chartScaled.TabIndex = 1;
            this.chartScaled.Text = "chartMain";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(44, 26);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(333, 47);
            this.labelData.TabIndex = 18;
            this.labelData.Text = "Graph and Data";
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.BackColor = System.Drawing.Color.DarkGray;
            this.panelConfiguration.Controls.Add(this.panelPassword);
            this.panelConfiguration.Controls.Add(this.labelSerial);
            this.panelConfiguration.Controls.Add(this.labelCommand);
            this.panelConfiguration.Controls.Add(this.buttonLoad);
            this.panelConfiguration.Controls.Add(this.labelAH);
            this.panelConfiguration.Controls.Add(this.labelURV);
            this.panelConfiguration.Controls.Add(this.labelAL);
            this.panelConfiguration.Controls.Add(this.textBoxAH);
            this.panelConfiguration.Controls.Add(this.textBoxAL);
            this.panelConfiguration.Controls.Add(this.textBoxLRV);
            this.panelConfiguration.Controls.Add(this.textBoxURV);
            this.panelConfiguration.Controls.Add(this.textBoxTagname);
            this.panelConfiguration.Controls.Add(this.radioButtonConnected);
            this.panelConfiguration.Controls.Add(this.labelTagname);
            this.panelConfiguration.Controls.Add(this.labelLRV);
            this.panelConfiguration.Controls.Add(this.labelConfiguration);
            this.panelConfiguration.Controls.Add(this.labelConnection);
            this.panelConfiguration.Controls.Add(this.labelPort);
            this.panelConfiguration.Controls.Add(this.buttonSave);
            this.panelConfiguration.Controls.Add(this.buttonUpdate);
            this.panelConfiguration.Controls.Add(this.labelHeadSetup);
            this.panelConfiguration.Controls.Add(this.buttonReceive);
            this.panelConfiguration.Controls.Add(this.buttonSend);
            this.panelConfiguration.Controls.Add(this.textBoxSend);
            this.panelConfiguration.Controls.Add(this.textBoxResult);
            this.panelConfiguration.Controls.Add(this.buttonDisconnect);
            this.panelConfiguration.Controls.Add(this.buttonConnect);
            this.panelConfiguration.Controls.Add(this.labelBit);
            this.panelConfiguration.Controls.Add(this.comboBoxBit);
            this.panelConfiguration.Controls.Add(this.comboBoxPort);
            this.panelConfiguration.Location = new System.Drawing.Point(198, 1);
            this.panelConfiguration.Name = "panelConfiguration";
            this.panelConfiguration.Size = new System.Drawing.Size(893, 604);
            this.panelConfiguration.TabIndex = 3;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.buttonPassword);
            this.panelPassword.Controls.Add(this.labelPassword);
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Location = new System.Drawing.Point(635, 432);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(200, 113);
            this.panelPassword.TabIndex = 39;
            this.panelPassword.Visible = false;
            // 
            // buttonPassword
            // 
            this.buttonPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPassword.Location = new System.Drawing.Point(54, 73);
            this.buttonPassword.Name = "buttonPassword";
            this.buttonPassword.Size = new System.Drawing.Size(99, 29);
            this.buttonPassword.TabIndex = 40;
            this.buttonPassword.Text = "Confirm";
            this.buttonPassword.UseVisualStyleBackColor = true;
            this.buttonPassword.Click += new System.EventHandler(this.buttonPassword_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(50, 11);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(103, 23);
            this.labelPassword.TabIndex = 38;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(26, 37);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(146, 30);
            this.textBoxPassword.TabIndex = 0;
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerial.Location = new System.Drawing.Point(508, 110);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(280, 30);
            this.labelSerial.TabIndex = 38;
            this.labelSerial.Text = "Serial Communication";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommand.Location = new System.Drawing.Point(509, 163);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(117, 23);
            this.labelCommand.TabIndex = 37;
            this.labelCommand.Text = "Command";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(122, 526);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(83, 29);
            this.buttonLoad.TabIndex = 35;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // labelAH
            // 
            this.labelAH.AutoSize = true;
            this.labelAH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAH.Location = new System.Drawing.Point(53, 493);
            this.labelAH.Name = "labelAH";
            this.labelAH.Size = new System.Drawing.Size(117, 23);
            this.labelAH.TabIndex = 34;
            this.labelAH.Text = "Alarm High";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURV.Location = new System.Drawing.Point(53, 421);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(197, 23);
            this.labelURV.TabIndex = 32;
            this.labelURV.Text = "Upper range value";
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAL.Location = new System.Drawing.Point(53, 454);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(115, 23);
            this.labelAL.TabIndex = 33;
            this.labelAL.Text = "Alarm Low";
            // 
            // textBoxAH
            // 
            this.textBoxAH.Location = new System.Drawing.Point(267, 490);
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(119, 30);
            this.textBoxAH.TabIndex = 31;
            // 
            // textBoxAL
            // 
            this.textBoxAL.Location = new System.Drawing.Point(267, 454);
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(119, 30);
            this.textBoxAL.TabIndex = 30;
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(266, 382);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(119, 30);
            this.textBoxLRV.TabIndex = 29;
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(267, 418);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(119, 30);
            this.textBoxURV.TabIndex = 28;
            // 
            // textBoxTagname
            // 
            this.textBoxTagname.Location = new System.Drawing.Point(267, 346);
            this.textBoxTagname.Name = "textBoxTagname";
            this.textBoxTagname.Size = new System.Drawing.Size(119, 30);
            this.textBoxTagname.TabIndex = 27;
            // 
            // radioButtonConnected
            // 
            this.radioButtonConnected.AutoSize = true;
            this.radioButtonConnected.Location = new System.Drawing.Point(45, 244);
            this.radioButtonConnected.Name = "radioButtonConnected";
            this.radioButtonConnected.Size = new System.Drawing.Size(17, 16);
            this.radioButtonConnected.TabIndex = 26;
            this.radioButtonConnected.TabStop = true;
            this.radioButtonConnected.UseVisualStyleBackColor = true;
            // 
            // labelTagname
            // 
            this.labelTagname.AutoSize = true;
            this.labelTagname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagname.Location = new System.Drawing.Point(54, 349);
            this.labelTagname.Name = "labelTagname";
            this.labelTagname.Size = new System.Drawing.Size(103, 23);
            this.labelTagname.TabIndex = 24;
            this.labelTagname.Text = "Tagname";
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLRV.Location = new System.Drawing.Point(54, 382);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(196, 23);
            this.labelLRV.TabIndex = 25;
            this.labelLRV.Text = "Lower range value";
            // 
            // labelConfiguration
            // 
            this.labelConfiguration.AutoSize = true;
            this.labelConfiguration.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfiguration.Location = new System.Drawing.Point(48, 301);
            this.labelConfiguration.Name = "labelConfiguration";
            this.labelConfiguration.Size = new System.Drawing.Size(177, 30);
            this.labelConfiguration.TabIndex = 21;
            this.labelConfiguration.Text = "Configuration";
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnection.Location = new System.Drawing.Point(53, 110);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(156, 30);
            this.labelConnection.TabIndex = 20;
            this.labelConnection.Text = "Connection";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(64, 158);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(104, 23);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "COM Port";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(211, 526);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 29);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(301, 526);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 29);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonOpen_Click);
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
            // buttonReceive
            // 
            this.buttonReceive.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceive.Location = new System.Drawing.Point(734, 201);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(101, 29);
            this.buttonReceive.TabIndex = 16;
            this.buttonReceive.Text = "Receive";
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(632, 201);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(101, 29);
            this.buttonSend.TabIndex = 15;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(632, 160);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(203, 30);
            this.textBoxSend.TabIndex = 14;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(632, 260);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(203, 152);
            this.textBoxResult.TabIndex = 13;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(205, 239);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(121, 29);
            this.buttonDisconnect.TabIndex = 11;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(68, 239);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(121, 29);
            this.buttonConnect.TabIndex = 10;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelBit
            // 
            this.labelBit.AutoSize = true;
            this.labelBit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBit.Location = new System.Drawing.Point(64, 193);
            this.labelBit.Name = "labelBit";
            this.labelBit.Size = new System.Drawing.Size(101, 23);
            this.labelBit.TabIndex = 9;
            this.labelBit.Text = "Baudrate";
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
            this.comboBoxBit.Location = new System.Drawing.Point(204, 190);
            this.comboBoxBit.Name = "comboBoxBit";
            this.comboBoxBit.Size = new System.Drawing.Size(121, 32);
            this.comboBoxBit.TabIndex = 7;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(205, 151);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 32);
            this.comboBoxPort.TabIndex = 6;
            this.comboBoxPort.Enter += new System.EventHandler(this.comboBoxPort_Enter);
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "openFileDialogMain";
            // 
            // timerSerialReceiveRaw
            // 
            this.timerSerialReceiveRaw.Tick += new System.EventHandler(this.timerSerialReceive_Tick);
            // 
            // timerChartAddRaw
            // 
            this.timerChartAddRaw.Interval = 1000;
            this.timerChartAddRaw.Tick += new System.EventHandler(this.timerChartAdd_Tick);
            // 
            // timerSerialReceiveScaled
            // 
            this.timerSerialReceiveScaled.Tick += new System.EventHandler(this.timerSerialReceiveScaled_Tick);
            // 
            // timerChartAddScaled
            // 
            this.timerChartAddScaled.Interval = 1000;
            this.timerChartAddScaled.Tick += new System.EventHandler(this.timerChartAddScaled_Tick);
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 10000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1091, 605);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelConfiguration);
            this.Controls.Add(this.panelDashboard);
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
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.tabControlGraph.ResumeLayout(false);
            this.tabPageRaw.ResumeLayout(false);
            this.tabPageRaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRaw)).EndInit();
            this.tabPageScaled.ResumeLayout(false);
            this.tabPageScaled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartScaled)).EndInit();
            this.panelConfiguration.ResumeLayout(false);
            this.panelConfiguration.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
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
        private System.Windows.Forms.Panel panelConfiguration;
        private System.Windows.Forms.Label labelBit;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxBit;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.IO.Ports.SerialPort serialPortMain;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Label labelHeadSetup;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialogConfig;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRaw;
        private System.Windows.Forms.Timer timerSerialReceiveRaw;
        private System.Windows.Forms.Timer timerChartAddRaw;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.SaveFileDialog saveFileDialogData;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Label labelTagname;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.Label labelConfiguration;
        private System.Windows.Forms.RadioButton radioButtonConnected;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.TextBox textBoxAH;
        private System.Windows.Forms.TextBox textBoxAL;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxTagname;
        private System.Windows.Forms.Label labelAH;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonPassword;
        private System.Windows.Forms.TabControl tabControlGraph;
        private System.Windows.Forms.TabPage tabPageRaw;
        private System.Windows.Forms.TabPage tabPageScaled;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScaled;
        private System.Windows.Forms.Button buttonSaveDataRaw;
        private System.Windows.Forms.TextBox textBoxDataRaw;
        private System.Windows.Forms.Button buttonStopAutoRaw;
        private System.Windows.Forms.Button buttonStartAutoRaw;
        private System.Windows.Forms.TextBox textBoxDataScaled;
        private System.Windows.Forms.Button buttonSaveDataScaled;
        private System.Windows.Forms.Button buttonStopAutoScaled;
        private System.Windows.Forms.Button buttonStartAutoScaled;
        private System.Windows.Forms.Timer timerSerialReceiveScaled;
        private System.Windows.Forms.Timer timerChartAddScaled;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Label labelStatusChange;
        private System.Windows.Forms.Label labelStatus;
    }
}

