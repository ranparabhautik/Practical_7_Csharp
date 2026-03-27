namespace PR_7.SRP
{
    class Cashier 
    {
        public void DoDeposit(BankSystem acc, double amt) // cashier process the deposit 
        {
            acc.Deposit(amt);
        }
        public void DoWithdraw(BankSystem acc, double amt) // cashier process the withdrawal 
        {
            if (acc.Balance < amt)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                acc.Withdraw(amt);
            }
        }
    }
}
