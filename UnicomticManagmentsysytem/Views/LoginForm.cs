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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            cmbrole.Items.AddRange(new string[] { "Select Your Role","Admin", "Staff", "Student", "Lecturer" });
            cmbrole.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //cmbrole.Items.AddRange(new string[] { "Admin", "Staff", "Student", "Lecturer" });
            //cmbrole.SelectedIndex = 0;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbrole.SelectedItem.ToString();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.", "Message");
                return;
            }
            var user = LoginController.Authenticate(username, password, role);

            if (user != null)
            {
                MessageBox.Show("Login successful!");

                this.Hide();
                MainForm mainForm = new MainForm(user.Role, user.Username);
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login credentials.");
            }



        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;

            txtPassword.UseSystemPasswordChar = !show;
            txtPassword.UseSystemPasswordChar = !show;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
