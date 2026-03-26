using PR_7.OCP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PR_7.OCP
{
    class WinterOffer : SeasonalOffer
    {
        private double discount = 0.15;

        public double ApplyOffr(double amount)
        {
            Console.WriteLine("Applying Winter Offer (15%)");
            return amount - (amount * discount);
        }
    }
}
