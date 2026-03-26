using PR_7.OCP.Interfaces;

namespace PR_7.OCP
{
    class SummerOffer : SeasonalOffer
    {
        private double discount = 0.10;

        public double ApplyOffr(double amount)
        {
            Console.WriteLine("Applying Summer Offer (10%)");
            return amount - (amount * discount);
        }
    }
}
