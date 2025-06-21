using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomticManagmentsysytem.Models;
using UnicomticManagmentsysytem.Repositories;
using UnicomticManagmentsysytem.Views;

namespace UnicomticManagmentsysytem
{
    public partial class MainForm : Form
    {
        private string _role;
        private string _username;
        private int _userId;

        public MainForm(string role, string username,int userId)
        {
            InitializeComponent();
            _role = role;
            _username = username;
            _userId = userId;

            lblWelcome.Text = $"Welcome {_role}: {_username}";
            ApplyRolePermissions();
        }
        private void ApplyRolePermissions()
        {
            // Example role handling
            if (_role == "Student")
            {
                btnroo.Visible = false;
                btnTimetable.Visible = false;
                btnstu.Visible = false;
                btnlec.Visible = false;
                btnaddusers.Visible = false;
                btnExams.Visible = false;
                button1.Visible = false;
                btnMarks.Visible = false;
            }
            else if (_role == "Lecturer")
            {
                btnstu.Visible = false;
                btnroo.Visible = false;
                btnlec.Visible = false;
                btnTimetable.Visible =false;
                btnMarks.Visible = true;
            }
            else if (_role == "Admin")
            {
                btnTimetable.Visible = true;
                btnMarks.Visible = true;
                btnaddusers.Visible = true;
                btnExams.Visible = true; 
            }
            else if (_role == "Staff")
            {
                btnTimetable.Visible = true;
                btnMarks.Visible = true;
                btnExams.Visible = true;
            }
            //else
            //{
            //    // Hide all buttons for unknown roles
            //    btnTimetable.Visible = false;
            //    btnMarks.Visible = false;
            //    btnaddusers.Visible = false;
            //    btnExams.Visible = false;
            //}
            


        }

        //private void btnDashboard_Click(object sender, EventArgs e)
        //{
        //    LoadFormInPanel(new DashboardForm());
        //}

        private void btnCourses_Click(object sender, EventArgs e)
        {
            LoadFormInpanel(new CourseForm());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            LoadFormInpanel(new StudentForm());
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            LoadFormInpanel(new ExamForm());
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            LoadFormInpanel(new TimetableForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void LoadFormInpanel(Form form)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }
    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadFormInpanel(new TimetableForm());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaddusers_Click(object sender, EventArgs e)
        {
            LoadFormInpanel(new UsersForm(_role));
            //var usersForm = new UsersForm(_role); // assuming _role stores the current user's role
           // LoadFormInPanel(usersForm);
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide(); // Hide  dashboard
                LoginForm loginForm = new LoginForm(); // Return to login
                loginForm.Show();
                this.Close(); //  close  main form
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            ChangePassword changeForm = new ChangePassword(_userId);
            LoadFormInpanel( changeForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormInpanel(new CourseForm());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExams_Click_1(object sender, EventArgs e)
        {
            LoadFormInpanel(new ExamForm());
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            LoadFormInpanel(new MarkForm());

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            LoadFormInpanel(new RoomForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFormInpanel(new LecturerForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormInpanel(new StudentForm());
        }
    }
}