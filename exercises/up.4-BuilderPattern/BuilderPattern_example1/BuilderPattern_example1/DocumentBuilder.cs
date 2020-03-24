using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern_example1
{
    // Document Builder - Builder is responsible for defining
    // the construction process for individual parts. Builder
    // has those individual processes to initialize and
    // configure the Document.
    public abstract class DocumentBuilder
    {
        public Document document;
        public void CreateDocument()
        {
            document = new Document();
        }
        public abstract void SetDocumentType();
        public abstract void SetHeader();
        public abstract void SetFooter();
        public abstract void SetContent();
        public Document getDocument()
        {
            return document;
        }
    }
}
