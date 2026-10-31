using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LearningMgmt
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            cmbStuGrade.DataSource = Enum.GetValues(typeof(Grade));
        }

        private void btnStuAdd_Click(object sender, EventArgs e)
        {
            if (txtStuName.Text != "" && txtStuID.Text != "" && txtStuMajor.Text != "")
            {
                var newStudent = new Student();

                newStudent.StudentID = int.Parse(txtStuID.Text);
                newStudent.StudentName = txtStuName.Text;
                newStudent.grade = (Grade)cmbStuGrade.SelectedIndex + 1;
                newStudent.Major = txtStuMajor.Text;


                Data.StudentList.Add(newStudent);
                MessageBox.Show("Student added successfully.");
                this.Close();

            }
        }

        private void txtStuID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStuID_Validating(object sender, CancelEventArgs e)
        {
            if(txtStuID.Text.Length != 0)
            {
                int value;
                if (!int.TryParse(txtStuID.Text, out value))
                {
                    MessageBox.Show("Please enter a valid number for Student ID");
                    e.Cancel = true;
                    txtStuID.Clear();
                }
                else if(int.Parse(txtStuID.Text) <= 0 )
                {
                    MessageBox.Show("Please enter a 4-digit number for Student ID");
                    e.Cancel = true;
                    txtStuID.Clear();
                }
            }
        }
    }
}