using System;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    public partial class AdminSettingsForm : Form
    {
        static AdminSettingsForm()
        {
            _instance.InitializeComponent();
        }

        private static AdminSettingsForm _instance = new AdminSettingsForm();

        private static Connect _conn = new Connect();

        public static Connect Conn
        {
            get => _conn;
            set => _conn = value;
        }

        public static AdminSettingsForm Instance
        {
            get => _instance;
            set => _instance = value;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            DataAccess.LoadSettingsData();
        }

        /// <summary>Edits the user.</summary>
        public void EditUser()
        {
            if (playerComboBx.SelectedItem == null)
            {
                MessageBox.Show("Player is not a player. Please select a real player", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                DataAccess.LoadUserData(playerComboBx.SelectedItem.ToString());
                AdminUpdateUserForm.Instance.Show();
                _instance.Hide();
            }
        }

        /// <summary>Confirms the delete game.</summary>
        public void ConfirmDeleteGame()
        {
            if (gameComboBx.SelectedItem == null)
            {
                MessageBox.Show("Game is not a game number. Please select a real number", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //End Game
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To End The Game", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.Yes)
                {
                    DataAccess.DeleteGame(gameComboBx.Text);
                    MessageBox.Show("Game Ended Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _instance.Hide();
                    _instance.gameComboBx.Items.Remove(gameComboBx.SelectedItem);
                    _instance.gameComboBx.Text = "";
                    _instance.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        /// <summary>Confirms the delete user.</summary>
        public void ConfirmDeleteUser()
        {
            if (playerComboBx.SelectedItem == null)
            {
                MessageBox.Show("You can not delete this player. Try selecting another one.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.Yes)
                {
                    DataAccess.AdminDeleteAccount(playerComboBx.Text);
                    MessageBox.Show("User deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _instance.Hide();
                    _instance.playerComboBx.Items.Remove(playerComboBx.SelectedItem);
                    _instance.playerComboBx.Text = "";
                    _instance.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void EndGameBtn_Click_1(object sender, EventArgs e)
        {
            ConfirmDeleteGame();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
        }

        private void CreateBtn_Click_1(object sender, EventArgs e)
        {
            AdminCreateUserForm.Instance.Show();
            _instance.Hide();
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            ConfirmDeleteUser();
        }

        private void ResetScoreBtn_Click_1(object sender, EventArgs e)
        {
            DataAccess.ResetPlayer(playerComboBx.Text);
            MessageBox.Show("Player Reset Successful");
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            EditUser();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            _instance.Hide();
            AdminHomeForm.Instance.Show();
        }
    }
}