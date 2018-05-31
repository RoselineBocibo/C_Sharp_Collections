using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace GenericCollections
{
    enum EmployeeType
    {
        [Description("CONTRACT")]
        CONTRACT,
        [Description("PERMANENT")]
        PERMANENT
    }
    public class FileHandler
    {
        static List<Employee> employees = new List<Employee>();
       
        public static List<Employee> GetEmployees()
        {
            StreamReader reader = new StreamReader("Employeeinfo.txt");

            string line = string.Empty;

            while ((line = reader.ReadLine()) != null)
            {
                string[] employeeInfo = line.Split(',');
                string firstName = employeeInfo[0];
                string lastName = employeeInfo[1];
                string email = employeeInfo[2];
                string employeeType = employeeInfo[3];
                decimal hourlyRate = decimal.Parse(employeeInfo[4]);
                string jobTitle = employeeInfo[5];
                double hoursWorked = double.Parse(employeeInfo[6]);

            
                if (employeeType == EmployeeType.CONTRACT.ToDescription())
                {
                    int policiesSold = int.Parse(employeeInfo[7]);
                    employees.Add(new ContractEmployee(firstName, lastName, email, employeeType, hourlyRate, jobTitle, hoursWorked, policiesSold));
                }
                else
                {
                    employees.Add(new PermanentEmployee(firstName, lastName, email, employeeType, hourlyRate, jobTitle, hoursWorked));
                }

            }

            return employees;

        }
    }
}
