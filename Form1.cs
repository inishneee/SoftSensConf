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

namespace SoftSensConf
{
    public partial class retrieve : Form
    {
        public retrieve()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            //skal også skrive til textBox1 hvilke verdier som allerede er lagret i arduinoen
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void connect_button_Click(object sender, EventArgs e)
        {

            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                textBox1.AppendText("Connected \r\n");
            }
        }

        private void save_settings_button_Click(object sender, EventArgs e)
        {

            StreamWriter outputFile = new StreamWriter(@"C:\tmp\Text1.tmp");
            outputFile.WriteLine(textBox7);
            outputFile.Close();
            //MessageBox.Show("New settings saved.");
        }

        private void retrieve_settings_button_Click(object sender, EventArgs e)
        {
            textBoxname.Text = "";
            textBoxlrv.Text = "";
            textBoxurv.Text = "";
            textBoxalarml.Text = "";
            textBoxalarmh.Text = "";
            
            StreamReader inputFile = new StreamReader(@"C:\tmp\Text1.tmp");
            textBox7.Text = inputFile.ReadToEnd();
            inputFile.Close();
            
            string inputard = textBox7.Text;
            //string inputard = ((SerialPort)sender).ReadLine();
            string[] ardconfig = inputard.Split(';');
            textBoxname.AppendText(ardconfig[0]);
            textBoxlrv.AppendText(ardconfig[1]);
            textBoxurv.AppendText(ardconfig[2]);
            textBoxalarml.AppendText(ardconfig[3]);
            textBoxalarmh.AppendText(ardconfig[4]);


        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("sendt: " + comboBox3.Text);
            }
        }
    }
}
