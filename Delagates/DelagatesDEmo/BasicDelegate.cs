using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesDEmo
{
    public class BasicDelegate
    {
        public static void PrintConsole(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void PrintFileMsg(string msg)
        {
            Console.WriteLine("File messge" + msg);
        }
    }
}
