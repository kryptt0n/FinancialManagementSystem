 using Microsoft.VisualBasic.FileIO;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementSystem
{
    public class CSVParser
    {
        private User user;
        private TextFieldParser parser;
        private Queue<string[]> strings;
        private string[] stringData;
        private DateTime insertTime;
        private double amount;
        private string type;
        public CSVParser(string filePath)
        {

            parser = new TextFieldParser(filePath);
            strings = new Queue<string[]>();
            user = CurrentUser.User;
        }

        public void ConverterToCharacter()
        {

            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                string[] stringData = parser.ReadFields();
                strings.Enqueue(stringData);
            }
            InsertData();
        }
        public void InsertData()
        {
            int sucessCounter = 0;
            int skipCounter = 0;
            int count = strings.Count;
            for (int i = 0; i < count; i++)
            {
                try
                {
                    stringData = strings.Dequeue();
                    insertTime = Convert.ToDateTime(stringData[0]);
                    amount = Double.Parse(stringData[2]);
                    type = stringData[1];

                    if (CheckData())
                    {

                        InsertTransaction transection = new InsertTransaction(user.Id, stringData[0], stringData[1],amount, stringData[3]);
                        if (transection.successTransfer) { sucessCounter++; }
                        else { skipCounter++; }
                    }
                    else { skipCounter++; }
                }
                catch
                {
                    skipCounter++;
                }
            }

            MessageBox.Show($"Sucess Record: {sucessCounter}\nSkip Record:{skipCounter}", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Boolean CheckData()
        {
            if(insertTime > DateTime.Now)
            { return false; }
            else if (type == "EX" && amount > 0)
            {
                amount = amount * -1;
                return true;
            }
            else if (amount > 0)
            {
                return true;
            }
            else { return false; }
        }
    }
}