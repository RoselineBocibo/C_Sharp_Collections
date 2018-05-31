using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class PermanentEmployee : Employee
    {
        private const int MONTH_DAYS = 20;
        public PermanentEmployee(string firstName, string lastName, string email, string employeeType, decimal hourlyRate, string jobTitle, double hoursWorked) : base(firstName, lastName, email, employeeType, hourlyRate, jobTitle, hoursWorked)
        {
        }

        public override decimal CalculateSalary()
        {
            return HourlyRate * (decimal)HoursWorked * MONTH_DAYS;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\t{CalculateSalary()}";
        }
    }
}
