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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.btnaddusers = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(49, 8);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(49, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "welcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Controls.Add(this.btnChangePassword);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnlogout);
            this.panel2.Controls.Add(this.btnExams);
            this.panel2.Controls.Add(this.btnMarks);
            this.panel2.Controls.Add(this.btnTimetable);
            this.panel2.Controls.Add(this.btnaddusers);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 542);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(22, 476);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(140, 25);
            this.btnChangePassword.TabIndex = 19;
            this.btnChangePassword.Text = "CHANGED PASSWORD";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Courses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(22, 507);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(140, 23);
            this.btnlogout.TabIndex = 17;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // btnExams
            // 
            this.btnExams.Location = new System.Drawing.Point(40, 123);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(75, 23);
            this.btnExams.TabIndex = 16;
            this.btnExams.Text = "Exam";
            this.btnExams.UseVisualStyleBackColor = true;
            // 
            // btnMarks
            // 
            this.btnMarks.Location = new System.Drawing.Point(40, 84);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(75, 23);
            this.btnMarks.TabIndex = 15;
            this.btnMarks.Text = "Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            // 
            // btnTimetable
            // 
            this.btnTimetable.Location = new System.Drawing.Point(40, 55);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(75, 23);
            this.btnTimetable.TabIndex = 14;
            this.btnTimetable.Text = "TimeTable";
            this.btnTimetable.UseVisualStyleBackColor = true;
            this.btnTimetable.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnaddusers
            // 
            this.btnaddusers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnaddusers.Location = new System.Drawing.Point(23, 447);
            this.btnaddusers.Name = "btnaddusers";
            this.btnaddusers.Size = new System.Drawing.Size(139, 23);
            this.btnaddusers.TabIndex = 13;
            this.btnaddusers.Text = "ADD USER";
            this.btnaddusers.UseVisualStyleBackColor = true;
            this.btnaddusers.Click += new System.EventHandler(this.btnaddusers_Click);
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::UnicomticManagmentsysytem.Properties.Resources._1699632566323;
            this.panel.Location = new System.Drawing.Point(187, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(817, 542);
            this.panel.TabIndex = 15;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1002, 543);
            this.ControlBox = false;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

