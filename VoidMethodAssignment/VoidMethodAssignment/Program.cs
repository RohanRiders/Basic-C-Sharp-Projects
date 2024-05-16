using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 object1 = new Class1();

            Console.WriteLine("What number do you want to divde?");
            int myInt = Convert.ToInt32(Console.ReadLine());

            object1.myMethod(myInt);

            Console.WriteLine(myInt);

            Console.ReadLine(); 
        }
    }
}
