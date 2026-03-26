using PR_7.LSP.Interfaces;

namespace PR_7.LSP
{
    internal class LazerPrinter_LSP : IGetDoc, IMailDoc, IPrinter, IScanner
    {
        public void GetDoc(string filename)
        {
            Console.WriteLine($"Opening file : {filename} in LazerPrinter_LSP");
        }


        public void Scan(string text)
        {
            Console.WriteLine($"Scanning file ");
            Console.WriteLine(text);
        }

        public void Print(string text)
        {
            Console.WriteLine("Printing Text in LazerPrinter_LSP");
            Console.WriteLine($"Text to be printed : {text}");
        }
        public void Mail(string text)
        {
            Console.WriteLine($"Sending mail to {text} from LazerPrinter_LSP");
        }
    }
}
