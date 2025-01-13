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

            //------------Missing Numbers  -------------------
            int[] numbers = { 1, 2, 3, 4, 5, 7 }; //
            LogicalProblems.MissingNumber(numbers);
            //------------Missing Numbers  -------------------



            //------------Prime Numbers from given  Numbers  -------------------
            Console.WriteLine("\nPrime Numbers from given  Numbers");
            int n = 10;
            for (int i = 2; i < n; i++)
            {
                bool isNumPrime = LogicalProblems.IsPrimeNum(i);
                if (isNumPrime)
                {
                    Console.Write(i + ",");
                }
            }
            Console.WriteLine("\n");
            //------------Missing Numbers  -------------------
        }
    }
}
