using System;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    public partial class SignUpForm : Form
    {
        private static SignUpForm _instance = new SignUpForm();

        private static Connect _conn = new Connect();

        static SignUpForm()
        {
            _instance.InitializeComponent();
        }

        public static Connect Conn
        {
            get => _conn;
            set => _conn = value;
        }

        public static SignUpForm Instance
        {
            get => _instance;
            set => _instance = value;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            _instance.ActiveControl = label1;

        }

        private void EmailField_Enter(object sender, EventArgs e)
        {
            emailField.Clear();
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            passwordField.Clear();
        }

        private void UsernameField_Enter(object sender, EventArgs e)
        {
            usernameField.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _instance.Hide();
            _instance.ClearFields();
            MainMenuForm.Instance.Show();
        }

        public void SetFields()
        {
            _instance.emailField.Text = "Email";
            _instance.passwordField.Text = "Password";
            _instance.usernameField.Text = "Username";
        }

        public void ClearFields()
        {
            _instance.emailField.Clear();
            _instance.passwordField.Clear();
            _instance.usernameField.Clear();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            DataAccess.SignUp(usernameField.Text, passwordField.Text, emailField.Text);
        }

        /// <summary>Checks the input fields.</summary>
        /// <returns>true or false</returns>
        public bool CheckInputFields()
        {
            try
            {
                String username = usernameField.Text;
                String password = passwordField.Text;
                String email = passwordField.Text;

                if (username.ToLower().Trim().Equals("username") || password.ToLower().Trim().Equals("password") || email.ToLower().Trim().Equals("email"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void OpenHome()
        {
            MessageBox.Show("Your Account Has Been Created Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _instance.Hide();
            UserHomeForm.Instance.ActiveUsername = usernameField.Text;
            UserHomeForm.Instance.Show();
        }
    }
}