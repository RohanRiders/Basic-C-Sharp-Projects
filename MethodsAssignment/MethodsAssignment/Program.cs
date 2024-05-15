using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What number would you like to do the math operation on?");
            MathOperations MathLogic = new MathOperations(); //intantiating the new MathOperations object/class. 
            int userInput = Convert.ToInt32(Console.ReadLine()); //Taking in the user input and converting to an integer. 
            int sum = MathLogic.AddTwoNumbers(userInput);// based on the userinput we call the AddTwoNumber method and run the operation. 
            Console.WriteLine(sum);
            int product = MathLogic.MultiplyTwoNumbers(userInput); // based on the userinput we call the MultiplyTwoNumbers method and run the operation.
            Console.WriteLine(product);
            int quotient = MathLogic.DivideTwoNumbers(userInput); // based on the userinput we call the DivideTwoNumbers method and run the operation.
            Console.WriteLine(quotient);
            Console.ReadLine(); 


        }
    }
}
