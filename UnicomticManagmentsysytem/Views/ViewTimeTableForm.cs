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
    public partial class ViewTimeTableForm : Form
    {
        public ViewTimeTableForm()
        {
            InitializeComponent();
            LoadTimetable();
        }
        private void LoadTimetable()
        {
            dgvTimetable.DataSource = TimetableController.GetAllTimetables();
            dgvTimetable.ReadOnly = true;
            dgvTimetable.AllowUserToAddRows = false;
            dgvTimetable.AllowUserToDeleteRows = false;
            dgvTimetable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvTimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewTimeTableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
