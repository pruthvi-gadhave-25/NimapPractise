 namespace AsyncDemo{

public  class Program
    {

        public static void Main()
        {


            AsynTaskDemo.Method();
            Console.WriteLine("Main Thread");
            //new thread will print before Long method 

            // simple way to achive run Long task and then run other 
            //somka the Method await async 

        }


       
    }
}
