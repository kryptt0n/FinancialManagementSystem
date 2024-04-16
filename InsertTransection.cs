using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialManagementSystem
{
    public class InsertTransection
    {
        private MySqlConnection connection;
        private User user;
        public bool successTransfer;
        int userID;
        string date;
        string type;
        double amount;
        string group;
        public InsertTransection(int userID, string date,string type, double amount, string group)
        {
            user = CurrentUser.User;
            connection = Program.database.GetConnection();
            this.userID = userID;
            this.date = date;
            this.type = type;
            this.amount = amount;
            this.group = group;
            successTransfer = false;
            insertData();

        }
        private void insertData()
        {
            try
            {
                string hashcode = string.Concat(amount, date, type, group);
                string qStr = "INSERT INTO TRANSACTIONS(UID, HASHCODE, TRAN_DATE, TYPE, AMOUNT, TRAN_GROUP) VALUES " +
                      $"({userID}, '{hashcode}', '{date}', '{type}', {amount}, '{group}');" +
                      $"CALL MERGE_TRANSACTIONS_TEMP();" +
                      $"COMMIT;";

                MySqlCommand command = new MySqlCommand(qStr, connection);
                command.ExecuteNonQuery();
                successTransfer = true;
            }
            catch (Exception ex)
            {
                successTransfer = false;
            }
        }
    }
}
