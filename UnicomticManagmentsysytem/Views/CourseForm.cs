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
    public partial class CourseForm : Form
    {
        private CourseController controller = new CourseController();

        public CourseForm()
        {
            InitializeComponent();
            dgvco.CellClick += dgvco_CellClick;
            LoadCourses();
            LoadDropdown();
        }
        private void LoadCourses()
        {
            dgvco.DataSource = controller.GetCoursesWithSubjects();

            // ✅ Ensure SubjectID exists and hide it
            if (dgvco.Columns.Contains("SubjectID"))
            {
                dgvco.Columns["SubjectID"].Visible = false;
            }
            else
            {
                MessageBox.Show("SubjectID column missing in grid.");
            }
        }
        private void LoadDropdown()
        {
            cmbcourse.DataSource = controller.GetAllCourses();
            cmbcourse.DisplayMember = "CourseName";
            cmbcourse.ValueMember = "CourseID";
        }

        private void LoadCourseDropdown()
        {
           
        }

       
        private void lblcourse_Click(object sender, EventArgs e)
        {

        }

        private void cmcourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        //private void LoadCoursesWithSubjects()
        //{
        //    var conn = DatabaseManager.GetConnection();

        //    string query = @"
        //SELECT 
            
        //    c.CourseName,
            
        //    s.SubjectName
        //FROM 
        //Courses_Subject cs
        //JOIN Courses c ON cs.CourseID = c.CourseID
        //JOIN Subjects s ON cs.SubjectID = s.SubjectID
        //ORDER BY c.CourseName, s.SubjectName";

        //    using (var adapter = new SQLiteDataAdapter(query, conn))
        //    {
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        dgvco.DataSource = dt;
        //    }
        //}

        private void btnadd_Click(object sender, EventArgs e)
        {
            string courseName = txtCourseName.Text.Trim();
            string subjectName = txtsub.Text.Trim();

            if (string.IsNullOrWhiteSpace(courseName) || string.IsNullOrWhiteSpace(subjectName))
            {
                MessageBox.Show("Enter both Course and Subject");
                return;
            }

            try
            {
                controller.AddCourseWithSubject(courseName, subjectName);
                MessageBox.Show("Added successfully.");
                txtCourseName.Clear();
                txtsub.Clear();
                LoadCourses();
                LoadDropdown();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string subjectName = txtsub.Text.Trim();
            if (cmbcourse.SelectedIndex == -1 || string.IsNullOrWhiteSpace(subjectName))
            {
                MessageBox.Show("Select a course and enter subject name.");
                return;
            }

            try
            {
                long courseId = Convert.ToInt64(cmbcourse.SelectedValue);
                long subjectId = controller.AddSubject(subjectName, courseId);
                controller.LinkSubjectToCourse(courseId, subjectId);
                MessageBox.Show("Subject added.");
                txtsub.Clear();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    

        private void btndel_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Select a subject to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    controller.DeleteSubject(selectedSubjectId);
                    MessageBox.Show("Subject deleted.");
                    selectedSubjectId = -1;
                    txtsub.Clear();
                    LoadCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        private long selectedSubjectId = -1;

        private void dgvco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvco.Rows[e.RowIndex];
                txtCourseName.Text = row.Cells["CourseName"].Value.ToString();
                txtsub.Text = row.Cells["SubjectName"].Value.ToString();

                try
                {
                    var val = row.Cells["SubjectID"].Value;
                    if (val != null)
                    {
                        selectedSubjectId = Convert.ToInt64(val);
                        Console.WriteLine("Selected SubjectID: " + selectedSubjectId);
                    }
                    else
                    {
                        selectedSubjectId = -1;
                        MessageBox.Show("SubjectID is null.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to get SubjectID: " + ex.Message);
                }
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Select a subject to update.");
                return;
            }

            string newName = txtsub.Text.Trim();
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Subject name cannot be empty.");
                return;
            }

            try
            {
                controller.UpdateSubject(selectedSubjectId, newName);  // ✅ CALL TO CONTROLLER
                MessageBox.Show("Subject updated.");
                selectedSubjectId = -1;
                txtsub.Clear();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
