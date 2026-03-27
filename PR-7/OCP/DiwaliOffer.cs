using PR_7.OCP.Interfaces;

namespace PR_7.OCP
{
    class DiwaliOffer : SeasonalOffer
    {
        private double discount = 0.25;

        public double ApplyOffer(double amount)
        {
            Console.WriteLine("Applying Diwali Offer (25%)");
            return amount - (amount * discount);
        }
    }
}
