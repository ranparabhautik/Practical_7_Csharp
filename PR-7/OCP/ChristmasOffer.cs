using PR_7.OCP.Interfaces;

namespace PR_7.OCP
{
    class ChristmasOffer : SeasonalOffer
    {
        private double discount = 0.20;

        public double ApplyOffr(double amount)
        {
            Console.WriteLine("Applying Christmas Offer (20%)");
            return amount - (amount * discount);
        }
    }
}
