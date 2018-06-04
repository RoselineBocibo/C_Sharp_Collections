using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Employees.BAL;
using Employees.Models;

namespace EmployeesGenericCollections.UnitTest
{
    public class TestContractEmployeeSalary
    {
        [Fact]
        public void TestSalary()
        {
            ContractEmployee contract = new ContractEmployee("Rose", "Mckay", "r.mckay@gm.com", "CONTRACT", 50, "Developer", 8, 30);

            Assert.Equal("8800,0", contract.CalculateSalary().ToString());
        }
    }
}
