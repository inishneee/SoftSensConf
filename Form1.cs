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
using System.Data.SqlClient;
using System.Configuration;


namespace SoftSensConf
{

    public partial class retrieve : Form
    {
        string conSSC = ConfigurationManager.ConnectionStrings["conSSC"].ConnectionString;
        DateTime TimeStamp = DateTime.Now;
        List<DateTime> TimeList = new List<DateTime>();
        List<string> avlesninger = new List<string>();
        List<string> tid = new List<string>();
        List<string> ts = new List<string>();
        int i = 0;

        public retrieve()
        {
            InitializeComponent();
            timer1.Interval = int.Parse(textBox5.Text);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer2.Interval = 4500;
            timer2.Tick += new EventHandler(timer2_Tick);
            comboBox2.Text = comboBox2.Items[2].ToString();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
            //comboBox1.Text = comboBox1.Items[0].ToString();
            comboBox3.Text = comboBox3.Items[1].ToString();
            

            StreamReader inputFile = new StreamReader(@"C:\tmp\Config.tmp");
            textBox7.Text = inputFile.ReadToEnd();
            inputFile.Close();

            string inputard = textBox7.Text;
            string[] ardconfig = inputard.Split(';');
            textBoxname.AppendText(ardconfig[0]);
            textBoxlrv.AppendText(ardconfig[1]);
            textBoxurv.AppendText(ardconfig[2]);
            textBoxalarml.AppendText(ardconfig[3]);
            textBoxalarmh.AppendText(ardconfig[4]);

        }

        public class instrument
        {
            private int measurement;

            public instrument(int measurement)

            { this.measurement = measurement; }

            public instrument(string tagname, string unit, double lrv, double urv)
            {
                this.tagname = tagname;
                this.unit = unit;
                this.lrv = lrv;
                this.urv = urv;
            }

            public string tagname
            {
                get { return tagname; }
                set { tagname = value; }
            }

            public string unit { get; set; }
            public double lrv { get; set; }
            public double urv { get; set; }
        
        }

        public static void readconfig(int LRV, int URV, int AlarmL, int AlarmH, SqlConnection con)
        {
            string sqlQuery = "UPDATE [readingconfig] SET [lower_range_value] = '" + LRV + "', [upper_range_value] = '" + URV + "',[alarmL] = '" + AlarmL + "',[alarmH] = '" + AlarmH + "'";
        
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            serialPort1.WriteLine(comboBox3.SelectedItem.ToString());
            char[] charstotrim = { 'r', 'e', 'a', 'd', 's', ';', 'c', 'l', 'w', ':' };
            string result = serialPort1.ReadLine().Trim(charstotrim);

            
            List<string> avlesninger = new List<string>();
            DateTime now = DateTime.Now ;
            String timetrack = DateTime.Now.ToString();
            TimeList.Add(now);
            tid.Add(now.ToString("dd/MM/yy HH.mm:ss"));
            avlesninger.Add(result);
            valuebox.Text = result;
            timebox.Text = now.ToString("dd/MM/yy HH.mm:ss");
            chart1.Series[0].XValueType = ChartValueType.DateTime;

            chart1.Series[0].Points.AddXY(now.ToString("HH:mm:ss"), result);
            i += 2;
            
            textBox.AppendText(now.ToString("dd/MM/yyyy,HH:mm:ss")+";" + result+ ";\r\n");
            readingstextBox.AppendText(result + "\r\n");
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            
                serialPort1.WriteLine("readstatus");
                char[] charstotrim = { 'r', 'e', 'a', 'd', 's', 't', 'u', ' ', ';', ':' };

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
        void showlog(string sqlQuery)
        {
            try
            {
                SqlConnection con = new SqlConnection(conSSC);
                SqlDataAdapter sda;
                DataTable dt;
                con.Open();
                sda = new SqlDataAdapter(sqlQuery, con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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
                    label9.Text = "Connected to " + comboBox1.Text + "\r\n";
                    label9.BackColor = Color.Honeydew;
                    label10.Text = "Connected to " + comboBox1.Text + "\r\n";
                    label10.BackColor = Color.Honeydew;
                    label11.Text = "Connected to " + comboBox1.Text + "\r\n";
                    label11.BackColor = Color.Honeydew;
                    label12.Text = "Connected to " + comboBox1.Text + "\r\n";
                    label12.BackColor = Color.Honeydew;
                }
                else
                {
                    label12.Text = "Device not connected. Please try again.";
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

        

        public void retrieve_settings_button_Click(object sender, EventArgs e)
        {
            status.Text = "Configuration saved on device:";
            try
            {
                textBoxname.Text = "";
                textBoxlrv.Text = "";
                textBoxurv.Text = "";
                textBoxalarml.Text = "";
                textBoxalarmh.Text = "";

                //StreamReader inputFile = new StreamReader(@"C:\tmp\Config.tmp");
                //textBox7.Text = inputFile.ReadToEnd();
                //inputFile.Close();

                string inputard = textBox7.Text;
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
                var title = "Missing password";
                var result = MessageBox.Show(message, title,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (password.Text == "password")
            {
             

                serialPort1.WriteLine("writeconf>password>" + textBoxname.Text + ";" + textBoxlrv.Text + ";" + textBoxurv.Text + ";" + textBoxalarml.Text + ";" + textBoxalarmh.Text);
                string svar = serialPort1.ReadLine();

                if (svar == "writeconf;1\r")
                {
                    MessageBox.Show("Configuration changed");
                    password.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Something went wrong");

                }
                
            }
            else
            {
                MessageBox.Show("Check your password again.");
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
                serialPort1.WriteLine(comboBox3.SelectedItem.ToString());
                char[] charstotrim = { 'r', 'e', 'a', 'd', 's', ';', 'c', 'l', 'w', ':' };
                string result = serialPort1.ReadLine().Trim(charstotrim);

                List<string> avlesninger = new List<string>();
                DateTime now = DateTime.Now;
                String timetrack = DateTime.Now.ToString();
                TimeList.Add(now);
                tid.Add(now.ToString("dd/MM/yy HH.mm:ss"));
                avlesninger.Add(result);
                valuebox.Text = result;
                timebox.Text = now.ToString("dd/MM/yy HH.mm:ss");
                chart1.Series[0].XValueType = ChartValueType.DateTime;

                chart1.Series[0].Points.AddXY(now.ToString("HH:mm:ss"), result);
                i += 2;

                textBox.AppendText(now.ToString("dd/MM/yyyy,HH:mm:ss") + ";" + result + ";\r\n");
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
            chart1.Titles.Clear();
            chart1.Titles.Add(comboBox3.SelectedItem.ToString());
            
            if (serialPort1.IsOpen)
            {
                label7.Text = "Autoreading started";
                timer1.Start();
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
        }

        private void disconnectbutton_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            serialPort1.Close();
            label9.Text = "Disconnected from " + comboBox1.Text + "\r\n";
            label9.BackColor = Color.MistyRose;
            label10.Text = "Disconnected from " + comboBox1.Text + "\r\n";
            label10.BackColor = Color.MistyRose;
            label11.Text = "Disconnected from " + comboBox1.Text + "\r\n";
            label11.BackColor = Color.MistyRose;
            label12.Text = "Disconnected from " + comboBox1.Text + "\r\n";
            label12.BackColor = Color.MistyRose;
            statusupdate.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            status.Text = "Configuration saved on file:";
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            readingstextBox.Text = " ";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime TimeStamp = DateTime.Now;
            var message = "Save readings to file?";
            var title = "Save?";
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:

                    string tittel = "SSC_Readings";
                    //List<string> avlesninger = new List<string>();

                    using (StringReader reader = new StringReader(textBox.Text))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {

                            ts.Add(line.ToString());

                        }

                    }

                    File.WriteAllLines(@"C:\tmp\" + tittel + ".csv", ts);
                    MessageBox.Show("Readings saved to file");

                    break;
                case DialogResult.No:
                    MessageBox.Show("Readings not saved.");
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            readingstextBox.Text = string.Empty;
            textBox.Text = string.Empty;
            
        }

        private void valuebox_TextChanged(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readstatus");
            char[] charstotrim = { 'r', 'e', 'a', 'd', 's', 't', 'u', ' ', ';', ':' };
            string value, sqlQuery;
            string time = DateTime.Now.ToString();
            int error1 = (int.Parse(serialPort1.ReadLine().Trim(charstotrim)));
            retrieve_settings_button.PerformClick();
            string name = textBoxname.Text;

            try
            {
                //Oppretter en connection mot databasen med string definert i App.config:
                SqlConnection con = new SqlConnection(conSSC);
                value = valuebox.Text;  
                /* Lagrer spørringen legger en ny "value"-verdi i re-tabellen */
                if (comboBox3.SelectedItem.ToString() == "readraw")
                {

                    sqlQuery = string.Concat(@"INSERT INTO data_logm (rawreadings, timestamp, error, instrument_id)

                        VALUES ('", value, "','", time ,"','",error1,"','",name,"')");
                  

                        con.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                else if (comboBox3.SelectedItem.ToString() == "readscaled")
                {
                    sqlQuery = String.Concat(@"INSERT INTO data_logm (scaledreadings, timestamp, error, instrument_id)

                        VALUES ('", value, "','", time, "','", error1, "','", name, "')");

                    con.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void readings_Click(object sender, EventArgs e)
        {
            string sqlQuery = @"SELECT * FROM data_logm ORDER BY timestamp ASC";
            showlog(sqlQuery);
      
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            string sqlQuery = @"SELECT * FROM data_logm ORDER BY timestamp ASC";
            showlog(sqlQuery);
            lblTotal.Text = $"Total hits: {dataGridView1.RowCount}";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            string sqlQuery = @"SELECT * FROM data_logm ORDER BY timestamp ASC";
            showlog(sqlQuery);
            /*
            try
            {
                SqlConnection con = new SqlConnection(conSSC);

                using (DataTable dt = new DataTable("Customer"))
                {
                    using(SqlCommand cmd = new SqlCommand("select *from timestamp where timestamp=@timestamp or instrument_id=@instrument_id", con))
                    {
                        cmd.Parameters.AddWithValue("timestamp", textBox1.Text);
                        cmd.Parameters.AddWithValue("instrument_id", string.Format("%{0}%", textBox1.Text));
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        lblTotal.Text = $"Total records: {dataGridView1.RowCount}";
                    }
                }
                con.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13)//enter
              //  searchbtn.PerformClick();
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(textBox5.Text .Length < 3)
            {
                var message = "Number is too low";
                var title = "Error";
                var result = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if (textBox5.Text.Length > 3)
            {
                var message = "Number is too high";
                var title = "Error";
                var result = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }
    }
  
    
}
