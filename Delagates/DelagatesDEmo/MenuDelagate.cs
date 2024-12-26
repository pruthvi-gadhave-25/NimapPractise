using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesDEmo
{
   

    public class MenuDelagate
    {

        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
        public static void Exit()
        {   


            Console.WriteLine("Exiting the application...");
        }
    

    }
}
