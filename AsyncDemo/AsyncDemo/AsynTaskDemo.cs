namespace AsyncDemo
{
    class AsynTaskDemo
    {
        //here Long task will run after new thread cause it i goes sleep for 10 seconds 
        public static async  void Method()
        {
           await  Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");
           
        }

        public static void LongTask()
        {
            Console.WriteLine("long Task Method");
            Thread.Sleep(10000);
        }
    }
}
