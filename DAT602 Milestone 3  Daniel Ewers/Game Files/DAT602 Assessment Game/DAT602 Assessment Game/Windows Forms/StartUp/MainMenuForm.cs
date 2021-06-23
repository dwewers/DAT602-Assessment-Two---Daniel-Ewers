using System;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    public partial class MainMenuForm : Form
    {
        private static MainMenuForm _instance = new MainMenuForm();

        static MainMenuForm()
        {
            _instance.InitializeComponent();
        }

        public static MainMenuForm Instance
        {
            get => _instance;
            set => _instance = value;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            _instance.Hide();
            LoginForm.Instance.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            _instance.Hide();
            SignUpForm.Instance.SetFields();
            SignUpForm.Instance.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}