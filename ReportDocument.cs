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
    internal class ReportDocument
    {
        public ReportDocumentDataSource source { get; }


        public ReportDocument( ReportDocumentDataSource source)
        {
            this.source = source;
        }

        public void ExportPDF(string filePath)
        {
            var pdfWriter = new PdfWriter(filePath);
            var pdfDocument = new PdfDocument(pdfWriter);
            
            var document = new Document(pdfDocument);


            AddHeader(document);
            AddContent(document);

            document.Close();
        }

        void AddHeader(Document document)
        {
            var titleStyle = new Style()
                .SetFontSize(20)
                .SetFontColor(iText.Kernel.Colors.ColorConstants.BLUE)
                .SetBold();


            document.Add(new Paragraph("Financial Report").AddStyle(titleStyle));
            document.Add(new Paragraph("Issue date: ").Add(DateTime.Now.ToString("dd-MM-yyyy")));
            document.Add(new Paragraph("UserName: ").Add(source.GetUname()));

            document.Add(new AreaBreak());
        }

        void AddContent(Document document)
        {
            float[] pointColumnWidths = { 50F, 150F, 100F, 100F, 100F, 100F };
            Table table = new Table(pointColumnWidths);

            table.AddCell(new Cell().Add(new Paragraph("#")));
            table.AddCell(new Cell().Add(new Paragraph("Date")));
            table.AddCell(new Cell().Add(new Paragraph("Type")));
            table.AddCell(new Cell().Add(new Paragraph("Amount")));
            table.AddCell(new Cell().Add(new Paragraph("Group")));
            table.AddCell(new Cell().Add(new Paragraph("Balance")));


            for (int i = 1; i < source.arrayList!.Count; i++)
            {
                var rowData = (ArrayList)source.arrayList[i];
                if (rowData[1] == "IN") rowData[1] = "Income";
                else rowData[1] = "Expense"
                table.AddCell(new Cell().Add(new Paragraph(i.ToString())));
                table.AddCell(new Cell().Add(new Paragraph(rowData[0].ToString())));
                table.AddCell(new Cell().Add(new Paragraph((String)rowData[1])));
                table.AddCell(new Cell().Add(new Paragraph(rowData[2].ToString())));
                table.AddCell(new Cell().Add(new Paragraph((String)rowData[3])));
                table.AddCell(new Cell().Add(new Paragraph(rowData[4].ToString())));
            }

            document.Add(table);
        }
    }
}
