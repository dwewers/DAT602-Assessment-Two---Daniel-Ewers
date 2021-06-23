using System;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    public partial class LoginForm : Form
    {
        private static LoginForm _instance = new LoginForm();

        private static Connect _conn = new Connect();

        static LoginForm()
        {
            _instance.InitializeComponent();
        }

        public static Connect Conn
        {
            get => _conn;
            set => _conn = value;
        }

        public static LoginForm Instance
        {
            get => _instance;
            set => _instance = value;
        }

        private void UsernameField_Enter(object sender, EventArgs e)
        {
            String username = usernameField.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                usernameField.Text = "";
            }
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            String password = passwordField.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                passwordField.Text = "";
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            _instance.Hide();
            MainMenuForm.Instance.Show();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            DataAccess.CheckValidLogin(usernameField.Text, passwordField.Text);
        }

        /// <summary>Checks the input fields.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public bool CheckInputFields()
        {
            String username = usernameField.Text;
            String password = passwordField.Text;
            if (username.ToLower().Trim().Equals("username") || password.ToLower().Trim().Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>Sets the logged in.</summary>

        /// <summary>Opens the create acc.</summary>
        public void OpenCreateAcc()
        {
            DialogResult dialogResult = MessageBox.Show("Password is incorrect or username does not, would you like to create a new account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                _instance.Hide();
                SignUpForm.Instance.Show();
            }
        }

        public void OpenMenu(string username)
        {
            if (DataAccess.CheckLock(username))
            {
                MessageBox.Show("Account is perma locked. To unlock account, please contact an admin at daniel-ewers2@live.nmit.ac.nz", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                /*Login Success for Admin*/
                if (!DataAccess.CheckIfAdmin(username))
                {
                    DataAccess.SetLoggedIn(username);
                    _instance.ClearFields();
                    _instance.Hide();

                    AdminHomeForm.Instance.ActiveUsername = username;
                    AdminHomeForm.Instance.Show();
                }
                else if (DataAccess.CheckIfAdmin(username))
                {
                    /*Login Success for user*/
                    DataAccess.SetLoggedIn(username);
                    _instance.ClearFields();
                    _instance.Hide();
                    UserHomeForm.Instance.ActiveUsername = username;
                    UserHomeForm.Instance.Show();
                }
            }
        }

        private void ClearFields()
        {
            usernameField.Text = "Username";
            passwordField.Text = "Password";
        }
    }
}