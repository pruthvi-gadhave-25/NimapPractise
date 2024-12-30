using System;

namespace AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new { name = "pruthvi", email = "iehfwio@mial.com" };
            Console.WriteLine(student);
            //here student is readonly   
          //  student.name = "ieufheufh";    ///  CE 
        }
        //Readonly 
        //used in selcet caluse query to return subset of propertis 
        //Anonymous Type- encapsulate  set of properties into single object 
        //used in LINQ 

    }
}
//Example 

//var productQuery =
//    from prod in products
//    select new { prod.Color, prod.Price };

//foreach (var v in productQuery)
//{
//    Console.WriteLine("Color={0}, Price={1}", v.Color, v.Price);
//}
