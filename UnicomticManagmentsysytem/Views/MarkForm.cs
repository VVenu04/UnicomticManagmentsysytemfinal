using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomticManagmentsysytem.Controller;

namespace UnicomticManagmentsysytem.Views
{
    public partial class MarkForm : Form
    {
        private MarkController controller = new MarkController();
        public MarkForm()
        {
            InitializeComponent();
            LoadExams();
            LoadStudents();
            LoadMarks();
        }
        private void LoadExams()
        {
            cmbExam.DataSource = controller.GetAllExams();
            cmbExam.DisplayMember = "ExamName";
            cmbExam.ValueMember = "ExamID";
        }

        private void LoadStudents()
        {
            cmbStudent.DataSource = controller.GetAllStudents();
            cmbStudent.DisplayMember = "StudentName"; // or "FullName" based on your table
            cmbStudent.ValueMember = "StudentID";
        }

        private void LoadMarks()
        {
            dgvMarks.DataSource = controller.GetAllMarksWithDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbExam.SelectedIndex == -1 || cmbStudent.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Select exam, student, and enter score.");
                return;
            }

            if (!int.TryParse(txtScore.Text.Trim(), out int score))
            {
                MessageBox.Show("Enter a valid number for score.");
                return;
            }

            long examId = Convert.ToInt64(cmbExam.SelectedValue);
            long studentId = Convert.ToInt64(cmbStudent.SelectedValue);

            try
            {
                controller.AddMark(studentId, examId, score);
                MessageBox.Show("Score saved successfully!");
                //txtScore.Clear();
                LoadMarks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void MarkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
