namespace OCPPrinciple.OCPFollows.Interface
{

    // interface for implemting discount  method
    // so PremiumDiscount ,  RegularDiscount class wil implemnt these methods 
    public  interface IDiscountStrategy
    {
         double DiscountCalaculator(double amount); 
    }
}
