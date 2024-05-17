using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //polymorphism of Interface IQuittable being inherited from the Employee class.
            IQuittable NewEmployee = new Employee();

            NewEmployee.Quit(); //The Quit() method gets implemented from the IQuittable interface. 

            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName();
            Console.ReadLine(); 

        }
    }
}
