using DependencyInversion.Interface;

namespace DependencyInversion
{
    public class Calculator
    {

        public ICalculatorOperation CalculatorOperation { get; }


        //here  we are using dependency Injction using Constructor 
        //injceting ICalculatorOperation reference 
        public Calculator(ICalculatorOperation calculatorOperation)
        {
            CalculatorOperation = calculatorOperation;
        }

       public  double Solve (double i , double j)
        {
           return  CalculatorOperation.Calculate(i, j);
        }
    }
}
