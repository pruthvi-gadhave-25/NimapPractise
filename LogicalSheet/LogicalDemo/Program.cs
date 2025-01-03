using System;

namespace LogicalDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int num = 1234;
            //int res = LogicalProblem.ReverseIntegerValue(1234);
            //Console.WriteLine($"Revers of {num} is : {res }");

            //LogicalProblem.RevString("Nimap");

            LogicalProblem.FibonaciNoRecursion(15);
            //for (int i = 0; i < 15; i++) {
            //    LogicalProblem.FibbonaciUsingRecursion(15);
            //}
            Console.WriteLine(LogicalProblem.FibbonaciUsingRecursion(12));
        }
    }
}
