using System.Threading;
namespace ThreadDemo
{
    public class Program
    {
        public static void Main()
        {
            Thread thread = new Thread(new ThreadStart(PrintNumbers));
            thread.Start();
            var state =  thread.ThreadState;
            Console.WriteLine(state);

        }

        public static void PrintNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+" ");
            }
        }
    }
}
