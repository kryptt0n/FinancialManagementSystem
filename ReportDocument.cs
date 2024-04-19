using System;
using System.Collections;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Font;
using iText.Layout.Font;




namespace FinancialManagementSystem
{
    public class ReportDocument
    {
        public ReportDocumentDataSource source { get; }


        public ReportDocument( ReportDocumentDataSource source)
        {
            this.source = source;
        }

        public void ExportPDF(string filePath)
        {
            try
            {
                var pdfWriter = new PdfWriter(filePath);
                var pdfDocument = new PdfDocument(pdfWriter);

                var document = new Document(pdfDocument);


                AddContent(document);

                document.Close();
            }
            catch
            {
                MessageBox.Show("Selected File Location is in use","Error",MessageBoxButtons.OK);
            }
        }

        void AddContent(Document document)
        {
            var titleStyle = new Style()
                .SetFontSize(20)
                .SetFontColor(iText.Kernel.Colors.ColorConstants.BLUE)
                .SetBold();
            var headerStyle = new Style().SetBold();


            document.Add(new Paragraph("Financial Report").AddStyle(titleStyle));
            document.Add(new Paragraph("Issue date: ").Add(DateTime.Now.ToString("dd-MM-yyyy")));
            document.Add(new Paragraph("UserName: ").Add(source.GetUname()));

            float[] pointColumnWidths = { 50F, 150F, 100F, 100F, 100F, 100F };
            Table table = new Table(pointColumnWidths);

            table.AddCell(new Cell().Add(new Paragraph("#").AddStyle(headerStyle)));
            table.AddCell(new Cell().Add(new Paragraph("Date").AddStyle(headerStyle)));
            table.AddCell(new Cell().Add(new Paragraph("Type").AddStyle(headerStyle)));
            table.AddCell(new Cell().Add(new Paragraph("Amount").AddStyle(headerStyle)));
            table.AddCell(new Cell().Add(new Paragraph("Group").AddStyle(headerStyle)));
            table.AddCell(new Cell().Add(new Paragraph("Balance").AddStyle(headerStyle)));


            for (int i = 0; i < source.arrayList!.Count-1; i++)
            {
                var rowData = (ArrayList)source.arrayList[i];
                if (rowData[1] == "IN") rowData[1] = "Income";
                else rowData[1] = "Expense";
                int counter = i+1;
                table.AddCell(new Cell().Add(new Paragraph(counter.ToString())));
                table.AddCell(new Cell().Add(new Paragraph(rowData[0].ToString())));
                table.AddCell(new Cell().Add(new Paragraph((string)rowData[1]!)));
                table.AddCell(new Cell().Add(new Paragraph((string)rowData[2]!)));
                table.AddCell(new Cell().Add(new Paragraph((string)rowData[3]!)));
                table.AddCell(new Cell().Add(new Paragraph((string)rowData[4]!)));
            }

            document.Add(table);
        }

    }
}
