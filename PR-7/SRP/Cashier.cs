namespace PR_7.SRP
{
    class Cashier
    {
        public void DoDeposit(BankSystem acc, double amt)
        {
            acc.Deposit(amt);
        }
        public void DoWithdraw(BankSystem acc, double amt)
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
