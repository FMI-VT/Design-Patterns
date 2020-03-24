using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern_example1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a PDF Document
            DocumentBuilder pdfBuilder = new PDFBuilder();
            Director dir = new Director();
            Document pdfDocument = dir.GenerateDocument(pdfBuilder);
            // Print content
            Console.WriteLine(pdfDocument.Header);
            Console.WriteLine(pdfDocument.Content);
            Console.WriteLine(pdfDocument.Footer);
            // Create a Excel Document
            DocumentBuilder excelBuilder = new ExcelBuilder();
            Document excelDocument = dir.GenerateDocument(excelBuilder);
            // Print content
            Console.WriteLine(excelDocument.Header);
            Console.WriteLine(excelDocument.Content);
            Console.WriteLine(excelDocument.Footer);
            Console.ReadLine();
        }
    }
}
