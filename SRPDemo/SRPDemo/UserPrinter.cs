using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    public class UserPrinter
    {
        //private const filePath  = "";

        public void Print(User user) {

            Console.WriteLine($"User {user.Name} was saved successfully!");

        }
    }
}
