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

        // Form Layout
        private void FormMain_Load(object sender, EventArgs e)
        {
            panelData.Visible = false;
            panelConfiguration.Visible = false;

            textBoxSetupInfo.AppendText("Fyll inn info bla bla for å koble til arduinoen din");
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelPick.Height = buttonDashboard.Height;
            panelPick.Top = buttonDashboard.Top;

            panelData.Visible = false;
            panelConfiguration.Visible = false;
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            panelPick.Height = buttonData.Height;
            panelPick.Top = buttonData.Top;

            panelData.Visible = true;
            panelConfiguration.Visible = false;
        }

        private void buttonSetup_Click(object sender, EventArgs e)
        {
            panelPick.Height = buttonConfiguration.Height;
            panelPick.Top = buttonConfiguration.Top;

            panelData.Visible = false;
            panelConfiguration.Visible = true;
        }

        // CONFIGURATION PANEL

        // Setup
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            serialPortMain.BaudRate = int.Parse(comboBoxBit.Text);
            serialPortMain.PortName = comboBoxPort.Text;

            serialPortMain.Open();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPortMain.Close();
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

        private void buttonReceive_Click(object sender, EventArgs e)
        {
            string indata = serialPortMain.ReadExisting();
            textBoxReceive.AppendText(indata);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            serialPortMain.WriteLine(textBoxSend.Text);
            textBoxSend.Clear();
        }



        // Open AND Select a File
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // Open directory 
            openFileDialogMain.InitialDirectory = @"C:\Users\Emma\Desktop\";
            openFileDialogMain.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialogMain.FilterIndex = 2;
            openFileDialogMain.RestoreDirectory = true;
            openFileDialogMain.FileName = "";

            // Clears the textbox
            textBoxReceive.Clear();

            // If a directory is picked do this
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                var fileText = File.ReadLines(openFileDialogMain.FileName);
                string[] separateParts = fileText.ToArray();

                // Writes lines in the textbox
                foreach (string line in fileText)
                {
                    textBoxReceive.AppendText(line + "\r\n");
                }

                // Changes config for the arduino
                serialPortMain.PortName = separateParts[0];
                comboBoxPort.Text = separateParts[0];
                serialPortMain.BaudRate = int.Parse(separateParts[1]);
                comboBoxBit.Text = separateParts[1];
            }
        }

        // Save configuration
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            // Open directory 
            saveFileDialogMain.InitialDirectory = @"C:\Users\Emma\Desktop\";
            saveFileDialogMain.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialogMain.FilterIndex = 2;
            saveFileDialogMain.RestoreDirectory = true;
            saveFileDialogMain.FileName = "configuration.txt";

            // Default save as txt
            saveFileDialogMain.DefaultExt = "*.txt";

            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fileName = new StreamWriter(saveFileDialogMain.FileName);
              
                fileName.WriteLine(comboBoxPort.Text);
                fileName.WriteLine(comboBoxBit.Text);

                fileName.Close();
            }
        }
    }
}

/*
 o	Se nåværende configurasjon eller default hvis ingen
    - send/receive commands, code in arduino

o	Åpne fil og lese data fra fil (hvis fil eksisterer? UH IDK)
    - #open file -> read and add in textbox //DONE
o	Endre configuarsjonen
    - fixed, add more?  //DONE?
o	Laste opp ny configurasjon til intrument
    - #upload from file button  //DONE
o	Lagre «configuration» data til tekstfil
    - #save config to textfile button   //DONE

o	Legge til feilmeldinger(?) hvis fil er feil yadda yadda
 */

// PLOTTING
