using MySqlConnector;
using Org.BouncyCastle.Math.Field;
using System.Transactions; 

namespace FinancialManagementSystem
{
    public partial class MainPage : Form
    {
        private MySqlConnection connection = Program.database.GetConnection();
        public User user;
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            user = CurrentUser.User;
            UserNameLb.Text = user.Username;
            LoadBalance();
            LoadIncome();
            LoadExpenses();
        }

        private void LoadBalance()
        {
            try
            {
                string balance = $"SELECT BALANCE FROM TRANSACTIONS WHERE UID = {user.Id} ORDER BY TRAN_DATE DESC,TRAN_ID DESC LIMIT 1 ";
                MySqlCommand command = new MySqlCommand(balance, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            BalanceValueLb.Text = reader.GetDouble(0).ToString("0.##");
                        }
                    }
                    else
                    {
                        BalanceValueLb.Text = "0";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Occured When Loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadIncome()
        {
            try
            {
                string income = $"SELECT COALESCE(SUM(AMOUNT), 0) FROM TRANSACTIONS WHERE UID = {user.Id} AND TYPE = 'IN'";
                MySqlCommand command = new MySqlCommand(income, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IncomeLb.Text = reader.GetDouble(0).ToString("0.##");
                    }   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured When Loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExpenses()
        {
            try
            {
                string expense = $"SELECT COALESCE(SUM(AMOUNT), 0) FROM TRANSACTIONS WHERE UID = {user.Id} AND TYPE = 'EX'";
                MySqlCommand command = new MySqlCommand(expense, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ExpensesLb.Text = reader.GetDouble(0).ToString("0.##");
                        }
                    }
                    else
                    {
                        ExpensesLb.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured When Loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            UserReportPage userReport = new UserReportPage();
            userReport.Show();
            this.Hide();
        }

        private void AddTransactionBtn_Click(object sender, EventArgs e)
        {
            TransactionDetailPage transactionDetail = new TransactionDetailPage();
            transactionDetail.Show();
            Hide();
        }
    }
}
