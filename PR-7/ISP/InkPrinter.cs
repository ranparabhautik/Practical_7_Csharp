using PR_7.ISP.Interfaces;

namespace PR_7.ISP
{
    internal class InkPrinter : IGetDoc, IMailDoc, IPrinterTask
    {
        public void getDoc(string filename)
        {
            Console.WriteLine($"Getting {filename} in Ink Printer ");
        }

        public void Mail(string text)
        {
            Console.WriteLine($"sending this mail : {text} from Ink Printer");
        }

        public void print(string printText)
        {
            Console.WriteLine("Printing Text in Ink Printer");
            Console.WriteLine(printText);
        }

        public void scan(string scanText)
        {
            Console.WriteLine("Scanning Document in Lazer Printer");
            Console.WriteLine(scanText);
        }
    }
}
