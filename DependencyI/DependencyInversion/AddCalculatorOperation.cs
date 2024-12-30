using DependencyInversion.Interface;

namespace DependencyInversion
{
    public class AddCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x + y;
        }
    }
}
