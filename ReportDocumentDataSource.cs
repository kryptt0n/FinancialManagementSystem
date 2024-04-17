using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinancialManagementSystem
{
    public class ReportDocumentDataSource
    {
        private DataTable table {  get; set; }
        private User user;
        public ArrayList? arrayList;
        public ReportDocumentDataSource(DataTable table)
        {
            this.user = CurrentUser.User;
            this.table = table;
            this.arrayList = new ArrayList();

        }
        public string GetUname()
        {

            return user.Username;
        }

        public ReportDocumentDataSource CreateSource()
        {
            TableToArrayList();
            arrayList.Reverse();
            return this;
        }
        private void TableToArrayList()
        {
            table.PrimaryKey = null;
            table.Columns.Remove("UID");
            table.Columns.Remove("HASHCODE");
            table.Columns.Remove("TRAN_ID");

            ArrayList columnNames = new ArrayList();
            foreach (DataColumn column in table.Columns)
            {
                columnNames.Add(column.ColumnName);
            }

            arrayList.Add(columnNames);

            foreach (DataRow row in table.Rows)
            {
                ArrayList rowData = new ArrayList();
                foreach (object field in row.ItemArray)
                {
                    string value = field.ToString();
                    if (DateTime.TryParse(value, out DateTime InsertDate))
                    {
                        rowData.Add(InsertDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                    else if (value == "Income")
                    {
                        rowData.Add("IN");
                    }
                    else if (value == "Expense")
                    {
                        rowData.Add("EX");
                    }
                    else
                    {
                        rowData.Add(value);
                    }
                }
                arrayList.Add(rowData);
            }
        }
    }
}
