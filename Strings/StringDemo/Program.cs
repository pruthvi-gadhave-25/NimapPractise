using System;
using System.Text;

namespace StringDemo
{
    public class Program
    {
        public static void Main()
        {
            //String 
            //String are Immutable  
           
            //When we concatenate string it will create new Object 
            //not godd for repwtaitive tasks string e.g loops 

            string name = "Pruthviraj";
            name += " Gadhave";
            ////we can  concetanate but it will create new String object means "Pruthiraj" and "Pruthviraj Gadhave" are different 
            Console.WriteLine(name);

            for(int i = 0; i< 10; i++)
            {
                name += i;
                name += ' ';
            }
           

            Console.WriteLine( "New String :"+  name);

            

            //StringBuilder 
            //These class is Written in System.Text Namespase
            //It will not create new Object it will modify the same string -Perfoemance good 
            //When to Use --  when we need to perform modfication ins tring frequently , e.g Loops 
            //it has methods Like Append , Insert , Trim, Split , SubString 
            StringBuilder   sb = new StringBuilder();
        
            for (int i = 0;i< 10; i++)
            {
                sb.Append(i).Append(' ');
            }
            var endTimeSb = DateTime.Now;

          

            Console.WriteLine( sb.ToString() );



            //String Interpolation  

            /// It is used to write string in more readble format 
            /// //it intrnally uses string and convert into string format by compiler 
            /// performenance same as string 
            string data = ""; 
            for(int i =0; i< 10; i++)
            {
                data += $"{i} "; //easily readble fromat 
            }
            Console.WriteLine("using String Interpolation " +data );
        }

        //string methods 
        //IsNullOrWhiteSpace
        //string.join
        //for one time replacement -- string.Replacement()
        //for multipple    strinbuilder.Replace(paameters)
    }
}