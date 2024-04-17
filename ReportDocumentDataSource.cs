using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Helpers;

namespace FinancialManagementSystem
{
    public class ReportDocumentDataSource
    {
        private DataTable table;
        private User User;
        public ReportDocumentDataSource(DataTable table)
        {
            User = CurrentUser.User;
            this.table = table;

        }
    }
}
