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
        private long selectedMarkId = -1;
        public MarkForm()
        {
            InitializeComponent();
            LoadExams();
            LoadStudents();
            LoadMarks();
            dgvMarks.CellClick += dgvMarks_CellClick;
        }
        private void LoadExams()
        {
            cmbExam.DataSource = controller.GetAllExams();
            cmbExam.DisplayMember = "ExamName";
            cmbExam.ValueMember = "ExamID";
            cmbExam.SelectedIndex = -1;
        }

        private void LoadStudents()
        {
            cmbStudent.DataSource = controller.GetAllStudents();
            cmbStudent.DisplayMember = "StudentName"; 
            cmbStudent.ValueMember = "StudentID";
            cmbStudent.SelectedIndex = -1;
        }

        private void LoadMarks()
        {
            //dgvMarks.DataSource = controller.GetAllMarksWithDetails();
            
            
                var dt = controller.GetAllMarksWithDetails();
                dgvMarks.DataSource = dt;
                if (dgvMarks.Columns.Contains("MarkID"))
                    dgvMarks.Columns["MarkID"].Visible = false;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }
        private void MarkForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cmbExam.SelectedIndex == -1 || cmbStudent.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Select exam, student, and enter score.");
                return;
            }

            if (!int.TryParse(textBox1.Text.Trim(), out int score))
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
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving score: " + ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this mark?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                controller.DeleteMark(selectedMarkId);
                LoadMarks();
                ClearInputs();
                MessageBox.Show("Mark deleted successfully!");
            }
        }
        private void ClearInputs()
        {
            cmbStudent.SelectedIndex = -1;
            cmbExam.SelectedIndex = -1;
            textBox1.Clear();
            dgvMarks.ClearSelection();
            selectedMarkId = -1;
            button2.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int score))
            {
                MessageBox.Show("Please enter a valid numeric score.");
                return;
            }

            long studentId = Convert.ToInt64(cmbStudent.SelectedValue);
            long examId = Convert.ToInt64(cmbExam.SelectedValue);

            controller.UpdateMark(selectedMarkId, studentId, examId, score);

            LoadMarks();
            ClearInputs();
            MessageBox.Show("Mark updated successfully!");
        }

        private void dgvMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMarks.Rows[e.RowIndex];
                selectedMarkId = Convert.ToInt64(row.Cells["MarkID"].Value);
                cmbStudent.Text = row.Cells["StudentName"].Value.ToString();
                cmbExam.Text = row.Cells["ExamName"].Value.ToString();
                textBox1.Text = row.Cells["Score"].Value.ToString();

                button2.Enabled = true;
                button1.Enabled = true;
            }
        }
        private void dgvMarks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMarks.SelectedRows.Count > 0)
            {
                var row = dgvMarks.SelectedRows[0];
                selectedMarkId = Convert.ToInt64(row.Cells["MarkID"].Value);
                cmbStudent.SelectedIndex = cmbStudent.FindStringExact(row.Cells["StudentName"].Value.ToString());
                cmbExam.SelectedIndex = cmbExam.FindStringExact(row.Cells["ExamName"].Value.ToString());
                textBox1.Text = row.Cells["Score"].Value.ToString();

                button2.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                ClearInputs();
                selectedMarkId = -1;
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }
        private void dgvMarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMarks.Rows[e.RowIndex];
                selectedMarkId = Convert.ToInt64(row.Cells["MarkID"].Value);
                cmbStudent.SelectedIndex = cmbStudent.FindStringExact(row.Cells["StudentName"].Value.ToString()); 
                cmbExam.SelectedIndex = cmbExam.FindStringExact(row.Cells["ExamName"].Value.ToString());         
                textBox1.Text = row.Cells["Score"].Value.ToString();

                button2.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void cmbExam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }   
}
