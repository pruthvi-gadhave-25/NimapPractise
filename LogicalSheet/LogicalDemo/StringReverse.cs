using System;
using System.Text;

namespace LogicalDemo
{
    public class LogicalProblem
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
    }
}
