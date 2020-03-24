using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern_example1
{
    ///
    /// Director takes those individual processes from the builder
    /// and defines the sequence to build the Document.
    ///
    public class Director
    {
        public Document GenerateDocument(DocumentBuilder documentBuilder)
        {
            documentBuilder.CreateDocument();
            documentBuilder.SetDocumentType();
            documentBuilder.SetHeader();
            documentBuilder.SetContent();
            documentBuilder.SetFooter();
            return documentBuilder.getDocument();
        }
    }
}
