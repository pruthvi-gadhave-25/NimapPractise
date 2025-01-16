using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPPrinciple.OCPFollows
{
    public class Invoice
    {
        //method will be overrride  in base class 
        // if new invoice type added then it will class override the Invoice class 
        //we can use ABstraction ,Intefaces , Base classes                                                   
        public virtual  double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }


    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) -40  ;
        }
    }
    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }
}
