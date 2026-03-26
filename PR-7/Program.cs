using PR_7.DIP;
using PR_7.ISP;
using PR_7.LSP;
using PR_7.OCP;
using PR_7.OCP.Interfaces;
using PR_7.SRP;


internal class Program
{

    static void Main(string[] args)
    {
        // SRM
        Console.WriteLine("------------------- SRM-------------------");
        BankSystem BOB_Bank = new BankSystem() { AccountNumber = 10101, CustomerName = "Bhautik", Balance = 30000 };
        Cashier cashier = new Cashier();
        Manager manager = new Manager();

        cashier.DoDeposit(BOB_Bank, 10000);
        cashier.DoWithdraw(BOB_Bank, 2000);

        manager.PassLoan(BOB_Bank.CustomerName, 60000);



        Console.WriteLine();
        Console.WriteLine("===============================");


        //OCP
        Console.WriteLine("---------------- OCP----------------");
        double amount = 20000;
        SeasonalOffer offers;
        Console.WriteLine("Choose Offer: \n1-Summer \n2-Winter \n3-Diwali \n4-Christmas");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            offers = new SummerOffer();
        }
        else if (choice == 2)
        {
            offers = new WinterOffer();
        }
        else if (choice == 3)
        {
            offers = new DiwaliOffer();
        }
        else if (choice == 4)
        {
            offers = new ChristmasOffer();
        }
        else
        {
            Console.WriteLine("Invalid");
            return;
        }

        double billamt = offers.ApplyOffr(amount);
        Console.WriteLine($"Final bill : {billamt}");



        Console.WriteLine();
        Console.WriteLine("===============================");



        // ISP
        Console.WriteLine("------------------ ISP ----------------");

        LaserPrinter lp = new LaserPrinter();
        lp.getDoc("one.txt");
        lp.scan("Scannin the One.txt");
        lp.print("Helloo world from Lazer Printer");
        lp.Mail("abc@gmail.com");
        Console.WriteLine();
        InkPrinter ip = new InkPrinter();
        ip.getDoc("data.json");
        lp.scan("Scanning the data.json");
        ip.print("Greetings of the day from Ink Printer");
        ip.Mail("xyz@gmail.com");
        Console.WriteLine();
        Console.WriteLine("===============================");





        // LSP
        Console.WriteLine("-------------------- LSP -----------------");

        LazerPrinter_LSP lazer = new LazerPrinter_LSP();
        lazer.GetDoc("Document.pdf");
        lazer.Scan("Scanning Document.pdf");
        lazer.Print("Hola Amigos from LazerPrinter_LSP");
        lazer.Mail("john@gmail.com");
        Console.WriteLine();
        InkPrinter_LSP ink = new InkPrinter_LSP();
        ink.GetDoc("Notes.doc");
        ink.Print("Hello worldd from InkPrinter_LSP");
        ink.Mail("sam@gmail.com");
        Console.WriteLine();
        Console.WriteLine("===============================");




        // DIP
        Console.WriteLine("------------------ DIP ------------------"); // here High level is MainSwitch  , low level is Bulb, Light. interface is mediator
        MainSwitch mainswitch = new MainSwitch();
        mainswitch.Operate(new Bulb());
        mainswitch.Operate(new Light());
       
        Console.ReadKey();
    }
}
