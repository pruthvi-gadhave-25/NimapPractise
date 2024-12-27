using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class BasicException
    {
        public static void ExceptionD()
        {
            try
            {
                int a, b, c;
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER ANY TWO NUBERS");
                b = int.Parse(Console.ReadLine());
              
              
                    c = a / b;
                    Console.WriteLine("C VALUE = " + c);
             
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.HelpLink);
            //    Console.WriteLine(ex.Source);
            //}
            finally
            {
                Console.WriteLine("excute ");
            }
        }
    }
}
