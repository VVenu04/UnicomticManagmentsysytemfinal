namespace UnicomticManagmentsysytem.Views
{
    partial class StudentForm
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tnumAge = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(54, 250);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(777, 202);
            this.dgvStudents.TabIndex = 58;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(155, 163);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(140, 22);
            this.cmbGender.TabIndex = 57;
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(393, 192);
            this.btndel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(103, 27);
            this.btndel.TabIndex = 56;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(181, 192);
            this.btnadd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(103, 27);
            this.btnadd.TabIndex = 55;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(682, 137);
            this.txtClass.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(184, 22);
            this.txtClass.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(580, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 14);
            this.label8.TabIndex = 53;
            this.label8.Text = "CLASS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(580, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 52;
            this.label7.Text = "Cources";
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(682, 96);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(163, 22);
            this.cmbCourse.TabIndex = 51;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 50;
            this.label1.Text = "USER NAME";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(682, 40);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 48;
            this.label6.Text = "NIC NUM";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(155, 65);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(248, 22);
            this.txtNIC.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 46;
            this.label5.Text = "FULL NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 45;
            this.label4.Text = "ADDRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 44;
            this.label3.Text = "AGE";
            // 
            // tnumAge
            // 
            this.tnumAge.Location = new System.Drawing.Point(155, 95);
            this.tnumAge.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tnumAge.Name = "tnumAge";
            this.tnumAge.Size = new System.Drawing.Size(248, 22);
            this.tnumAge.TabIndex = 43;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(155, 34);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(248, 22);
            this.txtFullName.TabIndex = 42;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(155, 125);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(248, 22);
            this.txtAddress.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 192);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 27);
            this.button1.TabIndex = 59;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 14);
            this.label2.TabIndex = 60;
            this.label2.Text = "SEX";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(13, 12);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(88, 25);
            this.btnback.TabIndex = 61;
            this.btnback.Text = "⬅️ BACK\r\n\r\n\r\n";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 520);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tnumAge);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtAddress);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tnumAge;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnback;
    }
}