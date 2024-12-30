using System;

namespace DependencyInversion
{
    public class CalculatorProgram
    {


        public void AddMethod()
        {
            Calculator cal = new Calculator(new AddCalculatorOperation());
            var res = cal.Solve(3, 5);
            Console.WriteLine(res);
        }
        public void Subtract()
        {
            Calculator cal = new Calculator(new SubtractCalculatorOperation());
            var res = cal.Solve(3, 5);
            Console.WriteLine(res);
        }
        public void MuliplyMethod()
        {
            Calculator calculator = new Calculator(new MultiplyCalculatorOperation());
            double res = calculator.Solve(10, 5);
            Console.WriteLine(res);
        }
    }
    }
