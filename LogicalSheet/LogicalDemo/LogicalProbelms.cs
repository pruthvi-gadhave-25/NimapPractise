using System;
using System.Text;

namespace LogicalDemo
{
    public class LogicalProblems
    {
        //2. WAP to reverse an integer without converting it to a string, without using any built-in methods. 

        public static int ReverseIntegerValue(int num )
        {
            int revNum = num;
            int res = 0;
            while(revNum > 0)
            {
                int ld = revNum % 10;
                res = (res * 10) + ld;
                revNum = revNum / 10;
            }

            return res;

        }

        public static  void RevString(string str )
        {
            //char[] chars = str.ToCharArray();
           StringBuilder stringBuilder = new StringBuilder();
            
            for(int  i = str.Length-1; i>=0; i--)
            {
                stringBuilder.Append( str[i] );
            }

            Console.WriteLine(stringBuilder);

          
        }

        public static void FibonaciNoRecursion(int num)
        {

            //Input: N = 10
            //Output: 0 1 1 2 3 5 8 13 21 34
            int n1 = 0;
            int n2 = 1;
            int sum = 0; 

            for(int i = 0 ;i<= num; i++)
            {
                Console.Write(n1 + " , ");

                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
               
            }
            
        }

        public static int FibbonaciUsingRecursion(int n )
        {
            if (n <= 1)
            {
                return n;
            }

            return FibbonaciUsingRecursion(n - 1)+ FibbonaciUsingRecursion(n-2);
        }

        public static void SecondLargest()
        {
            //[12, 35, 1, 10, 34, 1]
            int[] arr = { 12, 35, 1, 10, 34, 1 }; // o/p =34 

            int max = -1;
            int secondMax = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {                   
                        secondMax = max;
                        max = arr[i];                                      
                }
                if (arr[i] < max && arr[i ] > secondMax)
                {
                    secondMax = arr[i];
                }
            }

            Console.WriteLine( $"max is {max} ans secondMAx  :{secondMax}");
        }

        public static int MissingNumber(int[] numbers)
        {   
            //using for loop greater number logic 
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!(numbers[i + 1] == (numbers[i] + 1)))
                {
                    return numbers[i] + 1;
                }
            }
            return 0;
        }

        public static bool IsPrimeNum(int num)
        {

            if (num == 1 || num == 2) return true;
            for (int i = 2; i < num; i++)
            {
                if (num % 2 == 0) return false;
            }
            return true;

        }

        public static int  SquareRoot(int num )
        {
            //WAP for getting a square root of a given number.

          
            int res = 1;
            while (res * res <= num) {
                res++;
            }

            return res - 1;
        }
    }
}
