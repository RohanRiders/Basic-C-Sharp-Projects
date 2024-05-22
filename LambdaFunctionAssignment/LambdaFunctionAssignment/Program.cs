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

            List<int> employeeIDs = employee.ID.Where(x => x > 5).ToList();
            foreach (int employeeID in employeeIDs)
            {
                Console.WriteLine( "Here is the result of the lambda function " + employeeID);
            }




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
