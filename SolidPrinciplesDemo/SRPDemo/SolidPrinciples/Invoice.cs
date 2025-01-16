using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    /// <summary>
    /// this class will perform operation on Invoice only 
    /// </summary>
    public class Invoice
    {   

        public decimal InvAmount { get; set; }
        public DateTime InvAmout { get; set; }


        private Email _mail;

        private Logger _logger;


        public Invoice()
        {
            _logger =new  Logger();
            _mail = new Email();
        }

        public void AddInvoice()
        {
            _logger.Info("Add method Start");
            // Here we need to write the Code for adding invoice
            // Once the Invoice has been added, then send the  mail
            _mail.MailFrom = "emailfrom@xyz.com";
            _mail.MailTo = "emailto@xyz.com";
            _mail.EmailSubject = "Single Responsibility Princile";
          
            _mail.SendEmail();
        }

            ///AddInvoice Invoice 
        

        public void DeleteIVoice(string msg)
        {
            try
            {
                _logger.Info("Invoice start at " + DateTime.Now);
            }
            catch(Exception e)
            {
                _logger.Error("Error Ocured "+ e.Message);
            }
            //Delete invoice By ID 
        }
    }
}
