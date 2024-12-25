namespace OutRefDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //these are keywords for paremeters 
            //Out and ref are  used pass paramter  by reference 

         //OUT
                //  --no need to initialize value in passing  function
                //  --no need to return beacuse it has reference 
                //  --it can return multipe values from funtion 
               

            int res =24;   // this value will not pass cause of Out only reference passed and value get discared 
            Subtract(out  res);

            Console.WriteLine("OUT demo res value before : " + res);

            Console.WriteLine();



         //ref
                   // --need to initialize variable 
                   // --pass data and reference of variable 
                   // --it is two way (Data and Ref pased )
            int num = 20;
            Console.WriteLine("ref Demo Before passing " + num);
            Add(ref num);
            Console.WriteLine("ref Demo Before passing " + num);
        }

        

        public static void Subtract(out int x )
        {
            x = 89;
            x--;
        }

        public static void Add(ref int x)
        {
            x = 23;
            x++;
        }
    }
}
