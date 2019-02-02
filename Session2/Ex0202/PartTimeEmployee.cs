using System;
namespace Ex0202
{
    public class PartTimeEmployee : Employee
    {
        private double hourlyWage;
        private int hoursPerMonth;

        public override double GetMonthlySalary()
        {
            return hourlyWage*hoursPerMonth;
        }
    }
}