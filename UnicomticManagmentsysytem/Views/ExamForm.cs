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
    public partial class ExamForm : Form
    {
        private long selectedExamId = -1;
        private ExamController controller = new ExamController();
        public ExamForm()
        {

            InitializeComponent();
            LoadSubjects();
            LoadExams();


        }
        private void LoadSubjects()
        {
            cmbSubjects.DataSource = controller.GetAllSubjects();
            cmbSubjects.DisplayMember = "SubjectName";
            cmbSubjects.ValueMember = "SubjectID";
        }

        private void LoadExams()
        {
            dgvExams.DataSource = controller.GetAllExamsWithSubjects();
            dgvExams.Columns["SubjectID"].Visible = false; // Optional
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExamForm_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string examName = TXTEXAM.Text.Trim();
            if (cmbSubjects.SelectedIndex == -1 || string.IsNullOrWhiteSpace(examName))
            {
                MessageBox.Show("Please enter exam name and select a subject.");
                return;
            }

            long subjectId = Convert.ToInt64(cmbSubjects.SelectedValue);

            try
            {
                DateTime examDate = dtpExamDate.Value; 
                controller.AddExam(examName, subjectId, examDate);
                MessageBox.Show("Exam added successfully!");
                TXTEXAM.Clear();
                LoadExams();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            string newName = TXTEXAM.Text.Trim();
            if (string.IsNullOrEmpty(newName) || cmbSubjects.SelectedIndex == -1)
            {
                MessageBox.Show("Enter exam name and select subject.");
                return;
            }

            long newSubjectId = Convert.ToInt64(cmbSubjects.SelectedValue);

            try
            {
                controller.UpdateExam(selectedExamId, newName, newSubjectId);
                MessageBox.Show("Exam updated.");
                selectedExamId = -1;
                TXTEXAM.Clear();
                LoadExams();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Select an exam to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    controller.DeleteExam(selectedExamId);
                    MessageBox.Show("Exam deleted.");
                    selectedExamId = -1;
                    TXTEXAM.Clear();
                    LoadExams();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed: " + ex.Message);
                }
            }

        }

        private void dgvExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvExams.Rows[e.RowIndex];
                TXTEXAM.Text = row.Cells["ExamName"].Value.ToString();
                cmbSubjects.SelectedValue = Convert.ToInt64(row.Cells["SubjectID"].Value);
                selectedExamId = Convert.ToInt64(row.Cells["ExamID"].Value);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            dgvExams.DataSource = controller.SearchExams(keyword);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }
    }
}
