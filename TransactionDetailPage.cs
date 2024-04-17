using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagementSystem
{
    public partial class TransactionDetailPage : Form
    {
        private User user;
        private MySqlConnection connection;
        public TransactionDetailPage()
        {
            InitializeComponent();
            user = CurrentUser.User;
            connection = Program.database.GetConnection();
        }

        public TransactionDetailPage(string type, string group) : this()
        {
            TypeCb.Text = type;
            GroupTb.Text = group;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                int amount = int.Parse(AmountTb.Text);
                string date = TransactionDtp.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string typeString = TypeCb.Text;
                string type = typeString.Equals("Income") ? "IN" : "EX";
                string group = GroupTb.Text;
                if (type == "EX")
                {
                    amount = amount * -1;
                }
                InsertTransaction transaction = new InsertTransaction(user.Id,date,type,amount,group);
                MainPage mainPage = new MainPage();
                mainPage.Show();
                Hide();
            }
        }

        private bool ValidateFields()
        {
            return ValidateAmount() && ValidateDate() && ValidateType();
        }

        private bool ValidateAmount()
        {
            int amount;

            if (int.TryParse(AmountTb.Text, out amount))
            {
                    if (amount <= 0)
                        MessageBox.Show("Amount should be greater than zero!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return amount > 0;
            }
            MessageBox.Show("Enter valid amount!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool ValidateDate()
        {
            DateTime date = TransactionDtp.Value.Date;
            DateTime currDate = DateTime.Now;

            if (date > currDate)
            {
                MessageBox.Show("Date should be in the past!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return date <= currDate;
        }

        private bool ValidateType()
        {
            if (TypeCb.SelectedIndex == -1)
                MessageBox.Show("Choose transaction type!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            return TypeCb.SelectedIndex != -1;
        }

        private double GetBalance()
        {
            double result = 0;
            try
            {
                string balance = $"SELECT BALANCE FROM TRANSACTIONS WHERE UID = {user.Id} ORDER BY TRAN_DATE DESC LIMIT 1 ";
                MySqlCommand command = new MySqlCommand(balance, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result = reader.GetDouble(0);
                        }
                    }
                    else
                    {
                        result = 0;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Occured When Loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            Hide();
        }
    }
}
