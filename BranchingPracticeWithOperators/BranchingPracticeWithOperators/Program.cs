using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingPracticeWithOperators
{
    class Program
    {
        static void Main()
        {
            //Branching to help evaluate what age someone is. 
            Console.WriteLine("Hi, how old are you?");
            string userInput = Console.ReadLine();
            int userAge = Convert.ToInt32(userInput);
            if (userAge < 18)
            {
                Console.WriteLine("You are not an adult yet");
            }
            else
            {
                Console.WriteLine("You are an adult! Congrat-adolences are well in order.");
            }



            //To evaluate if someone is telling the truth or not. 
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            if (userName == "Trason")
            {
                Console.WriteLine("Thank you for telling the truth");
            }
            else if (userName == "Jeff")
            {
                Console.WriteLine("Liar Liar pants on fire!");
            }
            else if (userName == "")
            {
                Console.WriteLine("You must supply a name!");
            }
            else
            {
                Console.WriteLine("That is a strange name! Try again");
            }

            //To evaluate if your luggage can go on the plane
            Console.Write("What is the weight of your luggage? ");
            string luggageWeight = Console.ReadLine();
            int trueLuggageWeight = Convert.ToInt32(luggageWeight);
            if (trueLuggageWeight > 45)
            {
                Console.WriteLine("TSA: You suck, consolidate your stuff and try again!");
            }
            else if (trueLuggageWeight <= 45)
            {
                Console.WriteLine("You have a wonderful day sir!");
            }
            else
            {
                Console.WriteLine("Please place your luggage on the scale");
            }

            int num10 = 26;
            int num11 = 25;
            string result = num10 < num11 ? "Your evaluation is true" : "Your evaluation is false";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

}
