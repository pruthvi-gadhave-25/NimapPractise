 namespace AsyncDemo{

public  class Program
    {

        public static void Main()
        {


            //AsynTaskDemo.Method();
            //Console.WriteLine("Main Thread");


            //new thread will print before Long method 

            // simple way to achive run Long task and then run other 
            //somka the Method await async 

            Console.WriteLine("Before Fetch data");
            FetchData();

            Console.WriteLine("After Fetch Task ");
            Console.ReadLine();

        }



        //if  method is async  await then it will not block method that is Non Blocking process 
        //if method is  not async await then  delayed task complete then only  next line code will work 
        public   static  void FetchData()
        {
            Console.WriteLine("Fetching Data ... Start");
               Task.Delay(5000) ;
            Console.WriteLine("Fetching Data ... End");
        }



       
    }
}
