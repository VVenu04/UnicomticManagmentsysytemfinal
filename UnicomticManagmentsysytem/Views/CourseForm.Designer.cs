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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvco)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(159, 107);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(183, 20);
            this.txtsub.TabIndex = 13;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(159, 62);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(183, 20);
            this.txtCourseName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sujject Name";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(82, 65);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(71, 13);
            this.lblcourse.TabIndex = 18;
            this.lblcourse.Text = "Course Name";
            this.lblcourse.Click += new System.EventHandler(this.lblcourse_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(281, 184);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 20;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(159, 184);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvco
            // 
            this.dgvco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvco.Location = new System.Drawing.Point(183, 245);
            this.dgvco.Name = "dgvco";
            this.dgvco.Size = new System.Drawing.Size(377, 155);
            this.dgvco.TabIndex = 21;
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(403, 184);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 23);
            this.btnup.TabIndex = 22;
            this.btnup.Text = "UPDATE";
            this.btnup.UseVisualStyleBackColor = true;
            // 
            // cmbcourse
            // 
            this.cmbcourse.FormattingEnabled = true;
            this.cmbcourse.Location = new System.Drawing.Point(159, 24);
            this.cmbcourse.Name = "cmbcourse";
            this.cmbcourse.Size = new System.Drawing.Size(121, 21);
            this.cmbcourse.TabIndex = 23;
            this.cmbcourse.SelectedIndexChanged += new System.EventHandler(this.cmcourse_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(295, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Add subject";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cmbcourse);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.dgvco);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtsub);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvco)).EndInit();
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
        private System.Windows.Forms.RadioButton radioButton1;
    }
}