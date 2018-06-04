using Employees.Models;

namespace Employees.BAL
{
    public class ContractEmployee : Employee
    {
        private const int  MONTH_DAYS = 20;
        private const int TARGET = 25;
        private const double COMMISSION_RATE = 0.1;

        private int policiesSold;

        public ContractEmployee(string firstName, string lastName, string email, string employeeType, decimal hourlyRate, string jobTitle, double hoursWorked, int policiesSold) : base(firstName, lastName, email, employeeType, hourlyRate, jobTitle, hoursWorked)
        {
            this.policiesSold = policiesSold;
        }

        public override decimal CalculateSalary()
        {
            decimal baseSalary = HourlyRate * (decimal)HoursWorked * MONTH_DAYS;

            if (policiesSold >= TARGET)
            {
                baseSalary += baseSalary * (decimal)COMMISSION_RATE;
            }

            return baseSalary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\t{CalculateSalary()}\t\t{policiesSold}";
        }
    }
}
