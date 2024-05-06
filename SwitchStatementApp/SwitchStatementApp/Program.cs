using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatementApp
{
    class Program
    {
        static void Main()
        {
            

            Console.WriteLine("Can you guess the month I was born in by giving me the month's number?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            bool guessedNumber = userInput == 8;

            do
            {
                switch (userInput) //Your switch statement does not need to be in sequential order, The case can be any number.
                {
                    case 1:
                        Console.WriteLine("You guessed January. Try again!");
                        Console.WriteLine("Guess a number!");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed February. Try again!");
                        Console.WriteLine("Guess a number!");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed March. Try again!");
                        Console.WriteLine("Guess a number!");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed April. Try again!");
                        Console.WriteLine("Guess a number!");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed May.");
                        Console.WriteLine("That is correct!");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You guessed June. Try again!");
                        Console.WriteLine("Guess a number!");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed July. Try again!");
                        Console.WriteLine("Guess a number!");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("You guessed August");
                        Console.WriteLine("That is correct!");
                        guessedNumber = true;
                        break;
                    case 9:
                        Console.WriteLine("You guessed September. Try again!");
                        Console.WriteLine("Guess a number!");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("You guessed October. Try again!");
                        Console.WriteLine("Guess a number!");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 11:
                        Console.WriteLine("You guessed November. Try again!");
                        Console.WriteLine("Guess a number!");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed December. Try again!");
                        Console.WriteLine("Guess a number!");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You are wrong!");
                        Console.WriteLine("Guess a number!");
                        break;

                }

            }
            while (!guessedNumber); //The "!" indicates a "false". While false run through the switch statement.
            Console.Read();

        }
    }
}
