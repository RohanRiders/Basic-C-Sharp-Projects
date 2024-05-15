using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the class object MathOperations. 
            MathOperations OperateMe = new MathOperations();

            //calling the first overload of the method. 
            int sum = OperateMe.AddNumbers(10, 15);
            Console.WriteLine(sum);
            
            //calling the second overload of the method. 
            int product = OperateMe.AddNumbers(15.2f, 20.8f);
            Console.WriteLine(product);
          
            //Calling the third overload of the method.
            int solution = OperateMe.AddNumbers("1", "2");
            Console.WriteLine(solution);
            Console.ReadLine();
        }
    }
}
