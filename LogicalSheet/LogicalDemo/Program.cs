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


            //------------Fibbonaci -------------------
            LogicalProblems.FibonaciNoRecursion(15);
            //for (int i = 0; i < 15; i++) {
            //    LogicalProblem.FibbonaciUsingRecursion(15);
            //}
            Console.WriteLine(LogicalProblems.FibbonaciUsingRecursion(12));

            //------------Fibbonaci -------------------


            //------------2nd largest Array without sorting  -------------------
            LogicalProblems.SecondLargest();
            //------------2nd largest Array without sorting  -------------------
        }
    }
}
