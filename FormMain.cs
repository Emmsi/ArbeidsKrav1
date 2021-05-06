using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.IO;

using System.Data.SqlClient;
using System.Configuration;

namespace ArbeidsKrav1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // ConnectionString for SQL
        string connectSoftSensDB = ConfigurationManager.ConnectionStrings["SoftSensDBConnectionString"].ConnectionString;
     
        // Form Layout
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.RDC' table. You can move, or remove it, as needed.
            this.rDCTableAdapter.Fill(this.softSensConfDBDataSet.RDC);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.Manufacturer' table. You can move, or remove it, as needed.
            this.manufacturerTableAdapter.Fill(this.softSensConfDBDataSet.Manufacturer);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.LogID' table. You can move, or remove it, as needed.
            this.logIDTableAdapter.Fill(this.softSensConfDBDataSet.LogID);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.softSensConfDBDataSet.Location);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.Instrument_Type' table. You can move, or remove it, as needed.
            this.instrument_TypeTableAdapter.Fill(this.softSensConfDBDataSet.Instrument_Type);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.Instrument' table. You can move, or remove it, as needed.
            this.instrumentTableAdapter.Fill(this.softSensConfDBDataSet.Instrument);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.DAU' table. You can move, or remove it, as needed.
            this.dAUTableAdapter.Fill(this.softSensConfDBDataSet.DAU);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.DataLog' table. You can move, or remove it, as needed.
            this.dataLogTableAdapter.Fill(this.softSensConfDBDataSet.DataLog);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.Communication' table. You can move, or remove it, as needed.
            this.communicationTableAdapter.Fill(this.softSensConfDBDataSet.Communication);
          
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
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            panelPick.Height = buttonData.Height;
            panelPick.Top = buttonData.Top;

            panelDashboard.Visible = false;
            panelData.Visible = true;
            panelConfiguration.Visible = false;
        }

        private void buttonSetup_Click(object sender, EventArgs e)
        {
            panelPick.Height = buttonConfiguration.Height;
            panelPick.Top = buttonConfiguration.Top;

            panelDashboard.Visible = false;
            panelData.Visible = false;
            panelConfiguration.Visible = true;
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
       
        private void dataGridViewMain_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                instrumentBindingSource.EndEdit();
                instrumentTableAdapter.Update(softSensConfDBDataSet.Instrument);

                communicationBindingSource.EndEdit();
                communicationTableAdapter.Update(softSensConfDBDataSet.Communication);

                dAUBindingSource.EndEdit();
                dAUTableAdapter.Update(softSensConfDBDataSet.DAU);

                rDCBindingSource.EndEdit();
                rDCTableAdapter.Update(softSensConfDBDataSet.RDC);

                locationBindingSource.EndEdit();
                locationTableAdapter.Update(softSensConfDBDataSet.Location);

                dataLogBindingSource.EndEdit();
                dataLogTableAdapter.Update(softSensConfDBDataSet.DataLog);

                instrumentTypeBindingSource.EndEdit();
                instrument_TypeTableAdapter.Update(softSensConfDBDataSet.Instrument_Type);

                manufacturerBindingSource.EndEdit();
                manufacturerTableAdapter.Update(softSensConfDBDataSet.Manufacturer);

                logIDBindingSource.EndEdit();
                logIDTableAdapter.Update(softSensConfDBDataSet.LogID);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error updating data to database:\r\n\n\n" + ex);
            }
        }

        private void ViewSqlResultInDataGridView(string sqlQuery)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectSoftSensDB);
                SqlDataAdapter sqlDataAdapter;
                DataTable resultDataTable;
                connection.Open();

                sqlDataAdapter = new SqlDataAdapter(sqlQuery, connection);
                resultDataTable = new DataTable();

                sqlDataAdapter.Fill(resultDataTable);
                dataGridViewAdmin.DataSource = resultDataTable;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLocationGrid_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT AreaCode, Size FROM Location ORDER BY AreaCode ASC";
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewSqlResultInDataGridView(sqlQuery);
        }

        private void buttonManufacturerGrid_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT [Maker_ID], ContactName, Address, Phone FROM Manufacturer ORDER BY [Maker_ID] ASC";
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewSqlResultInDataGridView(sqlQuery);
        }

        private void buttonDAUGrid_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT [DAU_ID],[RDC_ID],[Location_ID],[Description],[Comms_ID],[COMport],[Baudrate] FROM [SoftSensConfDB].[dbo].[DAU] ORDER BY DAU_ID ASC";
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewSqlResultInDataGridView(sqlQuery);
        }

        private void buttonLogIDGrid_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT [Log_ID] ,[LogDate] ,[Tagname] ,[Description] FROM [SoftSensConfDB].[dbo].[LogID] ORDER BY [Tagname] ASC";
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewSqlResultInDataGridView(sqlQuery);
        }

        private void buttonInstrumentGrid_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT [DAU_ID] ,[Comms_ID] ,[Tagname] ,[Location_ID] ,[Description] ,[LRV] ,[URV] ,[AlarmL] ,[AlarmH] ,[ScanFrequency] ,[Type_ID] ,[Maker_ID] FROM [SoftSensConfDB].[dbo].[Instrument] ORDER BY [Tagname] ASC";
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewSqlResultInDataGridView(sqlQuery);
        }

        private void buttonRDCGrid_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT [RDC_ID] ,[Location_ID] ,[Description] FROM [SoftSensConfDB].[dbo].[RDC] ORDER BY [RDC_ID] ASC";
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewSqlResultInDataGridView(sqlQuery);
        }

        private void buttonDataLogGrid_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT [DataLog_ID] ,[Log_ID] ,[Timestamp] ,[Input/Output] ,[AnalogueValue(raw)] ,[DigitalValue] FROM [SoftSensConfDB].[dbo].[DataLog] ORDER BY [DataLog_ID] ASC";
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewSqlResultInDataGridView(sqlQuery);
        }

        private void buttonInstrumentTypesGrid_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT [Type_ID] ,[InstrumentType] ,[Model] FROM [SoftSensConfDB].[dbo].[Instrument Type] ORDER BY [Type_ID] ASC";
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewSqlResultInDataGridView(sqlQuery);
        }

        private void buttonCommsTypesGrid_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT [Comms_ID] ,[CommsType] ,[DataType] FROM [SoftSensConfDB].[dbo].[Communication] ORDER BY [Comms_ID] ASC";
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewSqlResultInDataGridView(sqlQuery);
        }
    }
}
