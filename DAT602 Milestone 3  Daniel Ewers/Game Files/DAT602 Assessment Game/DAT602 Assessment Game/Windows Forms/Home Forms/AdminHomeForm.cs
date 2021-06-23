using System;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    public partial class AdminHomeForm : Form
    {
        private static AdminHomeForm _instance = new AdminHomeForm();

        private static Connect _conn = new Connect();

        static AdminHomeForm()
        {
            _instance.InitializeComponent();
            _instance.usernameTextBox.Text = _instance._activeUsername;
        }

        public static Connect Conn
        {
            get => _conn;
            set => _conn = value;
        }

        public static AdminHomeForm Instance
        {
            get => _instance;
            set => _instance = value;
        }

        public string ActiveUsername { get => _activeUsername; set => _activeUsername = value; }

        private string _activeUsername;

        private void Button1_Click(object sender, EventArgs e)
        {
            ConfirmLogout();
        }

        private void LeaderboardBtn_Click(object sender, EventArgs e)
        {
            _instance.Hide();
            LeaderboardForm.Instance.ActiveUsername = _activeUsername;
            DataAccess.GetLeaderboardData();
            LeaderboardForm.Instance.Show();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            _instance.Hide();
            AdminSettingsForm.Instance.LoadData();
            AdminSettingsForm.Instance.Show();
        }

        private void GameBtn_Click(object sender, EventArgs e)
        {
            _instance.Hide();
            GameLobbyForm.Instance.ActiveUsername = _activeUsername;
            GameLobbyForm.Instance.LoadLobbyData();
            GameLobbyForm.Instance.Show();
        }

        public void ConfirmLogout()
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You want to Log Out", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (dialogResult == DialogResult.Yes)
            {
                DataAccess.Logout(_activeUsername);
                _instance.Hide();
                MainMenuForm.Instance.Show();
            }
            else
            {
                return;
            }
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            _instance.usernameTextBox.Text = _instance._activeUsername;
        }
    }
}