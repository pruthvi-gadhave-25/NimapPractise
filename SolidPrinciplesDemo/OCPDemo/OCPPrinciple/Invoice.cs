namespace OCPPrinciple
{
    public enum InvoiceType
    {
        FinalInvoice ,
        ProposedInvoice
    }
    public class Invoice
    {
        //if nwe need to add another Invoice type  functonality then we need to write another if else condition
        //so it is against the OCP Principle 
       
        public double GetInvoiceDiscount(double amount , InvoiceType invoiceType)
        {
             double finalAmount = 100;

        if(invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount -100 ;
            }
            else if(invoiceType== InvoiceType.ProposedInvoice)
            {
                finalAmount = amount -100 ;
            }
            return finalAmount;
    }
    }
}

//IF NOT FOLLOW OCP 
// -->
// If you allow a class or function to add new logic, then you, as a developer, need to test the entire application’s functionality, 
// including the old and new functionalities.




//SO FOllwing OCP Principle 

// --> We'll  create the classes from base class Inherit them from base class 
//Example 

// Invoice(){  double virtual GetInvoiceDiscount(double amount) }
//  FinalInvoice : Invoice {  overrid GetInvoiceDiscount(double amount )}
//  ProposedInvoice : Invoice {  overrid GetInvoiceDiscount(double amount )}

