namespace UnicomticManagmentsysytem.Views
{
    partial class MarkForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbExam = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Exam";
            // 
            // cmbExam
            // 
            this.cmbExam.FormattingEnabled = true;
            this.cmbExam.Location = new System.Drawing.Point(170, 33);
            this.cmbExam.Name = "cmbExam";
            this.cmbExam.Size = new System.Drawing.Size(197, 21);
            this.cmbExam.TabIndex = 1;
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(170, 76);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(197, 21);
            this.cmbStudent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Student";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Location = new System.Drawing.Point(77, 125);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(35, 13);
            this.txtScore.TabIndex = 5;
            this.txtScore.Text = "Score";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(262, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ADD";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvMarks
            // 
            this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarks.Location = new System.Drawing.Point(138, 249);
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.Size = new System.Drawing.Size(507, 150);
            this.dgvMarks.TabIndex = 7;
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMarks);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.cmbExam);
            this.Controls.Add(this.label1);
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            this.Load += new System.EventHandler(this.MarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbExam;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvMarks;
    }
}