using Google.Protobuf;
using MySqlConnector;
using Org.BouncyCastle.Bcpg.Sig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FinancialManagementSystem
{
    public partial class UserReportPage : Form
    {

        MySqlConnection connection;
        User user = CurrentUser.User;

        public UserReportPage()
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
            LoadAllData();

        }
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                DataTable ExportTable = new DataTable();
                ExportTable = ((DataTable)TransactionsGv.DataSource).Copy();
                CSVExporter exporter = new CSVExporter(ExportTable, filePath);
                exporter.ExportCSV();
            }

        }


        private void LoadAllData()
        {
            string qStr = GetSelectQuery();
            MySqlCommand command = new MySqlCommand(qStr, connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                DataTable table = new DataTable();
                table.Load(reader);
                TransactionsGv.DataSource = table;
                foreach (DataRow row in table.Rows)
                {
                    row["TYPE"] = row["TYPE"].ToString() == "EX" ? "Expense" : "Income";
                }
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

        private void CopyTranBtn_Click(object sender, EventArgs e)
        {
            if (TransactionsGv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = TransactionsGv.SelectedRows[0];
                string type = selectedRow.Cells["TYPE"].Value.ToString();
                string group = selectedRow.Cells["TRAN_GROUP"].Value.ToString();

                TransactionDetailPage form = new TransactionDetailPage(type, group);
                form.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Choose transaction to copy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "pdf files (*.pdf)|*.pdf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                DataTable exportTable = ((DataTable)TransactionsGv.DataSource).Copy();
                ReportDocumentDataSource source = new ReportDocumentDataSource(exportTable);
                source.CreateSource();
                var document = new ReportDocument(source);
                document.ExportPDF(filePath);

                System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{filePath}\"");
            }
        }

        private void TransactionsGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
