using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ver1;

namespace Zadanie2
{

    public class Copier : BaseDevice, IPrinter, IScanner
    {
        public int PrintCounter { get; set; }
        public int ScanCounter { get; set; }
        public new int Counter { get; set; }

        public string FormatedDate = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");

        public void Print(in IDocument document)
        {
            if (GetState() == IDevice.State.on)
            {
     
                Console.WriteLine("{0} Print: {1}", FormatedDate, document.GetFileName());
                ++PrintCounter;
            }
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType = IDocument.FormatType.TXT)
        {

            /*formatType = IDocument.FormatType.TXT;*/

            if (GetState() == IDevice.State.off)
            {
                document = null;
                return;
            }


            ++ScanCounter;

            switch (formatType)
            {
                case IDocument.FormatType.JPG:
                    document = new ImageDocument($"ImageScan{ScanCounter}.jpg");
                    break;

                case IDocument.FormatType.PDF:
                    document = new PDFDocument($"PDFScan{ScanCounter}.pdf");
                    break;

                case IDocument.FormatType.TXT:
                    document = new TextDocument($"TextScan{ScanCounter}.txt");
                    break;

                default:
                    throw new ArgumentException("Undefined file type!");
            }

            Console.WriteLine("{0} Scan: {1}", FormatedDate, document.GetFileName());
        }

        public void ScanAndPrint()
        {
            IDocument document;

            Scan(out document, IDocument.FormatType.JPG);

            Print(document);
        }

        public void PowerOn()
        {
            if (GetState() == IDevice.State.off)
            {
                ++Counter;
            }

            base.PowerOn();
        }
    }
}