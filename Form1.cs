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
        List<DateTime> timeStamp = new List<DateTime>();
        List<DateTime> voltageDiff = new List<DateTime>();

        private static string GetTimestamp(DateTime now)
        {
            throw new NotImplementedException();
        }


        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int iVab;
            string RecievedData = ((SerialPort)sender).ReadLine();
            readingstextBox.Invoke((MethodInvoker)delegate { readingstextBox.AppendText("Recieved: " + RecievedData + "\r\n"); });
            string[] separateParts = RecievedData.Split(';');
            if (int.TryParse(separateParts[2], out iVab))
            {
                analogReading.Add(iVab);
                timeStamp.Add(DateTime.Now);
                chart1.Series["Vba"].Points.DataBindXY(timeStamp, analogReading);
                chart1.Invalidate();
            }
            else
            {
                MessageBox.Show("Gikk Ikke.");
            }
        }

            private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readscaled");
            char[] charstotrim = { 'r', 'e', 'a', 'd', 's', ';', 'c', 'l' };
            string result = serialPort1.ReadLine().Trim(charstotrim);
            readingstextBox.AppendText(result + "\r\n");
        }
            private void timer2_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readstatus");
            char[] charstotrim = { 'r', 'e', 'a', 'd', 's', 't', 'u', ' ', ';', ':' };
           // textBox2.Text = serialPort1.ReadLine().Trim(charstotrim).ToString();
            
            if (int.Parse(serialPort1.ReadLine().Trim(charstotrim)) == 0)
            {
                statusupdate.Text = "Ok";
            }
            else if (int.Parse(serialPort1.ReadLine().Trim(charstotrim)) == 1)
            {
                statusupdate.Text = "Fail!";
                statusupdate.BackColor = Color.MistyRose;
                label8.BackColor = Color.MistyRose;
            }
            else if (int.Parse(serialPort1.ReadLine().Trim(charstotrim)) == 2)
            {
                statusupdate.Text = "Alarm low!";
                statusupdate.BackColor = Color.MistyRose;
                label8.BackColor = Color.MistyRose;
            }
            else if (int.Parse(serialPort1.ReadLine().Trim(charstotrim)) == 3)
            {
                statusupdate.Text = "Alarm high!";
                statusupdate.BackColor = Color.MistyRose;
                label8.BackColor = Color.MistyRose;
            }
            else
            {
                statusupdate.Text = "Not available";
            }
        }
        public retrieve()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer2.Interval = 4500;
            timer2.Tick += new EventHandler(timer2_Tick);
            comboBox2.Text = comboBox2.Items[2].ToString();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
            comboBox1.Text = comboBox1.Items[0].ToString();
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
        }

        // Display the password form.
 




        /*private void connect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            //skal også skrive til textBox1 hvilke verdier som allerede er lagret i arduinoen
        }
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox1.Items.Clear();
            //comboBox1.Items.AddRange(SerialPort.GetPortNames());

        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            statusupdate.Text = " ";
            label7.Text = " ";
            status.Text = " ";
            timer2.Start();
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    textBox1.Text = "Connected to " + comboBox1.Text + "\r\n";
                    textBox1.BackColor = Color.Honeydew;
                }
                else
                {
                    textBox1.AppendText("Device not connected. Please try again.\r\n");
                }
            }
            catch (Exception IOException)
            {
                
            }

        }

        private void save_settings_button_Click(object sender, EventArgs e)
        {
            status.Text = " ";
            StreamWriter outputFile = new StreamWriter(@"C:\tmp\Config.tmp");
            outputFile.WriteLine(textBox7);
            outputFile.Close();
            MessageBox.Show("New settings saved.");
        }

        private void retrieve_settings_button_Click(object sender, EventArgs e)
        {
            status.Text = "Configuration saved on device:";
            try
            {
                textBoxname.Text = "";
                textBoxlrv.Text = "";
                textBoxurv.Text = "";
                textBoxalarml.Text = "";
                textBoxalarmh.Text = "";

                StreamReader inputFile = new StreamReader(@"C:\tmp\Config.tmp");
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
                MessageBox.Show("No values saved. Showing default values.");
            }

            finally
            {
                textBoxname.Text = "C385IT001";
                textBoxlrv.Text = "0.0";
                textBoxurv.Text = "500.0";
                textBoxalarml.Text = "40";
                textBoxalarmh.Text = "440";
                textBox7.Text = textBoxname.Text + ";" + textBoxlrv.Text + ";" + textBoxurv.Text + ";" + textBoxalarml.Text + ";" + textBoxalarmh.Text;

            }
        
        }

        private void value_button_Click(object sender, EventArgs e)
        {
            if (password.Text == string.Empty)
            {
                var message = "Password required.";
                var title = string.Empty;
                var result = MessageBox.Show(message, title,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
             

                serialPort1.WriteLine("writeconf>" + password.Text + ">" + textBoxname.Text + ";" + textBoxlrv.Text + ";" + textBoxurv.Text + ";" + textBoxalarml.Text + ";" + textBoxalarmh.Text);
                string svar = serialPort1.ReadLine();

                if (svar != null)
                {
                    textBox7.Text = "Configuration changed";
                }

                else
                {
                    textBox7.Text = "Check your password again.";
                }
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
                serialPort1.WriteLine("readscaled");
                char[] charstotrim = { 'r', 'e', 'a', 'd', 's', ';', 'c', 'l' };
                string result = serialPort1.ReadLine().Trim(charstotrim);
                readingstextBox.AppendText(result + "\r\n");
                
                
                timer1.Stop();
            }
            catch (Exception InvalidOperationException)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void autobutton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                label7.Text = "Autoreading started";
                timer1.Start();
                serialPort1.WriteLine("readscaled");
                char[] charstotrim = { 'r', 'e', 'a', 'd', 's', ';', 'c', 'l' };
                string result = serialPort1.ReadLine().Trim(charstotrim);
                readingstextBox.AppendText(result + "\r\n");

            }

            else
            {
                readingstextBox.Text = "Port is closed.\r\n";
            }
       
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label7.Text = "Autoreading stopped";


            var message = "Save readings to file?";
            var title = "Save?";
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Readings saved to file.");
                    string tittel = "SSC_Readings";
                    List<string> avlesninger = new List<string>();


                    using (StringReader reader = new StringReader(readingstextBox.Text))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            avlesninger.Add(line);                        }
                    }
                   
                    //label8.Text = "idag er det" + DateTime.Now;
                 
                   File.WriteAllLines(@"C:\tmp\"+tittel+".csv", avlesninger);

                    break;
                case DialogResult.No:   
                    MessageBox.Show("Readings not saved.");
                    break;
            }

        }

        private void disconnectbutton_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            serialPort1.Close();
            textBox1.Text = "Disconnected from " + comboBox1.Text + "\r\n";
            textBox1.BackColor = Color.MistyRose;
            statusupdate.Text = " ";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            status.Text = "Configuration saved on file:";
        }
    }
}
