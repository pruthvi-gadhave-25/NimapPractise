using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class FinallyException
    {

        public static void FinallyDemo()
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter("file.txt");
                writer.WriteLine("Hwllo FIle Hanfdling demo finanalu block");

            }
            catch { }
            finally {
                if(writer != null)
                {
                    Console.WriteLine("writer closed");
                    writer.Close(); //cleanup resourse /Close the resourse 
                }

                Console.WriteLine("This line will be executed");
                //int result = Convert.ToInt32("TEN");

                throw new Exception("Exception in FINALLY block");

                Console.WriteLine("This line will NOT be executed");
            }
        }

    }
}
