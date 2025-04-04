﻿using System;
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
        ///Can an interface inherit from another interface? Yes  <summary>
        /// Can an interface inherit from another interface? Yes //

        //abstract methods are deafult vistual in abstract class  and Then must be OVERRIDEN in child class 
        // if class implwnt interface but dont want implemnt all , method implementation then make class as abstract 
        /// </summary>
        /// <param name="args"></param>

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

            FullTimeEmployee fl = new FullTimeEmployee(30000, "Pruthvi");
            fl.CalculateSalary();
            Employee emp = new FullTimeEmployee(845834, "jgduw");
            //Employee emp1 = new Employee(823, "wyegu"); not possible 

            var strCheck = "eugf";
            dynamic name = 45;


            object first = 10;
            first = "wey";
            Console.WriteLine( "First VAlue "+first);
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
        interface IA 
        {
       
            void DoSoemthingB();

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


        //////////--------------------abstract demo -------------
        ///

        public abstract class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }

            //abstract method cn have constructor 
            public Employee(int id , string name )
            {
                this.Id = id;
                this.Name = name;
            }

            //thsis can be done only in abstraction class 
            public abstract decimal CalculateSalary();

            public void GetDetails()
            {
                Console.WriteLine($"EMployee Name is {Name}  and its id is  : {Id}");
            }
        }

    


        public class FullTimeEmployee : Employee
        {
                
            public FullTimeEmployee(int id ,string name) :base(id, name )
            {

            }
            public decimal MonthlySalary { get; set; }

            public override   decimal  CalculateSalary()
            {
                return MonthlySalary;
            }
        }

        public class DemoClass : IA, IB
        {
            void IA.DoSoemthingB() { }
            void IB.DoSoemthingB() {}
        }
    }
}
