using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            DocumentProgram docProgram=null;

            while (true)
            {
                var input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "basic": docProgram = new DocumentProgram(); break;
                    case "pro": docProgram = new ProDocumentProgram(); break;
                    case "expert": docProgram = new ExpertDocument(); break;
                    default: Console.WriteLine("Achar soz sehvdir"); continue; 
                }
                
                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();

            }

        }
    }

    class DocumentProgram
    {

        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }

    }

    class ProDocumentProgram : DocumentProgram
    {

        sealed public override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }

    class ExpertDocument : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
