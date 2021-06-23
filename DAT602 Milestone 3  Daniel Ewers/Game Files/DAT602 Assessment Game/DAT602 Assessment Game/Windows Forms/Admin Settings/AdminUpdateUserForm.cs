using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    public partial class AdminUpdateUserForm : Form
    {
        private static AdminUpdateUserForm _instance = new AdminUpdateUserForm();

        private static readonly Connect _conn = new Connect();

        public static AdminUpdateUserForm Instance { get => _instance; set => _instance = value; }

        static AdminUpdateUserForm()
        {
            _instance.InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
        }

        private void UsernameField_Enter(object sender, EventArgs e)
        {
            usernameField.Text = "";
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            passwordField.Text = "";
        }

        private void EmailField_Enter(object sender, EventArgs e)
        {
            emailField.Text = "";
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            _instance.Hide();
            AdminSettingsForm.Instance.Show();
        }

        private void AdminCheckBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("When checked, gives user admin rights", adminCheckBox);
        }

        private void UnlockAccCheckBox_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("When checked, locks players account", unlockAccCheckBox);
        }

        public Boolean CheckInputFields()
        {
            string username = usernameField.Text;
            string password = passwordField.Text;
            string email = passwordField.Text;

            if (username.ToLower().Trim().Equals("username") || password.ToLower().Trim().Equals("password") || email.ToLower().Trim().Equals("email"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>Confirms this instance.</summary>
        public void Confirm()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to change these details?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {
                DataAccess.UpdateUser(usernameField.Text, passwordField.Text, emailField.Text, unlockAccCheckBox.Checked, adminCheckBox.Checked);
                _instance.Hide();
                AdminSettingsForm.Instance.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}