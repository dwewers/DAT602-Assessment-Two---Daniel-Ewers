using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DAT602_Assessment_Game
{
    class DataAccess
    {
        private static Connect _conn = new Connect();

        public static Connect Conn { get => _conn; set => _conn = value; }

        public static void AdminCreateUser(string usernameText, string passwordText, string emailText, CheckBox adminCheckBox)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("AdminCreateUser", Conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", usernameText);
                    cmd.Parameters.AddWithValue("@pwd", passwordText);
                    cmd.Parameters.AddWithValue("@email", emailText);
                    cmd.Parameters.AddWithValue("@priv", adminCheckBox.Checked);

                    Conn.Open();

                    if (!AdminCreateUserForm.Instance.CheckInputFields())
                    {
                        if (CheckUsername(usernameText))
                        {
                            MessageBox.Show("This Username Already Exists, Please Enter a new one", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Error");
                            }
                            else
                            {
                                AdminCreateUserForm.Instance.OpenSettings();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter all details", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    Conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static bool CheckUsername(string usernameText)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("checkUsernameSignUp", Conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@uname", usernameText);
                        adapter.SelectCommand = cmd;
                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                _conn.Close();
                                return true;
                            }
                            else
                            {
                                _conn.Close();
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void LoadSettingsData()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("GetPlayerUsernames", Conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    Conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AdminSettingsForm.Instance.playerComboBx.Items.Add(reader.GetString("username"));
                        }
                        reader.Close();
                    }
                    _conn.Close();
                }

                using (MySqlCommand cmd = new MySqlCommand("GetGameNumbers", Conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    _conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AdminSettingsForm.Instance.gameComboBx.Items.Add(reader.GetString("gameNumber"));
                        }
                        reader.Close();
                        _conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Conn.Close();
            }
        }

        public static void AdminDeleteAccount(string usernameText)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("AdminDeleteUser", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", usernameText);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);
                            _conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteGame(string game)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("AdminDeleteGame", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@game", game);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);
                            _conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ResetPlayer(string usernameText)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("AdminResetUser", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", usernameText);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);
                            _conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Logout(string usernameText)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Logout", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", usernameText);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;

                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);
                            _conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UserDeleteAccount(string usernameText)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("AdminDeleteUser", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", usernameText);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;

                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);
                            _conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void GetLeaderboardData()
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("GetDataLeaderboard", _conn.GetConnection()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable dtset = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(dtset);
                            BindingSource bsource = new BindingSource();
                            bsource.DataSource = dtset;
                            adapter.Update(dtset);

                            LeaderboardForm.Instance.dataGridView1.DataSource = bsource;
                            LeaderboardForm.Instance.dataGridView1.Sort(LeaderboardForm.Instance.dataGridView1.Columns["Total Score"], ListSortDirection.Descending);
                            _conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SignUp(string usernameText, string passwordText, string emailText)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("CreateUserAccount", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("uname", usernameText);
                    cmd.Parameters.AddWithValue("pwd", passwordText);
                    cmd.Parameters.AddWithValue("email", emailText);

                    if (!SignUpForm.Instance.CheckInputFields())
                    {
                        if (CheckUsername(usernameText))
                        {
                            MessageBox.Show("This Username Already Exists, Please Enter a new one try loggin in", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //Execute The Query that creates a new account
                            _conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Critical Error");
                                _conn.Close();
                            }
                            else
                            {
                                _conn.Close();
                                SetLoggedIn(usernameText);
                                UserHomeForm.Instance.ActiveUsername = usernameText;
                                SignUpForm.Instance.Hide();
                                UserHomeForm.Instance.Show();
                                SignUpForm.Instance.ClearFields();

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter all your details", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Conn.Close();
            }
        }

        public static void SetLoggedIn(string usernameText)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SetLoggedIn", _conn.GetConnection()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@uname", usernameText);
                        adapter.SelectCommand = cmd;
                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);
                            _conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void FailedLogin(string usernameText)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("FailedAttempt", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("uname", usernameText);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);
                            _conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void SetLock(string usernameText)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("LoginLock", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("uname", usernameText);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);
                            _conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CheckValidLogin(string username, string password)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("CheckInfo", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("uname", MySqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("pwd", MySqlDbType.VarChar).Value = password;

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;

                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);
                            _conn.Close();

                            if (!LoginForm.Instance.CheckInputFields())
                            {
                                if (table.Rows.Count > 0)
                                {
                                    LoginForm.Instance.OpenMenu(username);
                                }
                                else
                                {
                                    /*Login Error Wrong password*/
                                    FailedLogin(username);
                                    SetLock(username);
                                    LoginForm.Instance.OpenCreateAcc();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter all your details", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void ExitToLobby(string username)
        {
            try
            {
                if (!DataAccess.CheckIfAdmin(username))
                {
                    AdminHomeForm.Instance.ActiveUsername = username;
                    AdminHomeForm.Instance.Show();
                }
                else
                {
                    UserHomeForm.Instance.ActiveUsername = username;
                    UserHomeForm.Instance.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DataTable GetLobbyData()
        {
            DataTable table = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("LoadLobbyData", Conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    Conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        table.Load(reader);
                        reader.Close();
                    }
                    _conn.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            return table;
        }

        public static void JoinUserGame(string user, int gameID)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("JoinUser", Conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", user);
                    cmd.Parameters.AddWithValue("@gameNum", gameID);
                    Conn.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                    Conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void InsertGameData(string username, string gamemode)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("InsertGameData", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.Parameters.AddWithValue("@gameMode", gamemode);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);
                            _conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SetCharacterType(string character, string username)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("setCharacterType", _conn.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@charType", character);
                cmd.Parameters.AddWithValue("@uname", username);
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool IsTileValidDataAccess(int tile, int game)
        {
            Conn.Close();
            using (MySqlCommand cmd = new MySqlCommand("CheckValid", _conn.GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("tileVal", tile);
                cmd.Parameters.AddWithValue("num", game);
                Conn.Open();
                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        if (read[0] != DBNull.Value)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    read.Close();
                }
                Conn.Close();
            }
            return false;
        }

        public static void UpdatePlayerPositionDataAccess(int index, int last, string username, int Score, int GameNumber)
        {
            Conn.Close();
            using (MySqlCommand cmd = new MySqlCommand("UpdatePlayerTile", _conn.GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("uname", username);
                cmd.Parameters.AddWithValue("tileVal", index);
                cmd.Parameters.AddWithValue("lastValue", last);
                cmd.Parameters.AddWithValue("score", Score);
                cmd.Parameters.AddWithValue("num", GameNumber);

                try
                {
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                }
                catch (Exception error)
                {
                    Conn.Close();
                    Console.WriteLine(error);
                    Console.ReadLine();
                }
            }
        }

        public static void SavePlayerPositionDataAccess(string username, int postion, int gameNumber)
        {
            Conn.Close();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("ExitGame", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlParameter mySqlParameter1 = cmd.Parameters.AddWithValue("uname", username);
                    MySqlParameter mySqlParameter2 = cmd.Parameters.AddWithValue("currentTile", postion);
                    MySqlParameter mySqlParameter3 = cmd.Parameters.AddWithValue("num", gameNumber);

                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                }
            }
            catch (Exception error)
            {
                Conn.Close();
                Console.WriteLine(error);
                Console.ReadLine();
            }
        }

        public static void LoadChat(int gameID)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("LoadChatData", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@gID", gameID);
                    _conn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        GameBoardForm.Instance.chatListBox.Items.Add(reader["text"].ToString());
                    }
                    reader.Close();
                    _conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateMessages(string message, int gameID)
        {
            using (MySqlCommand cmd = new MySqlCommand("SendMessage", _conn.GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("message", message);
                cmd.Parameters.AddWithValue("gID", gameID);

                _conn.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                {
                    adapter.SelectCommand = cmd;
                    using (DataTable table = new DataTable())
                    {
                        adapter.Fill(table);
                    }
                }
                _conn.Close();
            }
        }

        public static void LoadGameData(string username)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("GetGameNumber", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    Conn.Open();
                    cmd.Parameters.AddWithValue("uname", username);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GameBoardForm.Instance.gameNumberTextBox.Text = Convert.ToString((int)reader["gameID"]);
                            GameBoardForm.Instance.gameIDTextBox.Text = Convert.ToString((int)reader["gameID"]);
                        }
                        reader.Close();
                    }
                    Conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateScore(string username)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("GetPlayerScore", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("uname", username);
                    _conn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        GameBoardForm.Instance.playerScoreTextBox.Text = (reader["totalScore"].ToString());
                    }
                    reader.Close();
                    _conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateItems(string username)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("GetItemCount", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("uname", username);
                    _conn.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        GameBoardForm.Instance.itemNumberTextBox.Text = (reader["quantity"].ToString());
                    }
                    reader.Close();
                    _conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadUserData(string username)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("LoadData", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    _conn.Open();
                    cmd.Parameters.AddWithValue("uname", username);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AdminUpdateUserForm.Instance.usernameField.Text = username;
                            AdminUpdateUserForm.Instance.passwordField.Text = (string)reader["user_password"];
                            AdminUpdateUserForm.Instance.emailField.Text = (string)reader["user_email"];
                            AdminUpdateUserForm.Instance.adminCheckBox.Checked = (bool)reader["user_isAdmin"];
                            AdminUpdateUserForm.Instance.unlockAccCheckBox.Checked = (bool)reader["user_accountStatus"];
                        }
                        reader.Close();
                    }
                    _conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>Updates the user.</summary>
        public static void UpdateUser(string username, string password, string email, bool status, bool admin)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("UpdateUser", _conn.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("uname", username);
                    cmd.Parameters.AddWithValue("pwd", password);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("acc", status);
                    cmd.Parameters.AddWithValue("priv", admin);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable table = new DataTable())
                        {
                            _conn.Open();
                            adapter.Fill(table);
                            _conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static Boolean CheckIfAdmin(String username)
        {
            Connect database = new Connect();
            MySqlCommand cmd = new MySqlCommand("CheckIfAdmin", database.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("uname", username);
            cmd.Connection.Open();
            bool isAdmin = (bool)cmd.ExecuteScalar();

            if (isAdmin)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean CheckLock(String username)
        {
            Connect database = new Connect();
            MySqlCommand cmd = new MySqlCommand("AccountStatus", database.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("uname", username);
            cmd.Connection.Open();
            bool isLocked = (bool)cmd.ExecuteScalar();

            if (isLocked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
