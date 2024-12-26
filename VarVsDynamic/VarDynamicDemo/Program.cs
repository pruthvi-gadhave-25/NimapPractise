namespace VarDynamicDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            //var 
            // -- Static  type ,check at compile time
            // once assigned type cant be changed 

            var num = 10;
            num = 56; //allwed 
            // var num = "jdbfh"; //this will give error 


            //Dynamic 
            // -- Types caheck at runtime time (i.e.Dynamic )
            // -- type can be changed 

            dynamic number = 100;
            number = "Pruthvi"; //this is allowed in dynamic 


            //Object  
            // Base class of all class 
            // -- Types caheck at runtime time 
            // -- type can be changed but nedd explicit typecasting 

            object first  = 10;
            first  = "pruthvi"; //this is not chekd at compile time ,checked at runtime
            
            Console.WriteLine(((string)first).Length);
            //Console.WriteLine(first.Length); //it will give compile time error Length not found method need explicit casting 





        }
    }
}