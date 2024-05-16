using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations Multiply = new MathOperations();

            Console.WriteLine("Give me a number?");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            int result = Multiply.MultiplyMe(userNum1);
            Console.WriteLine(result);

            //Console.WriteLine("give me a number");
            //int userNum1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("give me another number, but you don't have to because it is an optional parameter");
            //int userNum2 = Convert.ToInt32(Console.ReadLine());
            
            //if (userNum2 > 0)
            //{
            //    int finalresult = Multiply.MultiplyMe(userNum1);
            //    Console.WriteLine(finalresult);
                
            //}
            //else
            //{
            //    int finalresult = Multiply.MultiplyMe(userNum1, userNum2);
            //    Console.WriteLine(finalresult);
            //}
            Console.ReadLine(); 
        }
    }
}
