namespace LearningMgmt
{
    partial class AddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAddStudent = new Label();
            lblStuAdd = new Label();
            lblStudentName = new Label();
            lblStudentGrade = new Label();
            txtStuID = new TextBox();
            txtStuName = new TextBox();
            cmbStuGrade = new ComboBox();
            btnStuAdd = new Button();
            lblMajor = new Label();
            txtStuMajor = new TextBox();
            SuspendLayout();
            // 
            // lblAddStudent
            // 
            lblAddStudent.AutoSize = true;
            lblAddStudent.Location = new Point(1084, 174);
            lblAddStudent.Margin = new Padding(4, 0, 4, 0);
            lblAddStudent.Name = "lblAddStudent";
            lblAddStudent.Size = new Size(311, 49);
            lblAddStudent.TabIndex = 0;
            lblAddStudent.Text = "Student Records";
            // 
            // lblStuAdd
            // 
            lblStuAdd.AutoSize = true;
            lblStuAdd.Location = new Point(774, 377);
            lblStuAdd.Name = "lblStuAdd";
            lblStuAdd.Size = new Size(209, 49);
            lblStuAdd.TabIndex = 1;
            lblStuAdd.Text = "Student ID";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(774, 541);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(275, 49);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Student Name";
            // 
            // lblStudentGrade
            // 
            lblStudentGrade.AutoSize = true;
            lblStudentGrade.Location = new Point(768, 724);
            lblStudentGrade.Name = "lblStudentGrade";
            lblStudentGrade.Size = new Size(281, 49);
            lblStudentGrade.TabIndex = 3;
            lblStudentGrade.Text = "Student Grade";
            // 
            // txtStuID
            // 
            txtStuID.Location = new Point(1238, 374);
            txtStuID.Name = "txtStuID";
            txtStuID.PlaceholderText = "Student ID";
            txtStuID.Size = new Size(399, 54);
            txtStuID.TabIndex = 4;
            txtStuID.TextChanged += txtStuID_TextChanged;
            txtStuID.Validating += txtStuID_Validating;
            // 
            // txtStuName
            // 
            txtStuName.Location = new Point(1238, 538);
            txtStuName.Name = "txtStuName";
            txtStuName.PlaceholderText = "Enter Student Name";
            txtStuName.Size = new Size(399, 54);
            txtStuName.TabIndex = 5;
            // 
            // cmbStuGrade
            // 
            cmbStuGrade.FormattingEnabled = true;
            cmbStuGrade.Location = new Point(1238, 716);
            cmbStuGrade.Name = "cmbStuGrade";
            cmbStuGrade.Size = new Size(399, 57);
            cmbStuGrade.TabIndex = 6;
            // 
            // btnStuAdd
            // 
            btnStuAdd.BackColor = Color.LawnGreen;
            btnStuAdd.Location = new Point(979, 1094);
            btnStuAdd.Name = "btnStuAdd";
            btnStuAdd.Size = new Size(385, 144);
            btnStuAdd.TabIndex = 7;
            btnStuAdd.Text = "Add Student";
            btnStuAdd.UseVisualStyleBackColor = false;
            btnStuAdd.Click += btnStuAdd_Click;
            // 
            // lblMajor
            // 
            lblMajor.AutoSize = true;
            lblMajor.Location = new Point(768, 894);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(123, 49);
            lblMajor.TabIndex = 8;
            lblMajor.Text = "Major";
            // 
            // txtStuMajor
            // 
            txtStuMajor.Location = new Point(1238, 894);
            txtStuMajor.Name = "txtStuMajor";
            txtStuMajor.PlaceholderText = "Enter Major";
            txtStuMajor.Size = new Size(395, 54);
            txtStuMajor.TabIndex = 9;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(22F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3035, 1511);
            Controls.Add(txtStuMajor);
            Controls.Add(lblMajor);
            Controls.Add(btnStuAdd);
            Controls.Add(cmbStuGrade);
            Controls.Add(txtStuName);
            Controls.Add(txtStuID);
            Controls.Add(lblStudentGrade);
            Controls.Add(lblStudentName);
            Controls.Add(lblStuAdd);
            Controls.Add(lblAddStudent);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AddStudent";
            Text = "AddStudent";
            Load += AddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddStudent;
        private Label lblStuAdd;
        private Label lblStudentName;
        private Label lblStudentGrade;
        private TextBox txtStuID;
        private TextBox txtStuName;
        private ComboBox cmbStuGrade;
        private Button btnStuAdd;
        private Label lblMajor;
        private TextBox txtStuMajor;
    }
}