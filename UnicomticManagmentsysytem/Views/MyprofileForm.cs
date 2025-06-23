using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using UnicomticManagmentsysytem.Controller;
using UnicomticManagmentsysytem.Models;


namespace UnicomticManagmentsysytem.Views
{
    public partial class MyprofileForm : Form
    {
        //private DataGridView dgvProfile;
        private string _username;
        private string _role;
        //private string _useId;
        public MyprofileForm(string username, string role)
        {
            InitializeComponent();
            _username = username;
            _role = role;
            //_useId = userid;
            LoadProfile();
        }
        private void LoadProfile()
        {
            try
            {
                var controller = new MyprofileController();
                Myprofile user = controller.GetUserProfile(_username, _role);

                lblUsername.Text = user.Username;
                lblRole.Text = user.Role;
                lblName.Text = user.FullName;
                lblAge.Text = user.Age.ToString();
                lblAddress.Text = user.Address;
                lblNIC.Text = user.NIC;
                lblGender.Text = user.Gender;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile:\n\n" + ex.Message);
                this.Parent?.Controls.Remove(this);  // remove  profile form
            }
        }

        private void LoadUserDetails()
        {
        }



       

        private void MyprofileForm_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

        }
    }
}
