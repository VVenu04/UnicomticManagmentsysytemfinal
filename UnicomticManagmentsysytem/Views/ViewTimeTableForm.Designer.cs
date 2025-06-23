namespace UnicomticManagmentsysytem.Views
{
    partial class ViewTimeTableForm
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
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Location = new System.Drawing.Point(11, 81);
            this.dgvTimetable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.Size = new System.Drawing.Size(917, 351);
            this.dgvTimetable.TabIndex = 10;
            this.dgvTimetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimetable_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 38);
            this.label4.TabIndex = 31;
            this.label4.Text = " View Timetable";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(11, 12);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(88, 25);
            this.btnback.TabIndex = 32;
            this.btnback.Text = "⬅️ BACK\r\n\r\n\r\n";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // ViewTimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(941, 470);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTimetable);
            this.Name = "ViewTimeTableForm";
            this.Text = "ViewTimeTableForm";
            this.Load += new System.EventHandler(this.ViewTimeTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnback;
    }
}