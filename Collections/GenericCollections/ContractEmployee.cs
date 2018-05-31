using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class ContractEmployee : Employee
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
            decimal base_salary = HourlyRate * (decimal)HoursWorked * MONTH_DAYS;

            if (policiesSold >= TARGET)
            {
                base_salary += base_salary * (decimal)COMMISSION_RATE;
            }

            return base_salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\t{CalculateSalary()}\t\t{policiesSold}";
        }
    }
}
