namespace eprii
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            label9 = new Label();
            label6 = new Label();
            label10 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            button1 = new Button();
            label14 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            label15 = new Label();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo4;
            pictureBox1.Location = new Point(11, 10);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(467, 226);
            label1.Name = "label1";
            label1.Size = new Size(115, 30);
            label1.TabIndex = 4;
            label1.Text = "µTMapS";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(102, 300);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 111);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(70, 68);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 19);
            label7.TabIndex = 3;
            label7.Text = "Sensor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(195, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 28);
            label2.TabIndex = 2;
            label2.Text = "°C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(70, 29);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 24);
            label3.TabIndex = 1;
            label3.Text = "NA";
            label3.Click += label3_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.GrayText;
            iconPictureBox1.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TemperatureUp;
            iconPictureBox1.IconColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 64;
            iconPictureBox1.Location = new Point(2, 11);
            iconPictureBox1.Margin = new Padding(2, 1, 2, 1);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(64, 80);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(iconPictureBox2);
            panel2.Location = new Point(400, 300);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 111);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(67, 68);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 19);
            label8.TabIndex = 4;
            label8.Text = "Sensor 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(197, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 28);
            label4.TabIndex = 3;
            label4.Text = "°C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GrayText;
            label5.Font = new Font("Rockwell", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(67, 29);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 24);
            label5.TabIndex = 2;
            label5.Text = "NA";
            label5.Click += label5_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.GrayText;
            iconPictureBox2.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.TemperatureUp;
            iconPictureBox2.IconColor = SystemColors.ControlLightLight;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 61;
            iconPictureBox2.Location = new Point(2, 11);
            iconPictureBox2.Margin = new Padding(2, 1, 2, 1);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(61, 80);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GrayText;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(iconPictureBox3);
            panel3.Location = new Point(697, 300);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 111);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(75, 68);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 19);
            label9.TabIndex = 4;
            label9.Text = "Sensor 3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(195, 5);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 28);
            label6.TabIndex = 4;
            label6.Text = "°C";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(75, 29);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(40, 24);
            label10.TabIndex = 3;
            label10.Text = "NA";
            label10.Click += label10_Click;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = SystemColors.GrayText;
            iconPictureBox3.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.TemperatureUp;
            iconPictureBox3.IconColor = SystemColors.ControlLightLight;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 59;
            iconPictureBox3.Location = new Point(2, 19);
            iconPictureBox3.Margin = new Padding(2, 1, 2, 1);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(59, 73);
            iconPictureBox3.TabIndex = 0;
            iconPictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GrayText;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(iconPictureBox4);
            panel4.Location = new Point(402, 470);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 111);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLight;
            label11.Location = new Point(64, 61);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(114, 19);
            label11.TabIndex = 4;
            label11.Text = "Safety Sensor";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Rockwell", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlLight;
            label12.Location = new Point(195, 0);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(39, 28);
            label12.TabIndex = 4;
            label12.Text = "°C";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Rockwell", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlLight;
            label13.Location = new Point(73, 24);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(40, 24);
            label13.TabIndex = 3;
            label13.Text = "NA";
            label13.Click += label13_Click;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = SystemColors.GrayText;
            iconPictureBox4.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.TemperatureUp;
            iconPictureBox4.IconColor = SystemColors.ControlLightLight;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 54;
            iconPictureBox4.Location = new Point(2, 11);
            iconPictureBox4.Margin = new Padding(2, 1, 2, 1);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(54, 76);
            iconPictureBox4.TabIndex = 0;
            iconPictureBox4.TabStop = false;
            iconPictureBox4.Click += iconPictureBox4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(485, 612);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(81, 35);
            button1.TabIndex = 9;
            button1.Text = "Stop";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(339, 678);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(376, 17);
            label14.TabIndex = 10;
            label14.Text = "*Click Stop to Terminate the Temperature Measurement*";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = SystemColors.ControlDark;
            iconPictureBox5.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconPictureBox5.IconColor = SystemColors.ControlLightLight;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 36;
            iconPictureBox5.Location = new Point(983, 1);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(36, 36);
            iconPictureBox5.TabIndex = 11;
            iconPictureBox5.TabStop = false;
            iconPictureBox5.Click += iconPictureBox5_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(881, 96);
            label15.Name = "label15";
            label15.Size = new Size(125, 28);
            label15.TabIndex = 12;
            label15.Text = "NO ERRORS";
            label15.Click += label15_Click;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = SystemColors.ControlText;
            iconPictureBox6.ForeColor = Color.Red;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            iconPictureBox6.IconColor = Color.Red;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 52;
            iconPictureBox6.Location = new Point(821, 65);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(54, 52);
            iconPictureBox6.TabIndex = 13;
            iconPictureBox6.TabStop = false;
            iconPictureBox6.Click += iconPictureBox6_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(892, 61);
            label16.Name = "label16";
            label16.Size = new Size(100, 28);
            label16.TabIndex = 14;
            label16.Text = "ER CODE:";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Rockwell", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(12, 151);
            label17.Name = "label17";
            label17.Size = new Size(127, 22);
            label17.TabIndex = 15;
            label17.Text = "Last Data on:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Rockwell", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.PaleGreen;
            label18.Location = new Point(11, 183);
            label18.Name = "label18";
            label18.Size = new Size(106, 24);
            label18.TabIndex = 16;
            label18.Text = "Loading..";
            label18.Click += label18_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Rockwell", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(837, 151);
            label19.Name = "label19";
            label19.RightToLeft = RightToLeft.No;
            label19.Size = new Size(135, 22);
            label19.TabIndex = 17;
            label19.Text = "Current Time:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Rockwell", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.PaleGreen;
            label20.Location = new Point(787, 183);
            label20.Name = "label20";
            label20.Size = new Size(106, 24);
            label20.TabIndex = 18;
            label20.Text = "Loading..";
            label20.Click += label20_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1008, 729);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(iconPictureBox6);
            Controls.Add(label15);
            Controls.Add(iconPictureBox5);
            Controls.Add(label14);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            RightToLeftLayout = true;
            Text = "Xyma Analytics";
            Load += Form3_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label7;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private Label label8;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel panel3;
        private Label label9;
        private Label label6;
        private Label label10;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Panel panel4;
        private Label label11;
        private Label label12;
        private Label label13;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Button button1;
        private Label label14;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Label label15;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private System.Windows.Forms.Timer timer2;
    }
}