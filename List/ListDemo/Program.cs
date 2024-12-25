using System;
using System.Collections;
using System.Collections.Generic;

namespace ListDemo 
{
   public class Progrm
    {
        public static void Main()
        {
            List<int> list = new List<int>();
          

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(87);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);
            //Console.WriteLine(list[2]);
            //foreach (int i in list) Console.WriteLine(i);





            //////--------------------Lambda Demo  ---------------------------////////////////
            ///
            //used to write method in shorter way 
            //calling mthods from LambdaDemo class 
            //

            //Basic method 
            int num = LambdaDemo.Square(5);
            Console.WriteLine(num );


            //But same mthod can be written using Lmabda == Anonymous Method using delagete 

            Func<int, int> sqr = LambdaDemo.Square;
            Console.WriteLine(sqr(3));

            //more concise 
            Func<int, int> add = num => num + 1;
            Console.WriteLine(add(5));
        }
    }
}

//--Resized Dynamically but array can resize 
//--it Allows Duplicate 
//-- based index access element 

