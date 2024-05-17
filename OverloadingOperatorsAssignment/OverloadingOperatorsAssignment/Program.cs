using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee();
            Emp1.ID = 1234;
            Emp1.FirstName = "Sam";
            Emp1.LastName = "Smith";
            Employee Emp2 = new Employee();
            Emp2.ID = 1234;
            Emp2.FirstName = "Susan";
            Emp2.LastName = "Flop";

            Emp1 == Emp2;


        }
    }
}
