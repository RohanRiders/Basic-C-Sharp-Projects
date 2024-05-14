using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] myIntArray = { 8, 10, 20, 30 };

                Console.WriteLine("Give me a number to divide every number in the list by....");
                int userNumInput = Convert.ToInt32(Console.ReadLine());
                foreach (int num in myIntArray)
                {
                    int quotiant = num / userNumInput;
                    Console.WriteLine("Thank you! Here is the result: " + quotiant);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You didn't provide a valide number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero, Silly!");
            }
            Console.ReadLine();


            //try //For code where you are doing something it always goes in the 'try'. 
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex) //This is an exception specific to what the code is doing. Notice the custom message you can make. its customizable. 
            //{
            //    Console.WriteLine("Please type a whole number.");
            //    return; //This return traditionally allows you to take the user to a new page if something wrong happens. A return is common practic to do something like that. 
            //}
            //catch (DivideByZeroException ex) //This is another exception specific to what the code is doing. 
            //{
            //    Console.WriteLine("Please don't divide by zero");
            //}
            //catch (Exception ex) //This is the generic exception handling technique. 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally //This runs wheather or not the execution runs or throws and exception. Its usfually for when you want to log data if it was successfully or failed. Like for CC transactions.
            //{
            //    Console.ReadLine();
            //}
            
        }
    }
}
