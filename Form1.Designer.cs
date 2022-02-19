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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Send_button = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.next_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bitratelabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.portlabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.process1 = new System.Diagnostics.Process();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.Send_button);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.next_button);
            this.tabPage1.Controls.Add(this.connect_button);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.bitratelabel);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.portlabel);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connect";
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(74, 255);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(121, 25);
            this.Send_button.TabIndex = 9;
            this.Send_button.Text = "Send command";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "readconf"});
            this.comboBox3.Location = new System.Drawing.Point(71, 204);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 8;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(600, 400);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(75, 23);
            this.next_button.TabIndex = 7;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(71, 156);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(121, 25);
            this.connect_button.TabIndex = 5;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 169);
            this.textBox1.TabIndex = 4;
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
            "9600"});
            this.comboBox2.Location = new System.Drawing.Point(71, 110);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 2;
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
            this.comboBox1.Items.AddRange(new object[] {
            "COM3"});
            this.comboBox1.Location = new System.Drawing.Point(71, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.save_settings_button);
            this.tabPage2.Controls.Add(this.retrieve_settings_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(190, 273);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(266, 195);
            this.textBox7.TabIndex = 4;
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
            this.panel1.Location = new System.Drawing.Point(190, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 211);
            this.panel1.TabIndex = 3;
            // 
            // textBoxalarmh
            // 
            this.textBoxalarmh.Location = new System.Drawing.Point(107, 145);
            this.textBoxalarmh.Name = "textBoxalarmh";
            this.textBoxalarmh.Size = new System.Drawing.Size(100, 22);
            this.textBoxalarmh.TabIndex = 11;
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
            // 
            // textBoxurv
            // 
            this.textBoxurv.Location = new System.Drawing.Point(107, 89);
            this.textBoxurv.Name = "textBoxurv";
            this.textBoxurv.Size = new System.Drawing.Size(100, 22);
            this.textBoxurv.TabIndex = 4;
            // 
            // textBoxlrv
            // 
            this.textBoxlrv.Location = new System.Drawing.Point(107, 61);
            this.textBoxlrv.Name = "textBoxlrv";
            this.textBoxlrv.Size = new System.Drawing.Size(100, 22);
            this.textBoxlrv.TabIndex = 3;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(107, 33);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 22);
            this.textBoxname.TabIndex = 2;
            // 
            // save_settings_button
            // 
            this.save_settings_button.Location = new System.Drawing.Point(472, 91);
            this.save_settings_button.Name = "save_settings_button";
            this.save_settings_button.Size = new System.Drawing.Size(121, 47);
            this.save_settings_button.TabIndex = 1;
            this.save_settings_button.Text = "Save new settings";
            this.save_settings_button.UseVisualStyleBackColor = true;
            this.save_settings_button.Click += new System.EventHandler(this.save_settings_button_Click);
            // 
            // retrieve_settings_button
            // 
            this.retrieve_settings_button.Location = new System.Drawing.Point(53, 88);
            this.retrieve_settings_button.Name = "retrieve_settings_button";
            this.retrieve_settings_button.Size = new System.Drawing.Size(121, 47);
            this.retrieve_settings_button.TabIndex = 0;
            this.retrieve_settings_button.Text = "Retrieve settings";
            this.retrieve_settings_button.UseVisualStyleBackColor = true;
            this.retrieve_settings_button.Click += new System.EventHandler(this.retrieve_settings_button_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(862, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sensor data";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(862, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // retrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 623);
            this.Controls.Add(this.tabControl1);
            this.Name = "retrieve";
            this.Text = "SoftSensConf";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label bitratelabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label portlabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Button next_button;
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
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

