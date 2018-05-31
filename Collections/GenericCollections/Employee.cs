using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public abstract class Employee
    {
        #region Private Members 
        private string firstName;
        private string lastName;
        private string email;
        private string employeeType;
        private decimal hourlyRate;
        private string jobTitle;
        private double hoursWorked;

        #endregion

        #region Ctor 
        public Employee(string firstName, string lastName, string email, string employeeType , decimal hourlyRate , string jobTitle, double hoursWorked)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.employeeType = employeeType;
            this.hourlyRate = hourlyRate;
            this.jobTitle = jobTitle;
            this.hoursWorked = hoursWorked;
        }
        #endregion

        #region Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; }
        }

        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        #endregion

        #region Methods 
        /// <summary>
        /// This is a function that calculates the salary of an employee based on their job title.
        /// </summary>
        public abstract decimal CalculateSalary();

        public override string ToString()
        {
            return $"{firstName}\t{lastName}\t{email}\t{employeeType}\t{hourlyRate}\t{jobTitle}\t{hoursWorked}";
        }

        #endregion

    }
}
