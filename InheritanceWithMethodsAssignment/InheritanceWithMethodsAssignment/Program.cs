using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.FirstName = "Sample"; //Notice how clean you are keeping your main program. These properties are set in other classes.
            employee.LastName = "Student";// You are assigning these properties values here. 

            employee.SayName(); //This is a super method that is inherited from the Person Class. 
            Console.ReadLine(); 
        }
    }
}
