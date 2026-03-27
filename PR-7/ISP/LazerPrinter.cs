using PR_7.ISP.Interfaces;

namespace PR_7.ISP
{
    internal class LaserPrinter : IGetDoc, IMailDoc, IPrinterTask,IScannerTask
    {

        public void getDoc(string filename)
        {
            Console.WriteLine($"Getting {filename} in Laser Printer ");
        }

        public void Mail(string text)
        {
            Console.WriteLine($"sending this mail : {text} from Laser Printer");
        }

        public void print(string printText)
        {
            Console.WriteLine("Printing Text in Laser Printer");
            Console.WriteLine(printText);
        }

        public void scan(string scanText)
        {
            Console.WriteLine("Scanning Document in Laser Printer");
            Console.WriteLine(scanText);
        }


    }
}
