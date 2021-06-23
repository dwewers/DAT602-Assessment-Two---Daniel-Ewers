using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    public partial class GameBoardForm : Form
    {
        private static GameBoardForm _instance = new GameBoardForm();

        private static Connect _conn = new Connect();

        static GameBoardForm()
        {
            _instance.InitializeComponent();
            //_instance.GetData();
        }

        public static Connect Conn
        {
            get => _conn;
            set => _conn = value;
        }

        public static GameBoardForm Instance
        {
            get => _instance;
            set => _instance = value;
        }

        /// <summary>Gets or sets the active username.</summary>
        /// <value>The active username.</value>
        public string ActiveUsername
        {
            get { return usernameTextBox.Text; }
            set { usernameTextBox.Text = value; }
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess.SavePlayerPositionDataAccess(_instance.ActiveUsername, int.Parse(tileLocationTextBox.Text), int.Parse(gameIDTextBox.Text));
                _instance.Hide();
                GameLobbyForm.Instance.ActiveUsername = _instance.ActiveUsername;
                GameLobbyForm.Instance.LoadLobbyData();
                GameLobbyForm.Instance.Show();
            }
            catch (Exception error
            )
            {
                MessageBox.Show(error.Message);
            }
        }

        public void GameLoad()
        {
            DataAccess.LoadGameData(_instance.ActiveUsername);
            UpdateChat();
            DrawButtonArray();
        }

        private void UpdateChat()
        {
            chatListBox.Items.Clear();
            DataAccess.LoadChat(int.Parse(gameIDTextBox.Text));
        }

        private readonly int _xAxis = 10;

        private readonly int _yAxis = 10;

        private int _count = 1;

        private void DrawButtonArray()
        {
            tileLocationTextBox.Text = "1";

            Button[] buttons = new Button[_xAxis * _yAxis];
            int currentIndex = 0;
            for (int i = 0; i < _xAxis; i++)
            {
                for (int j = 0; j < _yAxis; j++)
                {
                    Button gridBtn = new Button
                    {
                        Size = new Size(60, 55),
                        Location = new Point(175 + j * 60, 55 + i * 55),
                        Text = _count.ToString()
                    };

                    gridBtn.ForeColor = Color.FromArgb(64, 64, 64);

                    if (currentIndex == 0)
                    {
                        gridBtn.BackColor = Color.FromArgb(0, 0, 0);
                    }

                    buttons[currentIndex++] = gridBtn;

                    _count++;

                    Controls.Add(gridBtn);
                }
            }

            currentIndex = 1;

            foreach (Button nextIndex in buttons)
            {
                nextIndex.Click += (s, e) =>
                {
                    if (nextIndex.Text == "100" && currentIndex == 99 || nextIndex.Text == "100" && currentIndex == 90)
                    {
                        DataAccess.UpdatePlayerPositionDataAccess(int.Parse(nextIndex.Text), int.Parse(buttons[currentIndex - 1].Text), usernameTextBox.Text, int.Parse(playerScoreTextBox.Text), int.Parse(gameIDTextBox.Text));

                        tileLocationTextBox.Text = nextIndex.Text;
                        buttons[currentIndex - 1].BackColor = Color.FromArgb(64, 64, 64);
                        buttons[currentIndex - 1].ForeColor = Color.FromArgb(64, 64, 64);
                        currentIndex = int.Parse(nextIndex.Text);
                        nextIndex.BackColor = Color.Black;
                        DataAccess.UpdateScore(ActiveUsername);
                        DataAccess.UpdateItems(ActiveUsername);
                        MessageBox.Show("Congratulations, you have finished");

                        currentIndex = 1;
                        nextIndex.BackColor = Color.FromArgb(64, 64, 64);
                        nextIndex.ForeColor = Color.FromArgb(64, 64, 64);
                        buttons[0].BackColor = Color.Black;

                        _instance.Hide();

                        GameLobbyForm.Instance.Show();

                        return;
                    }

                    if (nextIndex.Text == (currentIndex + 1).ToString()
                        || nextIndex.Text == currentIndex.ToString()
                        || nextIndex.Text == (currentIndex - 1).ToString()
                        || nextIndex.Text == (currentIndex + 10).ToString()
                        || nextIndex.Text == (currentIndex - 10).ToString())
                    {
                        if (DataAccess.IsTileValidDataAccess(int.Parse(nextIndex.Text), int.Parse(gameIDTextBox.Text)))
                        {

                            try
                            {
                                DataAccess.UpdatePlayerPositionDataAccess(int.Parse(nextIndex.Text), int.Parse(buttons[currentIndex - 1].Text), usernameTextBox.Text, int.Parse(playerScoreTextBox.Text), int.Parse(gameIDTextBox.Text));
                                DataAccess.UpdateScore(ActiveUsername);
                                DataAccess.UpdateItems(ActiveUsername);
                                tileLocationTextBox.Text = nextIndex.Text;
                                buttons[currentIndex - 1].BackColor = Color.FromArgb(64, 64, 64);
                                buttons[currentIndex - 1].ForeColor = Color.FromArgb(64, 64, 64);
                                currentIndex = int.Parse(nextIndex.Text);
                                nextIndex.BackColor = Color.Black;
                                nextIndex.ForeColor = Color.Black;
                                UpdateChat();
                            }
                            catch (Exception error
                            )
                            {
                                MessageBox.Show(error.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("This tile is occupied");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Move");
                    }
                };
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (chatInputBx.Text != "")
            {
                DataAccess.UpdateMessages(chatInputBx.Text, int.Parse(gameIDTextBox.Text));
                chatListBox.Items.Clear();
                chatInputBx.Focus();
                chatInputBx.Clear();
                UpdateChat();
            }
            else
            {
                MessageBox.Show("Please enter a message", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chatInputBx.Focus();
            }
        }
    }
}