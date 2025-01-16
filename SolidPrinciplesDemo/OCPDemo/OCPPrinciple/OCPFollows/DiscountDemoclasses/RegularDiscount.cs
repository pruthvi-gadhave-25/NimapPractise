using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPPrinciple.OCPFollows.Interface;

namespace OCPPrinciple.OCPFollows.DiscountDemoclasses
{
    public class RegularDiscount : IDiscountStrategy
    {
        public double  DiscountCalaculator(double amount)
        {
            return amount * 0.1;
        }
    }
}
