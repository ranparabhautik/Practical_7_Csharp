namespace PR_7.SRP
{
    class Manager
    {
        public void PassLoan(string cname, double amt) // manager passes the loan
        {
            Console.WriteLine($"Manager Approve loan of {amt} for Customer : {cname}");
        }
    }
}
