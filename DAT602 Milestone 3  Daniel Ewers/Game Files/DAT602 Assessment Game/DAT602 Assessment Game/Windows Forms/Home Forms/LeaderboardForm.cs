using System;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    public partial class LeaderboardForm : Form
    {
        private static LeaderboardForm _instance = new LeaderboardForm();

        private static Connect _conn = new Connect();

        static LeaderboardForm()
        {
            _instance.InitializeComponent();
        }

        public static Connect Conn
        {
            get => _conn;
            set => _conn = value;
        }

        public string ActiveUsername { get => _activeUsername; set => _activeUsername = value; }

        private string _activeUsername;

        public static LeaderboardForm Instance
        {
            get => _instance;
            set => _instance = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess.GetLeaderboardData();
        }



        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DataAccess.ExitToLobby(ActiveUsername);
            _instance.Hide();

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            DataAccess.GetLeaderboardData();
        }
    }
}