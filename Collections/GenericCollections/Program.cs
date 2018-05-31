using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = FileHandler.GetEmployees();

            Header();
            employees.ForEach(employee =>
            {
                if (employee is PermanentEmployee)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(employee.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(employee.ToString());
                }
            });

            Console.ReadLine();
        }

        private static void Header()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("FirstName\tLastName\tEmail\tJobType\tHourly Rate\tJob Title\tHours Worked\tPolicies Sold");
        }
    }
}
