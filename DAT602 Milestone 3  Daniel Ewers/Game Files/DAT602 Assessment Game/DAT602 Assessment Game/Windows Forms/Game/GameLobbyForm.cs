using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    public partial class GameLobbyForm : Form
    {
        private static GameLobbyForm _instance = new GameLobbyForm();

        private static Connect _conn = new Connect();

        static GameLobbyForm()
        {
            _instance.InitializeComponent();
            //_instance.GetData();
        }

        public static Connect Conn
        {
            get => _conn;
            set => _conn = value;
        }

        public static GameLobbyForm Instance
        {
            get => _instance;
            set => _instance = value;
        }

        /// <summary>Gets or sets the active username.</summary>
        /// <value>The active username.</value>
        public string ActiveUsername
        {
            get { return Username.Text; }
            set { Username.Text = value; }
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            SetComboBoxes();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DataAccess.ExitToLobby(ActiveUsername);
            _instance.Hide();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadLobbyData();
        }

        private void NewGameBtn_Click_1(object sender, EventArgs e)
        {
            CheckCombBoxes();
        }


        private void JoinUsersGameButton_Click(object sender, EventArgs e)
        {
            JoinUser();
        }

        private void SetComboBoxes()
        {
            characterCmbBox.Items.Add("Archer");
            characterCmbBox.Items.Add("Warrior");
            characterCmbBox.Items.Add("Assassin");
            characterCmbBox.Items.Add("Mage");
            characterCmbBox.Items.Add("Beserker");
            characterCmbBox.Items.Add("Cleric");
            characterCmbBox.Items.Add("Necromancer");
            characterCmbBox.Items.Add("Dragoon");

            gamemodeCmbBox.Items.Add("Classic");
            gamemodeCmbBox.Items.Add("Race");
            gamemodeCmbBox.Items.Add("50/50");
            gamemodeCmbBox.Items.Add("Reverse");
            gamemodeCmbBox.Items.Add("Battle Royale");
            gamemodeCmbBox.Items.Add("Double or Nothing");
        }

        private void JoinUser()
        {
            if (gameNumberTextBox.Text == "")
            {
                MessageBox.Show("Please select a game!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to join this users game?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {

                    GameBoardForm.Instance.ActiveUsername = ActiveUsername;
                    DataAccess.JoinUserGame(ActiveUsername, int.Parse(gameNumberTextBox.Text));
                    gameNumberTextBox.Text = "";
                    GameBoardForm.Instance.GameLoad();
                    MessageBox.Show("Game created successfully");
                    GameBoardForm.Instance.Show();
                    _instance.Hide();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

        }

        private void ActivePlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = datagridViewActivePlayers;
                if (int.TryParse(dgv.Rows[e.RowIndex].Cells[1].Value.ToString(), out int index))
                {
                    gameNumberTextBox.Text = index.ToString();
                }
                else
                {
                    MessageBox.Show("This player is not playing a game right now");
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void CheckCombBoxes()
        {
            if (characterCmbBox.SelectedItem == null && gamemodeCmbBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a character and gamemode", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (characterCmbBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a character", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (gamemodeCmbBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a gamemode", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to start a new game?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        DataAccess.SetCharacterType(characterCmbBox.Text, ActiveUsername);
                        DataAccess.InsertGameData(ActiveUsername, gamemodeCmbBox.Text);
                        GameBoardForm.Instance.ActiveUsername = Username.Text;
                        GameBoardForm.Instance.GameLoad();
                        MessageBox.Show("Game created successfully");
                        GameBoardForm.Instance.Show();
                        _instance.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        public void LoadLobbyData()
        {
            datagridViewActivePlayers.DataSource = DataAccess.GetLobbyData();
        }
    }
}