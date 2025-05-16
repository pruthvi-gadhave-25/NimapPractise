 namespace AsyncDemo{

public  class Program
    {

        public  static void Main()
        {
            Console.WriteLine("Main starts ");        
             Task1().Wait();
             Task2().Wait();
             Task3().Wait();
            Console.WriteLine("Main Ends  ");   
            Thread.Sleep(1000);
        }



        //if  method is async  await then it will not block method that is Non Blocking process 
        //if method is  not async await then  delayed task complete then only  next line code will work 
        public  async  static  Task Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("T1 ... Start 5sec");
                Thread.Sleep(5000);
                Console.WriteLine("T1 ... End 5sec");
            });
            Console.WriteLine("... Task1 Completed ");
        }
        public async static Task Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("T2 ... Start 3sec\n");
                Thread.Sleep(3000);
                Console.WriteLine("T2 ... End 3ec\n");
            });
            Console.WriteLine("... Task1 Completed ");
        }
        public async static Task Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("T3 ... Start 1sec");
                Thread.Sleep(1000);
                Console.WriteLine("T3 ... End 1sec");
            });
            Console.WriteLine("... Task1 Completed ");
        }







    }
}
