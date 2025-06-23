namespace UnicomticManagmentsysytem.Views
{
    partial class CourseForm
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
            this.txtsub = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvco = new System.Windows.Forms.DataGridView();
            this.btnup = new System.Windows.Forms.Button();
            this.cmbcourse = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvco)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(186, 131);
            this.txtsub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(213, 23);
            this.txtsub.TabIndex = 13;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(186, 77);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(213, 23);
            this.txtCourseName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sujject Name";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(96, 80);
            this.lblcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(81, 16);
            this.lblcourse.TabIndex = 18;
            this.lblcourse.Text = "Course Name";
            this.lblcourse.Click += new System.EventHandler(this.lblcourse_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(312, 226);
            this.btndel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(88, 29);
            this.btndel.TabIndex = 20;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnadd
            // 
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnadd.Location = new System.Drawing.Point(186, 226);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(88, 29);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvco
            // 
            this.dgvco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvco.Location = new System.Drawing.Point(145, 293);
            this.dgvco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvco.Name = "dgvco";
            this.dgvco.Size = new System.Drawing.Size(392, 223);
            this.dgvco.TabIndex = 21;
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(436, 226);
            this.btnup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(88, 29);
            this.btnup.TabIndex = 22;
            this.btnup.Text = "UPDATE";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // cmbcourse
            // 
            this.cmbcourse.FormattingEnabled = true;
            this.cmbcourse.Location = new System.Drawing.Point(660, 70);
            this.cmbcourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbcourse.Name = "cmbcourse";
            this.cmbcourse.Size = new System.Drawing.Size(140, 24);
            this.cmbcourse.TabIndex = 23;
            this.cmbcourse.SelectedIndexChanged += new System.EventHandler(this.cmcourse_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "ADD Suject For Exiting Cource";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(14, 15);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(88, 29);
            this.btnback.TabIndex = 26;
            this.btnback.Text = "⬅️ BACK\r\n\r\n\r\n";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(544, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 365);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UnicomticManagmentsysytem.Properties.Resources.WhatsApp_Image_2025_06_20_at_12_46_15_PM;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 38);
            this.label4.TabIndex = 31;
            this.label4.Text = "Manage Course";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbcourse);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.dgvco);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtsub);
            this.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CourseForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvco)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvco;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.ComboBox cmbcourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}