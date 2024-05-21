using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please provide the current day of the week.");
                string userInput = Console.ReadLine();
                DaysOfWeek userInputConvert = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput); //converted the string to an enum item. If the enum item is found move on to the switch statement.

                switch (userInputConvert)
                {
                    case DaysOfWeek.Monday:
                        Console.WriteLine("Have a wonderful " + DaysOfWeek.Monday);
                        break;
                    case DaysOfWeek.Tuesday:
                        Console.WriteLine("Have a wonderful " + DaysOfWeek.Tuesday);
                        break;
                    case DaysOfWeek.Wednesday:
                        Console.WriteLine("Have a wonderful " + DaysOfWeek.Wednesday);
                        break;
                    case DaysOfWeek.Thursday:
                        Console.WriteLine("Have a wonderful " + DaysOfWeek.Thursday);
                        break;
                    case DaysOfWeek.Friday:
                        Console.WriteLine("Have a wonderful " + DaysOfWeek.Friday);
                        break;
                    case DaysOfWeek.Saturday:
                        Console.WriteLine("Have a wonderful " + DaysOfWeek.Saturday);
                        break;
                    case DaysOfWeek.Sunday:
                        Console.WriteLine("Have a wonderful " + DaysOfWeek.Sunday);
                        break;
                    default:
                        Console.WriteLine("You need to add a valid day of the week");
                        break;

                }
              
            }
            catch (Exception)
            {
                Console.WriteLine("Please write an actual day of the week.");
            }


            Console.ReadLine(); 



        }

        public enum DaysOfWeek
        {
            Monday, 
            Tuesday, 
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday,
            Sunday
        }
    }
}
