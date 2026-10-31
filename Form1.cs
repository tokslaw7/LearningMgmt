namespace LearningMgmt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Teacher" && txtPassword.Text == "Admin")
            {
                MessageBox.Show("Login successful! & Welcome to Student Learning Management System.");
                // Proceed to the next form or functionality
                DashBoard dashboard = new DashBoard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
