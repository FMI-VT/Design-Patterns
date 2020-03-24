using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern_example1
{
    // PDF Document class
    public class PDFBuilder : DocumentBuilder
    {
        public override void SetDocumentType()
        {
            document.DocumentType = "PDF";
        }
        public override void SetHeader()
        {
            document.Header = "PDF Header";
        }
        public override void SetFooter()
        {
            document.Footer = "PDF Footer";
        }
        public override void SetContent()
        {
            document.Content = "PDF Content";
        }
    }
}
