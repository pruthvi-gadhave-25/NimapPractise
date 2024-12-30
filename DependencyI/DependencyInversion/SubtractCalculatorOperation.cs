using DependencyInversion.Interface;

namespace DependencyInversion
{
    public class SubtractCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x - y;
        }
    }
}
