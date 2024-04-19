using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementSystem
{
    public class CSVExporter
    {
        private string filePath;
        private DataTable table;
        private User user;

        public CSVExporter(DataTable table, string path)
        {
            filePath = path;
            this.table = table;
            user = CurrentUser.User;
        }
        public void ExportCSV()
        {
            table.PrimaryKey = null;
            table.Columns.Remove("UID");
            table.Columns.Remove("HASHCODE");
            table.Columns.Remove("TRAN_ID");
            table.Columns.Remove("BALANCE");

            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = table.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in table.Rows)
            {
                IEnumerable<string?> fields = row.ItemArray.Select(field => 
                {
                    string value = field.ToString();
                    if(DateTime.TryParse(value,out DateTime InsertDate))
                    {
                        return InsertDate.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                    else if (value == "Income")
                    {
                        return "IN";
                    }
                    else if (value == "Expense")
                    {
                        return "EX";
                    }
                    else if(Double.TryParse(value,out double Amount))
                    {
                        if(Amount < 0)
                        {
                            Amount = Amount * -1;
                        }
                        return Amount.ToString();
                    }
                    return value;
                    });
                sb.AppendLine(string.Join(",", fields));
            }
            if (sb.Length > 0)
            {
                File.WriteAllText(filePath, sb.ToString());
                MessageBox.Show($"Exporting Done", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
