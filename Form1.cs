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
using System.Windows.Forms.DataVisualization.Charting;

namespace SoftSensConf
{
    public partial class retrieve : Form
    {
        List<int> analogReading = new List<int>();
        List<DateTime> voltageDiff = new List<DateTime>();
        String timeStamp = GetTimestamp(DateTime.Now);

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        public retrieve()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(timer1_Tick);
            comboBox2.Text = comboBox2.Items[2].ToString();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
            comboBox1.Text = comboBox1.Items[0].ToString();
            
                
        }

        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int iVab;
            string RecievedData = ((SerialPort)sender).ReadLine();
            readingstextBox.Invoke((MethodInvoker) delegate 
            {readingstextBox.AppendText("Recieved:" + RecievedData + "\r\n");});
            string[] separateParts= RecievedData.Split(';');
            if (int.TryParse(separateParts[2],out iVab))
           

            {
                analogReading.Add(iVab);
                //timeStamp.Add(DateTime.Now);
                chart1.Series["Vba"].Points.DataBindXY(timeStamp, analogReading);
                chart1.Invalidate();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
            

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("Read analog");
        }
        private void connect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            //skal også skrive til textBox1 hvilke verdier som allerede er lagret i arduinoen
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBox1.Items.Clear();
            //comboBox1.Items.AddRange(SerialPort.GetPortNames());

        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    textBox1.AppendText("Connected \r\n");
                }
                else
                {
                    textBox1.AppendText("Not connected to usnTopSens.\r\n");
                }
            }
            catch (Exception IOException)
            {
                MessageBox.Show("Check that your instrument is connected.");
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
            try
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
            catch (Exception IndexOutOfRangeException)
            {
                MessageBox.Show("Something went wrong.");
            }

        }

        private void aboutbutton1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {   //aboutbutton2
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {    //aboutbutton3
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.ShowDialog(this);

        }

        private void manualbutton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("readanalog");
                readingstextBox.AppendText(serialPort1.ReadLine());
                readingstextBox.AppendText("\r\n");
                timer1.Stop();
            }
            catch (Exception InvalidOperationException)
            {
                MessageBox.Show("Something went wrong");    
            }
        }

        private void autobutton_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readanalog");
            readingstextBox.AppendText(serialPort1.ReadLine());
            readingstextBox.AppendText("\r\n");
            timer1.Start();
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
