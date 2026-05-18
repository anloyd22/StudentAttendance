using System;
using System.Windows.Forms;

namespace attendance.PAL.FORMS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxName.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                labelError.Text = "Please enter username and password";
                labelError.Visible = true;
                return;
            }

            // Design muna - walang database
            MessageBox.Show($"Login Successful! Welcome {username}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelError.Visible = false;
        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact your administrator to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (labelError.Visible == true)
            {
                labelError.Visible = false;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (labelError.Visible == true)
            {
                labelError.Visible = false;
            }
        }
    }
}