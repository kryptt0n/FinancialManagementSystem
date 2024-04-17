using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinancialManagementSystem
{
    public class Database
    {
        private static MySqlConnection Connection;
        public static Database Instance;
        private string host;
        private string port;
        private string username;
        private string password;
        private string schema;

        private Database(string host, string port, string username, string password, string schema)
        {
            this.host = host;
            this.port = port;
            this.username = username;
            this.password = password;
            this.schema = schema;
            InitializeConnection();
        }

        public static Database GetInstance(string host, string port, string username, string password, string schema)
        {
            if (Instance == null)
            {
                Instance = new Database(host, port, username, password, schema);
            }
            return Instance;

        }

        private void InitializeConnection()
        {
            string connStr = $"Server={host};Port={port};User Id={username};Password={password};Database={schema}";
            Connection = new MySqlConnection(connStr);
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Connecting to database" + ex.Message);
            }
        }

        public MySqlConnection GetConnection()
        {
            if (Connection == null)
            {
                InitializeConnection();
            }

            return Connection;
        }
    }
}
