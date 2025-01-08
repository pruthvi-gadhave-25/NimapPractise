namespace DependencyInversion
{
    public  class Program
    {

        /// <summary>

        /// </summary>
        /// 
        /// 
        /// 
        ///  Not following the Dependency Inversion Principle
        public class SalaryCalculator
        {
            public float CalaculateSalary(int hours, float hourlyRate) => hours * hourlyRate;
            

        }

        public class EMployeeDetails
        {
            public int Hours { get; set; }
            public float WorrkingRate { get; set; }

            public float GetSalary()
            {
                var salaryCalluator = new SalaryCalculator();
                return salaryCalluator.CalaculateSalary(Hours, WorrkingRate);

            }
        }
        //---------------------------------------DI -----------------Demo----------------
        //so use this way to Implement D

        public interface ISalaryCalculator
        {
            float CalaculateSalary(float hours, float hourlyRate);
        }

        public class SlaryCal : ISalaryCalculator
        {
            public float CalaculateSalary(float hours, float hourlyRate)
            {
               return hours * hourlyRate;
            }
        }

        public class EmpDetails
        {   
             
            public readonly ISalaryCalculator _calculateSalry;

            public int Hours { get; set; }
            public int HourRate { get; set; }

            public EmpDetails(ISalaryCalculator calaculateSalaryCalculator)
            {
                _calculateSalry = calaculateSalaryCalculator;
            }
           
            public float GetSalary()
            {
               return  _calculateSalry.CalaculateSalary(Hours, HourRate);
            }
            

        }

        //---------------------------------------DI End  -----------------Demo----------------

        static void Main(string[] args)
        {
            
                        
        }
    }
}
