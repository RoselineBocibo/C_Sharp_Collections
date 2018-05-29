using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static IDictionary<string, decimal> numberOfEmps;
        static void Main(string[] args)
        {
            numberOfEmps = AddEmployeesInfo();

            Console.WriteLine("Name\t\tSalary");

            foreach (var emps in numberOfEmps)
            {
                Console.WriteLine("{0}\t\t{1}", emps.Key, emps.Value);

            }

            Console.WriteLine("Enter employee to search: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Status: {Search(name)}");

            Console.ReadLine();
        }

        public static IDictionary<string, decimal> AddEmployeesInfo(string name = "", decimal salary = (decimal)0.0)
        {

            IDictionary<string, decimal> numberOfEmps = new Dictionary<string, decimal>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter employee name:");
                name = Console.ReadLine();

                Console.WriteLine("Enter salary of an employee:");
                salary = decimal.Parse(Console.ReadLine());

                numberOfEmps.Add(name, salary);

            }

            return numberOfEmps;
        }

        public static bool Search(string name)
        {
            bool containKey = false;

            if (numberOfEmps.ContainsKey(name))
            {
                containKey = true;
            }
            else
            {
                containKey = false;
            }
            return containKey;
        }
    }
}
