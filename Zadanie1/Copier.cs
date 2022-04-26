﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ver1;

namespace Zadanie1
{

    public class Copier : IPrinter, IScanner, IDevice
    {
        private IDevice.State state;

        public int PrintCounter { get; set; }
        public int ScanCounter { get; set; }
        public int Counter { get; set; }

        public string FormatedDate = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");

        public IDevice.State GetState()
        {
           return state = IDevice.State.off;
        }

        public void PowerOff()
        {
            if (GetState() == IDevice.State.on)
            {
                state = IDevice.State.off;
                Console.WriteLine("... Device is off !");
            }
        }

        public void PowerOn()
        {
            if (GetState() == IDevice.State.off)
            {
                state = IDevice.State.on;
                Console.WriteLine("Device is on ...");
                Counter++;
            }
        }

        public void Print(in IDocument document)
        {
            Console.WriteLine(FormatedDate + " Print: " + document.GetFileName());
            PrintCounter++;
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {
            document = new TextDocument("readme.txt");

            Console.WriteLine(FormatedDate + " Scan: " + document.GetFileName());

            ScanCounter++;
        }

        internal void ScanAndPrint()
        {
            throw new NotImplementedException();
        }
    }
}