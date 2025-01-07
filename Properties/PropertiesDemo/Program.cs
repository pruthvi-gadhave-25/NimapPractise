using System;
using System.Linq;

namespace PropertiesDemo
{
    internal class Program
    {
        //interface cannot have filed mambers but has properties and methods 
        //abstract class can Inherit Interface and class/Abstract class 
        //but interface can innot inherit class/abstract class 
        //interface can implement other Interface
        //multiple abstract classes cannot inheri from a class 
        //Interface has public  by default modifiers for methods and properties 
        //multiple abstract classes cannot inherit from a class 

        static void Main(string[] args)
        {

            string str = "efguef";
            string.Join( ", ", str);
            string str1 = null;
            Console.WriteLine(str1);

            int num = 10;
            double d = num;
            Console.WriteLine(num);
             byte b =6;
            d = b;
            Console.WriteLine(d);


            //int n = d;
        }

       public  class A
        {
            public  virtual void Foo()
            {

            }
        }
        class B : A
        {
            public override void Foo()
            {
               
            }
        }

        class C : A
        {
            public override void Foo()
            {

            }
        }

        //class D : B ,C 
        //{

        //}
        public abstract class classB
        {

        }
        public abstract class classC
        {

        }
        interface IB
        {
            void DoSoemthingB();
        }
        interface IA : IB
        {
            void DoSoemthingA();

        }

        //multiple abstract classes cannot inherit from a class 

        //public abstract class classA :   classB  ,classC  //Not Possible 
        //{
        //    public void DoSoemthingA()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //abstract class can implment multiple interface 
        public abstract class classA : IA ,IB       // Possible 
        {


            /// <summary>
            /// can use any access specifier 
            /// </summary>
            public abstract void Zoo1();
            public  void DoSoemthingA()
            {
                throw new NotImplementedException();
            }

            public void DoSoemthingB()
            {
                throw new NotImplementedException();
            }
        }

        //Interface has public  by default modifiers for methods and properties 
        interface IC
        {
              void Zoo();
            //public void Zoo() // gives error 
        }

    }
}
