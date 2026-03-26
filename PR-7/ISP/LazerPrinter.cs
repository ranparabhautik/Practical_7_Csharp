using PR_7.ISP.Interfaces;

namespace PR_7.ISP
{
    internal class LaserPrinter : IGetDoc, IMailDoc, IPrinterTask
    {

        public void getDoc(string filename)
        {
            Console.WriteLine($"Getting {filename} in Lazer Printer ");
        }

        public void Mail(string text)
        {
            Console.WriteLine($"sending this mail : {text} from Lazer Printer");
        }

        public void print(string printText)
        {
            Console.WriteLine("Printing Text in Lazer Printer");
            Console.WriteLine(printText);
        }

        public void scan(string scanText)
        {
            Console.WriteLine("Scanning Document in Lazer Printer");
            Console.WriteLine(scanText);
        }


    }
}
