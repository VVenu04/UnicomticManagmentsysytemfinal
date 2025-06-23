using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomticManagmentsysytem.Controller;
using UnicomticManagmentsysytem.Repositories;

namespace UnicomticManagmentsysytem.Views
{
    public partial class ViewExamForm : Form
    {
        public ViewExamForm()
        {
            InitializeComponent();
            LoadExams();
        }
        private void LoadExams()
        {
            dgvExams.DataSource = ExamController.GetAllExams();
            dgvExams.ReadOnly = true;
            dgvExams.AllowUserToAddRows = false;
            dgvExams.AllowUserToDeleteRows = false;
            dgvExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        

        private void ViewExamForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }
    }
}
