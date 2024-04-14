using MySqlConnector;

namespace FinancialManagementSystem
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection = Database.Connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string test = "SELECT * FROM TRANSACTIONS";
            MySqlCommand command = new MySqlCommand(test, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(1));
            }
        }
    }
}
