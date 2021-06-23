using MySql.Data.MySqlClient;

namespace DAT602_Assessment_Game
{
    public class Connect
    {
        /// <summary>The connect database</summary>
        readonly MySqlConnection connectDB = new MySqlConnection(@"server=localhost;password=1234;user id=root;persistsecurityinfo=True;database=dat602_assessmentdb_m2");
        /// <summary>Opens the connection.</summary>
        public void Open()
        {
            if (connectDB.State == System.Data.ConnectionState.Closed)
            {
                connectDB.Open();
            }
        }
        /// <summary>Closes the connection.</summary>
        public void Close()
        {
            if (connectDB.State == System.Data.ConnectionState.Open)
            {
                connectDB.Close();
            }
        }
        /// <summary>Gets the connection.</summary>
        /// <returns>
        ///   true or false
        /// </returns>
        public MySqlConnection GetConnection()
        {
            return connectDB;
        }
    }
}

