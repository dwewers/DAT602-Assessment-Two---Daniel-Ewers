using System;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    public partial class AdminCreateUserForm : Form
    {
        private static AdminCreateUserForm _instance = new AdminCreateUserForm();

        private static Connect _conn = new Connect();

        static AdminCreateUserForm()
        {
            _instance.InitializeComponent();
        }

        public static Connect Conn
        {
            get => _conn;
            set => _conn = value;
        }

        public static AdminCreateUserForm Instance
        {
            get => _instance;
            set => _instance = value;
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            _instance.ActiveControl = label1;
        }

        private void EmailField_Enter_1(object sender, EventArgs e)
        {
            string email = _instance.emailField.Text;
            if (email.ToLower().Trim().Equals("email"))
            {
                _instance.emailField.Text = "";
            }
        }

        private void EmailField_Leave_1(object sender, EventArgs e)
        {
            string email = _instance.emailField.Text;
            if (email.ToLower().Trim().Equals("email") || email.Trim().Equals(""))
            {
                _instance.emailField.Text = "Email";
            }
        }

        private void PasswordField_Enter_1(object sender, EventArgs e)
        {
            string password = _instance.passwordField.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                _instance.passwordField.Text = "";
            }
        }

        private void PasswordField_Leave_1(object sender, EventArgs e)
        {
            string password = _instance.passwordField.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                _instance.passwordField.Text = "Password";
            }
        }

        private void UsernameField_Enter_1(object sender, EventArgs e)
        {
            string username = _instance.usernameField.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                _instance.usernameField.Text = "";
            }
        }

        private void UsernameField_Leave(object sender, EventArgs e)
        {
            string username = _instance.usernameField.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
            {
                _instance.usernameField.Text = "Username";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            _instance.Hide();
            AdminSettingsForm.Instance.Show();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            DataAccess.AdminCreateUser(usernameField.Text, passwordField.Text, emailField.Text, adminCheckBox);
        }

        private void AdminCheckBox_MouseHover(object sender, EventArgs e)
        {
            _instance.toolTip1.Show("When checked, gives user admin rights", _instance.adminCheckBox);
        }

        public bool CheckInputFields()
        {
            if (usernameField.Text.ToLower().Trim().Equals("username") ||
                passwordField.Text.ToLower().Trim().Equals("password") ||
                emailField.Text.ToLower().Trim().Equals("email"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OpenSettings()
        {
            MessageBox.Show("Account Has Been Created Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _instance.Hide();
            AdminSettingsForm.Instance.Show();
        }
    }
}