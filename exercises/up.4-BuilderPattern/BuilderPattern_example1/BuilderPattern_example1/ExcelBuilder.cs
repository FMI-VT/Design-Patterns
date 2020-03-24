using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern_example1
{
    // Excel Document class
    public class ExcelBuilder : DocumentBuilder
    {
        public override void SetDocumentType()
        {
            document.DocumentType = "Excel";
        }
        public override void SetHeader()
        {
            document.Header = "Excel Header";
        }
        public override void SetFooter()
        {
            document.Footer = "Excel Footer";
        }
        public override void SetContent()
        {
            document.Content = "Excel Content";
        }
    }
}
