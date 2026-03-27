namespace PR_7.SRP
{
    class BankSystem
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amt)
        {
            Balance += amt;
            Console.WriteLine($"Amount Added {amt} and Balance is : {Balance}");
        }
        public void Withdraw(double amt)
        {
            Balance -= amt;
            Console.WriteLine($"Amount Withdrawn {amt} and Balance is : {Balance}");
        }
    }
}
