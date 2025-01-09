namespace AsyncDemo
{
    public  class AsyncExample
    {
      
        public static async  Task Method1()
        {
            await Task.Run(() =>

            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("Method 1 : "+i);
                    Task.Delay(100).Wait();
                }
            });
        }


        public static void Method2()
        {
            for(int i =0; i< 50; i++)
            {
                Console.WriteLine("Method2+: " + i);
                Task.Delay(100).Wait();
            }
        }
    }
}

//public static async Task Method1()
//{
//    await Task.Run(() =>
//    {
//        for (int i = 0; i < 100; i++)
//        {
//            Console.WriteLine(" Method 1");
//            // Do something
//            Task.Delay(100).Wait();
//        }
//    });
//}
