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
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list[2]);
            foreach (int i in list) Console.WriteLine(i);
        }
    }
}

//--Resized Dynamically but array can resize 
//--it Allows Duplicate 
//-- based index access element 

