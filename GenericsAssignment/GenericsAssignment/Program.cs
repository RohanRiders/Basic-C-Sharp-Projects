using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> myEmployee = new Employee<string>();
            myEmployee.

            string[] stringArray = { "My", "Name", "Is", "Jim" };
            int[] intArry = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };

            displayElements(stringArray);
            displayElements(intArry);
            displayElements(doubleArray);

            Console.ReadLine();

        }

        
    }
}
