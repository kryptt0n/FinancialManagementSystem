using Google.Protobuf;
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
            string qStr = GetSelectQuery();
            MySqlCommand command = new MySqlCommand(qStr, connection);
            MySqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            TransactionsGv.DataSource = table;
            foreach (DataRow row in table.Rows)
            {
                row["TYPE"] = row["TYPE"].ToString() == "EX" ? "Expense" : "Income";
            }
            TransactionsGv.Columns["UID"].Visible = false;
            TransactionsGv.Columns["TRAN_ID"].Visible = false;
            TransactionsGv.Columns["HASHCODE"].Visible = false;
        }

        private string GetSelectQuery()
        {
            string qStr = $"SELECT * FROM TRANSACTIONS WHERE UID = {user.Id} ";
            
            if (FromDtp.Checked)
                qStr += $"AND TRAN_DATE >= '{FromDtp.Value.ToString("yyyy-MM-dd HH:mm:ss")}' ";
           
            if (ToDtp.Checked)
                qStr += $"AND TRAN_DATE <= '{ToDtp.Value.ToString("yyyy-MM-dd HH:mm:ss")}' ";
            
            if (TypeCb.SelectedIndex != -1 && TypeCb.Text != "None")
                qStr += $"AND TYPE = '{(TypeCb.Text.Equals("Income") ? "IN" : "EX")}' ";

            if (!string.IsNullOrEmpty(GroupTb.Text))
                qStr += $"AND TRAN_GROUP LIKE '%{GroupTb.Text}%' ";

            qStr += $"ORDER BY TRAN_DATE DESC,TRAN_ID DESC";

            return qStr;
        }

        private void FromDtp_ValueChanged(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void ToDtp_ValueChanged(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void TypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void GroupTb_TextChanged(object sender, EventArgs e)
        {
            LoadAllData();
        }
    }
}
