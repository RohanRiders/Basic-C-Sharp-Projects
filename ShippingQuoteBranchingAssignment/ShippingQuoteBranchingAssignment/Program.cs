using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteBranchingAssignment
{
    class Program
    {
        static void Main()
        {
            //Greet the user and welcome them to the Package Express service
            Console.WriteLine("Welcome to Package Express. Please Follow the instructions below.");
            //Weigh the customers package 
            Console.WriteLine("Enter the package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            //Make sure that the weight does not exceed 50 or they will be asked to leave
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); 
            }
            else
            {
                return;
            }

            //Accept the customers package demensions
            Console.WriteLine("What is the package width?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the package height?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the package length?");
            int packagelength = Convert.ToInt32(Console.ReadLine());

            //if the total exceeds 50 they will be asked to consolidate. 
            if ((packageWidth+packageHeight)+packagelength > 50)
            {
                Console.WriteLine("Package too big to be shipped via package express");
            }
            else
            {
                return;
            }
            //Multiply the three demensions together, and multiply the product by the weight. Finally divide the outcome by 100. The result is the quote. 
            int packageDemensions = (packagelength * packageWidth) * packageHeight;
            int productByWeight = packageDemensions * packageWeight;
            int quoteResult = productByWeight / 100;
            Console.WriteLine("Here is your estimated total for shipping this package is: $" + quoteResult + "\nThank you!");
            Console.ReadLine();

        }
    }
}
