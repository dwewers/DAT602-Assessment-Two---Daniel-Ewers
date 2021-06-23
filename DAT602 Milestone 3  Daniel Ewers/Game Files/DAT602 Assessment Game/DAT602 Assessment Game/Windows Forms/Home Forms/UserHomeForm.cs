using System;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    public partial class UserHomeForm : Form
    {
        private static UserHomeForm _instance = new UserHomeForm();

        private static Connect _conn = new Connect();

        static UserHomeForm()
        {
            _instance.InitializeComponent();
        }

        public static Connect Conn
        {
            get => _conn;
            set => _conn = value;
        }

        public static UserHomeForm Instance
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

        public void DeleteBtn_Click(object sender, EventArgs e)
        {
            ConfirmDelete();
        }

        private void GameBtn_Click(object sender, EventArgs e)
        {
            GameLobbyForm.Instance.ActiveUsername = _activeUsername;
            GameLobbyForm.Instance.LoadLobbyData();
            GameLobbyForm.Instance.Show();
        }

        /// <summary>Confirms the logout.</summary>
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

        /// <summary>Confirms the delete.</summary>
        public void ConfirmDelete()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (dialogResult == DialogResult.Yes)
            {
                DataAccess.UserDeleteAccount(_activeUsername);
                MessageBox.Show("Account deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _instance.Hide();
                MainMenuForm.Instance.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        /// <summary>Opens the lobby.</summary>
        public static void OpenLobby(string usernameText)
        {
            GameLobbyForm.Instance.ActiveUsername = usernameText;
            _instance.Hide();
            GameLobbyForm.Instance.Show();
        }

        private void UserHomeForm_Load(object sender, EventArgs e)
        {
            _instance.usernameTextBox.Text = _instance._activeUsername;
        }
    }
}