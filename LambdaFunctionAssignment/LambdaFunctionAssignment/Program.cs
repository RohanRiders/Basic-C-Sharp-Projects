using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> VIPList = new List<string>();
            Employee employee = new Employee();

            List<Employee> employeeID = employee.ID.Where(x => ????????????? > 5).ToList();

            foreach (string person in employee.Employees)
            {
                if(person == "Joe")
                {
                    VIPList.Add(person);
                    Console.WriteLine("The name " + person + " was found in the list");
                    continue;
                }
                else
                {
                    Console.WriteLine("This name does not match.");
                }
            }
            for (int i = 0; i < VIPList.Count; i++)
            {
                Console.WriteLine("Here are the members of the VIP list: " + VIPList[i]);
            }
            Console.ReadLine();
            
        }
    }
}
