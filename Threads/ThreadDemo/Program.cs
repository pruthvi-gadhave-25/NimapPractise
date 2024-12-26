using System.Diagnostics;
using System.Threading;
namespace ThreadDemo
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Main Method Started......");


            //but  task will use  all core efficeinetly Tpl will manage multiple core 
            Parallel.For(0, 1000000, x => RunMillionIterations());



            //this will not use all cores efficiently 

            //Thread thread = new Thread(RunMillionIterations);
            //thread.Start();

            Console.Read();





        }

        public static void RunMillionIterations() {

            string x = "";

            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine(x + "s");
            }
        }
        }
       


    

}
