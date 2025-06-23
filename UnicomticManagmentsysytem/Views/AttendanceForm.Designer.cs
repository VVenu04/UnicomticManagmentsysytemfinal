namespace UnicomticManagmentsysytem.Views
{
    partial class AttendanceForm
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
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnmark = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(303, 98);
            this.cmbStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(140, 22);
            this.cmbStudent.TabIndex = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(303, 208);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(140, 22);
            this.cmbStatus.TabIndex = 1;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(303, 146);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(140, 22);
            this.cmbSubject.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(223, 155);
            this.Subject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(45, 14);
            this.Subject.TabIndex = 5;
            this.Subject.Text = "Subject";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(576, 99);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(233, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // btnmark
            // 
            this.btnmark.Location = new System.Drawing.Point(341, 260);
            this.btnmark.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnmark.Name = "btnmark";
            this.btnmark.Size = new System.Drawing.Size(88, 25);
            this.btnmark.TabIndex = 7;
            this.btnmark.Text = "Mark";
            this.btnmark.UseVisualStyleBackColor = true;
            this.btnmark.Click += new System.EventHandler(this.btnmark_Click);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(259, 307);
            this.dgvAttendance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.Size = new System.Drawing.Size(570, 223);
            this.dgvAttendance.TabIndex = 8;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 595);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.btnmark);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbStudent);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnmark;
        private System.Windows.Forms.DataGridView dgvAttendance;
    }
}