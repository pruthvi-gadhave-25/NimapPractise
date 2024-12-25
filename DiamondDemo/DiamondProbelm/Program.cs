
using System;

namespace DiamondProblem
{
    //Base class A 
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Print from A ");
        }
    }
  
    class B :A
    {
        public override void Print()
        {
            Console.WriteLine("Print from b ");
        }
    }
    class C  : B
    {
        public override void Print()
        {
            Console.WriteLine("Print from c ");
        }
    }

    //so here we can inhertit B and C class from D 
    //Compiler Error  
    //  D cannot have multiple base classes 
    //class D : B , C
    //{

    //}


    public interface IAInterface
    {
        void Print();
    }
    public interface IBInterface
    {
        void Print();
    }

    public class D : IAInterface, IBInterface
    {
        public void Print()
        {
            Console.WriteLine("From D class");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {   
            //using multiple inhritence 
            //here if we create object from D  get conflict from which print mthod access


            //using interface 
            D d = new D();
            d.Print();
        }
    }

}
