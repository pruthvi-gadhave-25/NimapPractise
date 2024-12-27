namespace GenericDelagates
{

    public class Program
    {

        public static void Main()
        {
            //Func -- take multiple Input and return 1 o/p 
            //Predicate -- retun boolean 
            //Action -- return void


            //-------------------------------
            //Max 16 i/p and 1 o/p
            Func<int, float, double,double> obj1 = new Func<int, float, double ,double>(AddNumbers);
            double val = obj1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(val);


            //////////////////
            Console.WriteLine("Using lambd expression");
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine("Addiion is : "+ add(4, 5));

            Console.WriteLine();


            ///Action 
            ///Max 16 i/p no o/p 
            Action<string> message = new Action<string>(PrintMsg);
            message.Invoke("Called by  Action method ");

            //using Lambda Expression 

            Action<string> display = message   => Console.WriteLine(message);
            display("Action using Lambda Expression");

            Console.WriteLine();


            //Predicate 

            Predicate<string> obj3 = new Predicate<string>(CheckLength);
            bool status = obj3.Invoke("Pruthviraj");
            Console.WriteLine(status);

            //using lambda expression
            Predicate<string> isNameValid = (name) =>

               {
                   if (name.Length != 0)
                   {
                       return true;
                   }
                   return false;

               };
            Console.WriteLine(isNameValid("Pruthi"));
        }



        public static double AddNumbers(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void PrintMsg(string msg)
        {
            Console.WriteLine(msg);
        }

        public static bool CheckLength(string msg)
        {
            if(msg.Length >5)
            {
                return true;
            }
            return false;
        }
    }
}
