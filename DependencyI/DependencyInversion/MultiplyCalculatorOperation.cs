using DependencyInversion.Interface;

namespace DependencyInversion
{
    public class MultiplyCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x * y;
        }
    }
}
