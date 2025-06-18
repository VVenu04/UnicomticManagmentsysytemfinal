namespace UnicomticManagmentsysytem.Views
{
    partial class UsersForm
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnalluser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.rdbFEMalee = new System.Windows.Forms.RadioButton();
            this.rdbMalee = new System.Windows.Forms.RadioButton();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(664, 15);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(213, 22);
            this.txtusername.TabIndex = 0;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(225, 15);
            this.cmbrole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(140, 22);
            this.cmbrole.TabIndex = 3;
            this.cmbrole.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "USER NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(254, 226);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(88, 25);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(14, 13);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(88, 25);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "⬅️ BACK\r\n\r\n\r\n";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(451, 226);
            this.btndel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(88, 25);
            this.btndel.TabIndex = 8;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnalluser
            // 
            this.btnalluser.Location = new System.Drawing.Point(664, 226);
            this.btnalluser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnalluser.Name = "btnalluser";
            this.btnalluser.Size = new System.Drawing.Size(88, 25);
            this.btnalluser.TabIndex = 9;
            this.btnalluser.Text = "ALL USER";
            this.btnalluser.UseVisualStyleBackColor = true;
            this.btnalluser.Click += new System.EventHandler(this.btnalluser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(284, 282);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(394, 167);
            this.dgvUsers.TabIndex = 10;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(225, 130);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(213, 22);
            this.txtaddress.TabIndex = 11;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(225, 46);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(213, 22);
            this.txtfname.TabIndex = 12;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(225, 102);
            this.txtage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(213, 22);
            this.txtage.TabIndex = 13;
            this.txtage.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "AGE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "ADDRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "FULL NAME";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(225, 74);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(213, 22);
            this.txtNIC.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "NIC NUM";
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(736, 101);
            this.cmbSubjects.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(140, 22);
            this.cmbSubjects.TabIndex = 21;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(648, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "SUBJECT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 14);
            this.label8.TabIndex = 23;
            this.label8.Text = "CLASS";
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(736, 139);
            this.txtclass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(158, 22);
            this.txtclass.TabIndex = 24;
            // 
            // rdbFEMalee
            // 
            this.rdbFEMalee.AutoSize = true;
            this.rdbFEMalee.Location = new System.Drawing.Point(341, 170);
            this.rdbFEMalee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbFEMalee.Name = "rdbFEMalee";
            this.rdbFEMalee.Size = new System.Drawing.Size(68, 18);
            this.rdbFEMalee.TabIndex = 25;
            this.rdbFEMalee.TabStop = true;
            this.rdbFEMalee.Text = "FEMALE";
            this.rdbFEMalee.UseVisualStyleBackColor = true;
            this.rdbFEMalee.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbMalee
            // 
            this.rdbMalee.AutoSize = true;
            this.rdbMalee.Location = new System.Drawing.Point(243, 170);
            this.rdbMalee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbMalee.Name = "rdbMalee";
            this.rdbMalee.Size = new System.Drawing.Size(56, 18);
            this.rdbMalee.TabIndex = 26;
            this.rdbMalee.TabStop = true;
            this.rdbMalee.Text = "MALE";
            this.rdbMalee.UseVisualStyleBackColor = true;
            this.rdbMalee.CheckedChanged += new System.EventHandler(this.rdbMalee_CheckedChanged);
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(736, 72);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(140, 22);
            this.cmbCourse.TabIndex = 27;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "COURSE";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.rdbFEMalee);
            this.Controls.Add(this.rdbMalee);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnalluser);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.txtusername);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnalluser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.RadioButton rdbFEMalee;
        private System.Windows.Forms.RadioButton rdbMalee;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label label2;
    }
}