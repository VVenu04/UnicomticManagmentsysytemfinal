namespace UnicomticManagmentsysytem
{
    partial class MainForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnroo = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnaddusers = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.btnlec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.btnstu = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(11, 8);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(64, 15);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "welcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.btnstu);
            this.panel2.Controls.Add(this.btnlec);
            this.panel2.Controls.Add(this.btnroo);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Controls.Add(this.btnChangePassword);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnlogout);
            this.panel2.Controls.Add(this.btnExams);
            this.panel2.Controls.Add(this.btnMarks);
            this.panel2.Controls.Add(this.btnTimetable);
            this.panel2.Controls.Add(this.btnaddusers);
            this.panel2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 639);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnroo
            // 
            this.btnroo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnroo.Location = new System.Drawing.Point(0, 185);
            this.btnroo.Name = "btnroo";
            this.btnroo.Size = new System.Drawing.Size(186, 27);
            this.btnroo.TabIndex = 20;
            this.btnroo.Text = "Manage Room";
            this.btnroo.UseVisualStyleBackColor = true;
            this.btnroo.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangePassword.Location = new System.Drawing.Point(3, 476);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(183, 25);
            this.btnChangePassword.TabIndex = 19;
            this.btnChangePassword.Text = "CHANGED PASSWORD";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(3, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Courses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlogout.Location = new System.Drawing.Point(0, 507);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(186, 27);
            this.btnlogout.TabIndex = 17;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // btnExams
            // 
            this.btnExams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExams.Location = new System.Drawing.Point(0, 90);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(186, 27);
            this.btnExams.TabIndex = 16;
            this.btnExams.Text = "Exam";
            this.btnExams.UseVisualStyleBackColor = true;
            this.btnExams.Click += new System.EventHandler(this.btnExams_Click_1);
            // 
            // btnMarks
            // 
            this.btnMarks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarks.Location = new System.Drawing.Point(0, 218);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(186, 27);
            this.btnMarks.TabIndex = 15;
            this.btnMarks.Text = "Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // btnTimetable
            // 
            this.btnTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimetable.Location = new System.Drawing.Point(3, 152);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(186, 27);
            this.btnTimetable.TabIndex = 14;
            this.btnTimetable.Text = "TimeTable";
            this.btnTimetable.UseVisualStyleBackColor = true;
            this.btnTimetable.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnaddusers
            // 
            this.btnaddusers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddusers.Location = new System.Drawing.Point(3, 57);
            this.btnaddusers.Name = "btnaddusers";
            this.btnaddusers.Size = new System.Drawing.Size(186, 27);
            this.btnaddusers.TabIndex = 13;
            this.btnaddusers.Text = "ADD USER";
            this.btnaddusers.UseVisualStyleBackColor = true;
            this.btnaddusers.Click += new System.EventHandler(this.btnaddusers_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // btnlec
            // 
            this.btnlec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlec.Location = new System.Drawing.Point(0, 251);
            this.btnlec.Name = "btnlec";
            this.btnlec.Size = new System.Drawing.Size(186, 27);
            this.btnlec.TabIndex = 21;
            this.btnlec.Text = "Manage lecturer";
            this.btnlec.UseVisualStyleBackColor = true;
            this.btnlec.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = global::UnicomticManagmentsysytem.Properties.Resources.WhatsApp_Image_2025_06_18_at_12_27_10_PM;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(187, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(965, 84);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::UnicomticManagmentsysytem.Properties.Resources.kimberly_farmer_lUaaKCUANVI_unsplash;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(187, 85);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(965, 555);
            this.panel.TabIndex = 15;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // btnstu
            // 
            this.btnstu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstu.Location = new System.Drawing.Point(0, 284);
            this.btnstu.Name = "btnstu";
            this.btnstu.Size = new System.Drawing.Size(186, 27);
            this.btnstu.TabIndex = 22;
            this.btnstu.Text = "Manage Students";
            this.btnstu.UseVisualStyleBackColor = true;
            this.btnstu.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1152, 637);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnaddusers;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Button btnroo;
        private System.Windows.Forms.Button btnlec;
        private System.Windows.Forms.Button btnstu;
    }
}

