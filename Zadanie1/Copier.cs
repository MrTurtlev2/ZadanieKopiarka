using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ver1;

namespace Zadanie1
{

    public class Copier : IPrinter, IScanner
    {
        public int PrintCounter { get; set; }
        public int ScanCounter { get; set; }
        public int Counter { get; set; }

        public IDevice.State GetState()
        {
            throw new NotImplementedException();
        }

        public void PowerOff()
        {
            throw new NotImplementedException();
        }

        public void PowerOn()
        {
            throw new NotImplementedException();
        }

        public void Print(in IDocument document)
        {
            throw new NotImplementedException();
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {
            throw new NotImplementedException();
        }

        internal void ScanAndPrint()
        {
            throw new NotImplementedException();
        }

        internal void Stan(out IDocument doc2)
        {
            throw new NotImplementedException();
        }
    }
}