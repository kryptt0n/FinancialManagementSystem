using MySqlConnector;
using Org.BouncyCastle.Math.Field;
using System.Transactions; 

namespace FinancialManagementSystem
{
    public partial class MainPage : Form
    {
        private MySqlConnection connection = Database.Connection;
        public User user;
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            try
            {
                user = CurrentUser.User;
                string balance = $"SELECT BALANCE FROM TRANSACTIONS WHERE UID = {user.Id} ORDER BY TRAN_DATE DESC LIMIT 1 ";
                MySqlCommand command = new MySqlCommand(balance, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) { 
                    while (reader.Read())
                    {
                        BalanceValueLb.Text = reader.GetDouble(0).ToString("0.##");
                    }
                    

                }
                else
                {
                    BalanceValueLb.Text = "0";
                }
                UserNameLb.Text = user.Username;
            } catch {
                MessageBox.Show("Error Occured When Loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }


        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Srue to Log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginPage page = new LoginPage();
                page.Show();
                this.Hide();
            };

        }

        private void ViewReportBtn_Click(object sender, EventArgs e)
        {
            UserReport userReport = new UserReport();
            userReport.Show();
            this.Hide();
        }
    }
}
