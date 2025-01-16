using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LiskovP.BankAccount;

namespace LiskovP
{   

    ///we can change the object with its subtype without affecting the behavior.
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount savingAccount = new SavingAccount();
            BankAccount currentAccount = new CurrentAccount();
        }
    }
    //base class functoinaluy can be inhreited from it sub classes 
    public interface IFruit
    {
        string GetColor();
    }

    public class Apple : IFruit
    {
        public string GetColor()
        {
            return "Red ";
        }
    } 

    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit: {amount}, Total Amount: {Balance}");
        }

        public class SavingAccount : BankAccount
        {
        

        }
        public class CurrentAccount : BankAccount
        {

        }
    }

    public class Orange : IFruit { 
        public string GetColor()
        {
            return "Orange" ;
        }
        }
}

//In the Main method, we create objects for SavingsAccount and 
//CurrentAccount but define them as BankAccount types. 
//This follows the Liskov Substitution Principle (LSP), 
//which allows us to replace instances of derived classes with the base class without affecting 
//the program’s correctness.

// --> https://dotnettutorials.net/lesson/liskov-substitution-principle/
