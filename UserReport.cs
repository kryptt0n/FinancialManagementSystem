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
    public partial class UserReport : Form
    {

        MySqlConnection connection;
        User user = CurrentUser.User;

        public UserReport()
        {
            InitializeComponent();
            connection = Program.database.GetConnection();
            LoadAllData();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                CSVParser parser = new CSVParser(filePath);
                parser.ConverterToCharacter();
            }

        }

        private void LoadAllData()
        {
            string qStr = $"SELECT * FROM TRANSACTIONS WHERE UID = {user.Id} ORDER BY TRAN_DATE DESC,TRAN_ID DESC";
            MySqlCommand command = new MySqlCommand(qStr, connection);
            MySqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            TransactionsGv.DataSource = table;
            TransactionsGv.Columns["UID"].Visible = false;
            TransactionsGv.Columns["TRAN_ID"].Visible = false;
            TransactionsGv.Columns["HASHCODE"].Visible = false;
        }
    }
}
