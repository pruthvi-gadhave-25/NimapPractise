namespace DependencyInversion
{
    public class Program
    {
        static void Main(string[] args)
        {
           CalculatorProgram clProgram = new CalculatorProgram();

            clProgram.AddMethod();
            clProgram.MuliplyMethod();
            clProgram.Subtract();
        }



    }
}

//High-level modules should not depend on low-level modules. Both should depend on abstractions.
//Abstractions should not depend on details. Details should depend on abstractions.

// ref-- https://medium.com/@kedren.villena/simplifying-dependency-inversion-principle-dip-59228122649a
