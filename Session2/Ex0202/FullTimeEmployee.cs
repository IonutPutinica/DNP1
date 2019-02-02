using System;
namespace Ex0202
{
    public class FullTimeEmployee : Employee
    {
        private double monthlySalary;
        public override double GetMonthlySalary()
        {
            return monthlySalary;
        }
    }
}