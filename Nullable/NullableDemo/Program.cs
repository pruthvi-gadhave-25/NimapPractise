namespace NullableDemo
{

    public class Program
    {

        public static void Main()
        {

            //Nullable
            //used for  condition get values from databses if null aloowed them to store 
            //e.g. Stored Procedure ->> pass @A ,@B an dreturn @C which can be null 
            // -->So, in that case, we should use a Nullable Variable, which can also take invalid as an allowed value.

            int? i = null ; 
           // int j = i; // CE
            Console.WriteLine("value of i  = "+ i.ToString()  );


            //var can sstore nullable values 
            // var? i = 4;  //Not allowed Gives error 


            //-----------------

            //here if z is not nullable then error occurs
            int? x = 4;
            int y = 3;
            int? z = x * y;
            Console.WriteLine(z.ToString());


            int? a = null;
            int b = 4;
            int d = a ?? 0;
            int? res;
            res = a ??  b;
            Console.WriteLine("Result = " +res.ToString()) ;// result will be  4 if a ==  null  else 5 
            Console.WriteLine("Result of D = " +d) ;// result will be  5 

      

             
        }
    }
}