namespace SoftSensConf
{
    partial class retrieve
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(retrieve));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.disconnectbutton = new System.Windows.Forms.Button();
            this.aboutbutton1 = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.bitratelabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.portlabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.value_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxalarmh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxalarml = new System.Windows.Forms.TextBox();
            this.textBoxurv = new System.Windows.Forms.TextBox();
            this.textBoxlrv = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.save_settings_button = new System.Windows.Forms.Button();
            this.retrieve_settings_button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.statusupdate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stopbutton = new System.Windows.Forms.Button();
            this.readingstextBox = new System.Windows.Forms.TextBox();
            this.autobutton = new System.Windows.Forms.Button();
            this.manualbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.disconnectbutton);
            this.tabPage1.Controls.Add(this.aboutbutton1);
            this.tabPage1.Controls.Add(this.connect_button);
            this.tabPage1.Controls.Add(this.bitratelabel);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.portlabel);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(727, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connect";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(550, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "  ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // disconnectbutton
            // 
            this.disconnectbutton.Location = new System.Drawing.Point(71, 188);
            this.disconnectbutton.Name = "disconnectbutton";
            this.disconnectbutton.Size = new System.Drawing.Size(121, 26);
            this.disconnectbutton.TabIndex = 9;
            this.disconnectbutton.Text = "Disconnect";
            this.toolTip1.SetToolTip(this.disconnectbutton, "Disconnect from device");
            this.disconnectbutton.UseVisualStyleBackColor = true;
            this.disconnectbutton.Click += new System.EventHandler(this.disconnectbutton_Click);
            // 
            // aboutbutton1
            // 
            this.aboutbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aboutbutton1.Location = new System.Drawing.Point(637, 15);
            this.aboutbutton1.Name = "aboutbutton1";
            this.aboutbutton1.Size = new System.Drawing.Size(75, 23);
            this.aboutbutton1.TabIndex = 8;
            this.aboutbutton1.Text = "About";
            this.toolTip1.SetToolTip(this.aboutbutton1, "About the software");
            this.aboutbutton1.UseVisualStyleBackColor = true;
            this.aboutbutton1.Click += new System.EventHandler(this.aboutbutton1_Click);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(71, 156);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(121, 25);
            this.connect_button.TabIndex = 5;
            this.connect_button.Text = "Connect";
            this.toolTip1.SetToolTip(this.connect_button, "Connect to device");
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // bitratelabel
            // 
            this.bitratelabel.AutoSize = true;
            this.bitratelabel.Location = new System.Drawing.Point(71, 91);
            this.bitratelabel.Name = "bitratelabel";
            this.bitratelabel.Size = new System.Drawing.Size(54, 16);
            this.bitratelabel.TabIndex = 3;
            this.bitratelabel.Text = "Bit Rate";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200"});
            this.comboBox2.Location = new System.Drawing.Point(71, 110);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBox2, "Choose bitrate");
            // 
            // portlabel
            // 
            this.portlabel.AutoSize = true;
            this.portlabel.Location = new System.Drawing.Point(71, 41);
            this.portlabel.Name = "portlabel";
            this.portlabel.Size = new System.Drawing.Size(31, 16);
            this.portlabel.TabIndex = 1;
            this.portlabel.Text = "Port";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBox1, "Connection port");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.password);
            this.tabPage2.Controls.Add(this.status);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.value_button);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.save_settings_button);
            this.tabPage2.Controls.Add(this.retrieve_settings_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "  ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(296, 327);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(121, 22);
            this.password.TabIndex = 15;
            this.toolTip1.SetToolTip(this.password, "Enter password to change values");
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(54, 31);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(140, 16);
            this.status.TabIndex = 14;
            this.status.Text = "Show/Change settings";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(579, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "Retrieve settings\r\nfrom file\r\n";
            this.toolTip1.SetToolTip(this.button3, "Save settings, demands username and password");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // value_button
            // 
            this.value_button.Location = new System.Drawing.Point(296, 264);
            this.value_button.Name = "value_button";
            this.value_button.Size = new System.Drawing.Size(121, 42);
            this.value_button.TabIndex = 10;
            this.value_button.Text = "Change to new values";
            this.toolTip1.SetToolTip(this.value_button, "Requires password");
            this.value_button.UseVisualStyleBackColor = true;
            this.value_button.Click += new System.EventHandler(this.value_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "About";
            this.toolTip1.SetToolTip(this.button1, "About the software");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(296, 50);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(264, 195);
            this.textBox7.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBox7, "Readings");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxalarmh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxalarml);
            this.panel1.Controls.Add(this.textBoxurv);
            this.panel1.Controls.Add(this.textBoxlrv);
            this.panel1.Controls.Add(this.textBoxname);
            this.panel1.Location = new System.Drawing.Point(51, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 182);
            this.panel1.TabIndex = 3;
            // 
            // textBoxalarmh
            // 
            this.textBoxalarmh.Location = new System.Drawing.Point(107, 145);
            this.textBoxalarmh.Name = "textBoxalarmh";
            this.textBoxalarmh.Size = new System.Drawing.Size(100, 22);
            this.textBoxalarmh.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxalarmh, "Input new to change value");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alarmu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alarml";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Urv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lrv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // textBoxalarml
            // 
            this.textBoxalarml.Location = new System.Drawing.Point(107, 117);
            this.textBoxalarml.Name = "textBoxalarml";
            this.textBoxalarml.Size = new System.Drawing.Size(100, 22);
            this.textBoxalarml.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxalarml, "Input new to change value");
            // 
            // textBoxurv
            // 
            this.textBoxurv.Location = new System.Drawing.Point(107, 89);
            this.textBoxurv.Name = "textBoxurv";
            this.textBoxurv.Size = new System.Drawing.Size(100, 22);
            this.textBoxurv.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxurv, "Input new to change value");
            // 
            // textBoxlrv
            // 
            this.textBoxlrv.Location = new System.Drawing.Point(107, 61);
            this.textBoxlrv.Name = "textBoxlrv";
            this.textBoxlrv.Size = new System.Drawing.Size(100, 22);
            this.textBoxlrv.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxlrv, "Input new to change value");
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(107, 33);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 22);
            this.textBoxname.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxname, "Input new to change value");
            // 
            // save_settings_button
            // 
            this.save_settings_button.Location = new System.Drawing.Point(439, 264);
            this.save_settings_button.Name = "save_settings_button";
            this.save_settings_button.Size = new System.Drawing.Size(121, 42);
            this.save_settings_button.TabIndex = 1;
            this.save_settings_button.Text = "Save new settings to file";
            this.toolTip1.SetToolTip(this.save_settings_button, "Save settings, demands username and password");
            this.save_settings_button.UseVisualStyleBackColor = true;
            this.save_settings_button.Click += new System.EventHandler(this.save_settings_button_Click);
            // 
            // retrieve_settings_button
            // 
            this.retrieve_settings_button.Location = new System.Drawing.Point(158, 264);
            this.retrieve_settings_button.Name = "retrieve_settings_button";
            this.retrieve_settings_button.Size = new System.Drawing.Size(121, 42);
            this.retrieve_settings_button.TabIndex = 0;
            this.retrieve_settings_button.Text = "Retrieve settings\r\nfrom device";
            this.toolTip1.SetToolTip(this.retrieve_settings_button, "See saved settings");
            this.retrieve_settings_button.UseVisualStyleBackColor = true;
            this.retrieve_settings_button.Click += new System.EventHandler(this.retrieve_settings_button_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.textBox);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.statusupdate);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Controls.Add(this.stopbutton);
            this.tabPage3.Controls.Add(this.readingstextBox);
            this.tabPage3.Controls.Add(this.autobutton);
            this.tabPage3.Controls.Add(this.manualbutton);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(727, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sensor data";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox.Location = new System.Drawing.Point(-4, 470);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(303, 10);
            this.textBox.TabIndex = 25;
            // 
            // comboBox3
            // 
            this.comboBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "readraw",
            "readscaled"});
            this.comboBox3.Location = new System.Drawing.Point(97, 60);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(111, 24);
            this.comboBox3.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBox3, "Choose type of reading");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(94, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "About";
            this.toolTip1.SetToolTip(this.button4, "About the software");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(550, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "  ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusupdate
            // 
            this.statusupdate.AutoSize = true;
            this.statusupdate.Location = new System.Drawing.Point(622, 67);
            this.statusupdate.Name = "statusupdate";
            this.statusupdate.Size = new System.Drawing.Size(13, 16);
            this.statusupdate.TabIndex = 20;
            this.statusupdate.Text = "  ";
            this.toolTip1.SetToolTip(this.statusupdate, "Status/alarm control");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Status:";
            this.toolTip1.SetToolTip(this.label8, "Status/alarm control");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "  ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(151, 95);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Vba";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(563, 347);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(268, 21);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(119, 33);
            this.stopbutton.TabIndex = 13;
            this.stopbutton.Text = "Stop ";
            this.toolTip1.SetToolTip(this.stopbutton, "Push to stop autoreading\r\nand save readings\r\n");
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // readingstextBox
            // 
            this.readingstextBox.Location = new System.Drawing.Point(29, 115);
            this.readingstextBox.Multiline = true;
            this.readingstextBox.Name = "readingstextBox";
            this.readingstextBox.Size = new System.Drawing.Size(94, 327);
            this.readingstextBox.TabIndex = 12;
            // 
            // autobutton
            // 
            this.autobutton.Location = new System.Drawing.Point(151, 21);
            this.autobutton.Name = "autobutton";
            this.autobutton.Size = new System.Drawing.Size(111, 33);
            this.autobutton.TabIndex = 11;
            this.autobutton.Text = "Auto ";
            this.toolTip1.SetToolTip(this.autobutton, "Push to get autoreading");
            this.autobutton.UseVisualStyleBackColor = true;
            this.autobutton.Click += new System.EventHandler(this.autobutton_Click);
            // 
            // manualbutton
            // 
            this.manualbutton.Location = new System.Drawing.Point(29, 21);
            this.manualbutton.Name = "manualbutton";
            this.manualbutton.Size = new System.Drawing.Size(116, 33);
            this.manualbutton.TabIndex = 10;
            this.manualbutton.Text = "Manual ";
            this.toolTip1.SetToolTip(this.manualbutton, "Get one reading");
            this.manualbutton.UseVisualStyleBackColor = true;
            this.manualbutton.Click += new System.EventHandler(this.manualbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(743, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "About";
            this.toolTip1.SetToolTip(this.button2, "About the software");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(393, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 33);
            this.button5.TabIndex = 26;
            this.button5.Text = "Save ";
            this.toolTip1.SetToolTip(this.button5, "Push to stop autoreading\r\nand save readings\r\n");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(516, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 33);
            this.button6.TabIndex = 27;
            this.button6.Text = "Clear ";
            this.toolTip1.SetToolTip(this.button6, "Push to stop autoreading\r\nand save readings\r\n");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // retrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 530);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "retrieve";
            this.Text = "SoftSensConf";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label bitratelabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label portlabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxalarmh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxalarml;
        private System.Windows.Forms.TextBox textBoxurv;
        private System.Windows.Forms.TextBox textBoxlrv;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Button save_settings_button;
        private System.Windows.Forms.Button retrieve_settings_button;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button aboutbutton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button autobutton;
        private System.Windows.Forms.Button manualbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button disconnectbutton;
        private System.Windows.Forms.TextBox readingstextBox;
        private System.Windows.Forms.Button value_button;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statusupdate;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

