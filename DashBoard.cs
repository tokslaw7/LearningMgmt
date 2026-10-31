using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LearningMgmt
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            stuGrid.DataSource = Data.StudentList;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            stuGrid.DataSource = null;
            stuGrid.DataSource = Data.StudentList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the selected student?", "Please Confirm", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Data.StudentList.RemoveAt(stuGrid.SelectedRows[0].Index);
                stuGrid.DataSource = null;
                stuGrid.DataSource = Data.StudentList;
                MessageBox.Show("Student deleted successfully.");

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }
    }
}
