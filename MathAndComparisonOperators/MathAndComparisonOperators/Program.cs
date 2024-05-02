using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.ReadLine(); 

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());
            //Console.ReadLine(); 

            //int product = 5 * 10;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //    int quotient = 100 / 5;
            //    Console.WriteLine(quotient);
            //    Console.ReadLine();
            //

            //remember a double data type if divided by two ints will result in an int and not a double. You need to show the compiler that you are using doubles or it will get confused.  
            //double quotient = 100.0 / 17.0; //You are indeed using two doubles so the compiler will be happy. If you got rid of the decimal points this compiler would be confused because they would be ints. 
            //Console.WriteLine(quotient);
            //Console.ReadLine(); 

            //This is the modules operator. This will result in 0. You can determine if a number is even or odd with the modules operator. 
            int remainder = 10 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine(); 
        }
    }
}
