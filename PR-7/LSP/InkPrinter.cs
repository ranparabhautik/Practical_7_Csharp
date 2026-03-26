using PR_7.LSP.Interfaces;

namespace PR_7.LSP
{
    // the InkPrinter is not able to scan so the IScan interface is not implemented for the preservation of LSP principle.
    internal class InkPrinter_LSP : IGetDoc, IPrinter, IMailDoc
    {
        public void GetDoc(string filename)
        {
            Console.WriteLine($"Opening file : {filename} in InkPrinter_LSP");
        }


        public void Print(string text)
        {
            Console.WriteLine("Printing Text in InkPrinter_LSP");
            Console.WriteLine($"Text to be printed : {text}");
        }

        public void Mail(string text)
        {
            Console.WriteLine($"Sending mail to {text} from InkPrinter_LSP");
        }
    }
}
