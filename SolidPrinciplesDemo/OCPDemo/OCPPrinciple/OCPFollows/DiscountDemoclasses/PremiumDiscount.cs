using OCPPrinciple.OCPFollows.Interface;

namespace OCPPrinciple.OCPFollows.DiscountDemoclasses
{
    public class PremiumDiscount : IDiscountStrategy
    {
        public double DiscountCalaculator(double amount)
        {
            return amount * 0.3;
        }

       
    }
}
