using PR_7.OCP.Interfaces;

namespace PR_7.OCP
{
    class WinterOffer : SeasonalOffer
    {
        private double discount = 0.15;

        public double ApplyOffer(double amount)
        {
            Console.WriteLine("Applying Winter Offer (15%)");
            return amount - (amount * discount);
        }
    }
}
