using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementSystem
{
    internal class CSVExporter
    {
        private string filePath;
        private User user;
        private TextFieldParser parser;
        private Queue<string[]> strings;
        private string[] stringData;
        private DateTime insertTime;
        private double amount;
        private string type;
        public CSVExporter(string path)
        {
            filePath = path;
        }
        public void exportCSV()
        {
            var csv = new StringBuilder();
            for (int i = 0; i < characterList.Count; i++)
            {
                try
                {
                    AdaptorCharactorToString adaptor = new AdaptorCharactorToString();
                    string stringData = adaptor.ConvertCharacterToString(characterList[i]);
                    csv.AppendLine(stringData);
                }
                catch
                {
                    MessageBox.Show($"Error occure the No.{i + 1} Charater, will proceed to the next Charater", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }
            }
            if (csv.Length > 0)
            {
                File.WriteAllText(filePath, csv.ToString());
                MessageBox.Show($"Exporting Done", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
