using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctionAssignment
{
    public class Employee
    {
        public int id;
        public string FirstName;
        public string LastName;

        public List<string> Employees = new List<string>()
        {
                "Joe",
                "Jim",
                "James",
                "Joe",
                "Fanny",
                "William",
                "Troy",
                "Louis",
                "Emily",
                "Hillary"
        };

        public List<int> ID = new List<int>()
        {
            123,
            321,
            1234,
            4321,
            12345,
            54321,
            123456,
            654321,
            1234567,
            7654321,
        };

    }

}
