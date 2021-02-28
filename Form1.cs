using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArbeidsKrav1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // Global Variables
        string[] instrumentConfigs;
        List<MeasurementPointRaw> allMeasuredPointsRaw = new List<MeasurementPointRaw>();
        List<MeasurementPointScaled> allMeasuredPointsScaled = new List<MeasurementPointScaled>();

        // Form Layout
        private void FormMain_Load(object sender, EventArgs e)
        {
            instrumentConfigs = new string[5];
            panelDashboard.Visible = true;
            panelData.Visible = false;
            panelConfiguration.Visible = false;
 
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelPick.Height = buttonDashboard.Height;
            panelPick.Top = buttonDashboard.Top;

            panelDashboard.Visible = true;
            panelData.Visible = false;
            panelConfiguration.Visible = false;

            timerStatus.Enabled = false;
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            panelPick.Height = buttonData.Height;
            panelPick.Top = buttonData.Top;

            panelDashboard.Visible = false;
            panelData.Visible = true;
            panelConfiguration.Visible = false;

            timerStatus.Enabled = true;
        }

        private void buttonSetup_Click(object sender, EventArgs e)
        {
            panelPick.Height = buttonConfiguration.Height;
            panelPick.Top = buttonConfiguration.Top;

            panelDashboard.Visible = false;
            panelData.Visible = false;
            panelConfiguration.Visible = true;

            timerStatus.Enabled = false;
        }

        // CONFIGURATION PANEL
        // Setup
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortMain.PortName = comboBoxPort.Text;
                serialPortMain.BaudRate = Convert.ToInt32(comboBoxBit.Text);

                serialPortMain.Open();
                radioButtonConnected.Checked = true;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Unable to connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButtonConnected.Checked = false;
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                radioButtonConnected.Checked = false;
                serialPortMain.Close();
            }
        }

        // COM Port
        private void comboBoxPort_Enter(object sender, EventArgs e)
        {
            comboBoxPort.Items.Clear();
            string[] ComPorts = System.IO.Ports.SerialPort.GetPortNames();

            foreach (string s in ComPorts)
            {
                comboBoxPort.Items.Add(s);
            }
        }

        // Receive
        private void buttonReceive_Click(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                textBoxResult.Clear();

                // string writeString = "writeconf>" + passwordString + ">" + textBoxTagname.Text + ";" + textBoxLRV.Text + ";" + textBoxURV.Text + ";" + textBoxAL.Text + ";" + textBoxAH.Text + ";";

                string indata = serialPortMain.ReadExisting();
                textBoxResult.AppendText(indata);

                if (textBoxSend.Text == "readconf" && textBoxResult.Text.Length <= 30 && textBoxResult.Text.Length >= 16)
                {
                    MessageBox.Show("Configuration received");
                }

                else if (textBoxSend.Text == "readconf" && textBoxResult.Text.Length < 16 || textBoxSend.Text == "readconf" && textBoxResult.Text.Length > 30)
                {
                    textBoxResult.Clear();
                    MessageBox.Show("Error receiving configuration");
                }

                else if (textBoxSend.Text.Contains("writeconf"))
                {
                    if (indata == "1")
                    {
                        MessageBox.Show("Password is correct. Configuration has been updated");
                    }

                    if (indata == "0")
                    {
                        MessageBox.Show("Password is incorrect. Please try again");
                    }
                }

                textBoxSend.Clear();
                serialPortMain.DiscardInBuffer();
                serialPortMain.DiscardOutBuffer();

            }
        }

        // Send
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                serialPortMain.WriteLine(textBoxSend.Text);

                if (textBoxSend.Text.Contains("writeconf"))
                {
                    panelPassword.Visible = true;
                }
            }
        }

        // Update Config
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < instrumentConfigs.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (textBoxTagname.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxTagname.Focus();
                        }
                        break;
                    case 1:
                        if (textBoxLRV.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxLRV.Focus();
                        }
                        break;

                    case 2:
                        if (textBoxURV.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxURV.Focus();
                        }
                        break;
                    case 3:
                        if (textBoxAL.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxAL.Focus();
                        }
                        break;
                    case 4:
                        if (textBoxAH.Text == "")
                        {
                            MessageBox.Show("Configuration empty");
                            textBoxAH.Focus();
                        }
                        break;

                    default:
                        instrumentConfigs[i] = textBoxTagname.Text;
                        instrumentConfigs[i] = textBoxLRV.Text;
                        instrumentConfigs[i] = textBoxURV.Text;
                        instrumentConfigs[i] = textBoxAL.Text;
                        instrumentConfigs[i] = textBoxAH.Text;
                        break;
                }
            }
        }

        // Save Config
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            // Open directory 
            saveFileDialogConfig.InitialDirectory = @"C:\Users\";
            saveFileDialogConfig.Filter = "ssc files (*.ssc)|*.ssc|All files (*.*)|*.*";
            saveFileDialogConfig.FilterIndex = 2;
            saveFileDialogConfig.RestoreDirectory = true;
            saveFileDialogConfig.FileName = "configuration.ssc";

            // Default save as txt
            saveFileDialogConfig.DefaultExt = "*.ssc";

            if (saveFileDialogConfig.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogConfig.FileName, textBoxTagname.Text + ";" + textBoxLRV.Text
                                      + ";" + textBoxURV.Text + ";" + textBoxAL.Text + ";" + textBoxAH.Text + ";");
            }
        }



        // GRAF OG DATA
        private void buttonAutoGraph_Click(object sender, EventArgs e)
        {
            timerChartAddRaw.Enabled = true;
        }

        private void buttonAutoGraphScaled_Click(object sender, EventArgs e)
        {
            timerChartAddScaled.Enabled = true;
        }

        private void timerChartAdd_Tick(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                serialPortMain.WriteLine("readraw");

                timerSerialReceiveRaw.Enabled = true;
                timerChartAddRaw.Enabled = false;
            }
        }

        private void timerChartAddScaled_Tick(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                serialPortMain.WriteLine("readscaled");

                timerSerialReceiveScaled.Enabled = true;
                timerChartAddScaled.Enabled = false;
            }
        }

        private void timerSerialReceive_Tick(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                if (serialPortMain.BytesToRead > 0)
                {
                    string rawData = serialPortMain.ReadExisting();
                    textBoxDataRaw.AppendText(rawData + "\r\n");

                    MeasurementPointRaw measuredPoint;
                    measuredPoint = new MeasurementPointRaw(DateTime.Now.ToLongTimeString(), int.Parse(rawData));

                    chartRaw.Series[0].Points.AddXY(measuredPoint.time, measuredPoint.raw);
                    allMeasuredPointsRaw.Add(measuredPoint);

                    timerChartAddRaw.Enabled = true;
                    timerSerialReceiveRaw.Enabled = false;
                }
            }
        }

        private void timerSerialReceiveScaled_Tick(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                if (serialPortMain.BytesToRead > 0)
                {
                    string scaledData = serialPortMain.ReadExisting();
                    textBoxDataScaled.AppendText(scaledData + "\r\n");

                    MeasurementPointScaled MeasuredPoint;
                    MeasuredPoint = new MeasurementPointScaled(DateTime.Now.ToLongTimeString(), Convert.ToDouble(scaledData.Replace(".", ",")));

                    chartScaled.Series[0].Points.AddXY(MeasuredPoint.time, MeasuredPoint.scaled);
                    allMeasuredPointsScaled.Add(MeasuredPoint);

                    timerChartAddScaled.Enabled = true;
                    timerSerialReceiveScaled.Enabled = false;
                }
            }
        }

        private void buttonStopAuto_Click(object sender, EventArgs e)
        {
            timerSerialReceiveRaw.Enabled = false;
            timerChartAddRaw.Enabled = false;

            serialPortMain.DiscardInBuffer();
            serialPortMain.DiscardOutBuffer();
        }

        private void buttonStopAutoScaled_Click(object sender, EventArgs e)
        {
            timerSerialReceiveScaled.Enabled = false;
            timerChartAddScaled.Enabled = false;

            serialPortMain.DiscardInBuffer();
            serialPortMain.DiscardOutBuffer();
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            // Open directory 
            saveFileDialogData.InitialDirectory = @"C:\Users\";
            saveFileDialogData.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialogData.FilterIndex = 2;
            saveFileDialogData.RestoreDirectory = true;
            saveFileDialogData.FileName = "rawdata.csv";

            // Default save as txt
            saveFileDialogData.DefaultExt = "*.csv";

            if (saveFileDialogData.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWritePoints = new StreamWriter(saveFileDialogData.FileName))

                    foreach (MeasurementPointRaw point in allMeasuredPointsRaw)
                    {
                        streamWritePoints.WriteLine(point.ToString());
                    }
            }
        }

        private void buttonSaveDataScaled_Click(object sender, EventArgs e)
        {
            // Open directory 
            saveFileDialogData.InitialDirectory = @"C:\Users\";
            saveFileDialogData.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialogData.FilterIndex = 2;
            saveFileDialogData.RestoreDirectory = true;
            saveFileDialogData.FileName = "scaleddata.csv";

            // Default save as txt
            saveFileDialogData.DefaultExt = "*.csv";

            if (saveFileDialogData.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWritePoints = new StreamWriter(saveFileDialogData.FileName))

                    foreach (MeasurementPointScaled point in allMeasuredPointsScaled)
                    {
                        streamWritePoints.WriteLine(point.ToString());
                    }
            }
        }

        public class MeasurementPointRaw
        {
            public String time { get; set; }
            public int raw { get; set; }

            public MeasurementPointRaw(String time, int raw)
            {
                this.time = time;
                this.raw = raw;
            }

            public override string ToString()
            {
                return time + ";" + raw;
            }
        }

        public class MeasurementPointScaled
        {
            public String time { get; set; }
            public double scaled { get; set; }

            public MeasurementPointScaled(String time, double scaled)
            {
                this.time = time;
                this.scaled = scaled;
            }

            public override string ToString()
            {
                return time + ";" + scaled;
            }
        }


        // LOAD from config
        private void buttonRead_Click(object sender, EventArgs e)
        {
            // Open directory 
            saveFileDialogData.InitialDirectory = @"C:\Users\";
            saveFileDialogData.Filter = "ssc files (*.ssc)|*.ssc|All files (*.*)|*.*";
            saveFileDialogData.FilterIndex = 2;
            saveFileDialogData.RestoreDirectory = true;
            saveFileDialogData.FileName = "";

            // If a directory is picked do this
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                string receivedConfig = File.ReadAllText(openFileDialogMain.FileName);

                string[] fromConfig = receivedConfig.Split(';');

                TextBox[] textboxes = { textBoxTagname,
                                    textBoxLRV,
                                    textBoxURV,
                                    textBoxAL,
                                    textBoxAH,
                };

                textBoxTagname.Text = fromConfig[0];
                textBoxLRV.Text = fromConfig[1];
                textBoxURV.Text = fromConfig[2];
                textBoxAL.Text = fromConfig[3];
                textBoxAH.Text = fromConfig[4];
            }
        }


        // This does nothing seeing as the password is already written in the "writeconf" string
        private void buttonPassword_Click(object sender, EventArgs e)
        {
            string passwordString = "";
            passwordString = textBoxPassword.Text;
            panelPassword.Visible = false;
        }

        

        // Status timer crash with graph timer and not sure if it works but it's an attempt
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if (serialPortMain.IsOpen)
            {
                serialPortMain.WriteLine("readstatus");

                switch (serialPortMain.ReadExisting())
                {
                    case "0":
                        labelStatusChange.Text = "OK";
                        break;
                    case "1":
                        labelStatusChange.Text = "Fail";
                        break;
                    case "2":
                        labelStatusChange.Text = "Alarm Low";
                        break;
                    case "3":
                        labelStatusChange.Text = "Alarm High";
                        break;
                    default:
                        labelStatusChange.Text = "";
                        break;
                }

            }
        }
    }
}
