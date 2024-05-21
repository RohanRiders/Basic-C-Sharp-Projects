using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Number num1; //struct class with variable name
            num1.Amount = 1000; //Here is the value assignment
            Console.WriteLine(num1.Amount); //print the value to the console. 
            Console.ReadLine(); 
        }

        struct Number //this is the struct definition. 
        {
            public decimal Amount;
        }
    }
}
