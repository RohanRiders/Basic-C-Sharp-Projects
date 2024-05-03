using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonApp
{
    class Program
    {
        static void Main()
        {
            //This is the initial message at the beginning of the program.
            string initialMessage = "Anonymous Income Comparison Program";
            Console.WriteLine(initialMessage);
            

            //Create "Person 1" profile with hourly rate and hours worked per week.
            string person1 = "Person 1:";
            Console.WriteLine(person1);

            string hourlyRateP1 = "What is your hourly rate?";
            Console.WriteLine(hourlyRateP1);
            string currentHourlyRateP1 = Console.ReadLine();


            string hoursPerWeekP1 = "What is your hours worked per week?";
            Console.WriteLine(hoursPerWeekP1);
            string currentWeeklyHoursP1 = Console.ReadLine();

            //Calculating Person 1 rate and printing the results. 
            int currentHourlyRateP1number = Convert.ToInt32(currentHourlyRateP1);
            int currentWeeklyHoursP1number = Convert.ToInt32(currentWeeklyHoursP1);
            int weeksInYearP1 = 52;
            int annualSaleryP1 = (currentHourlyRateP1number * currentWeeklyHoursP1number) * weeksInYearP1;
            Console.WriteLine("This is person 1's annual salary: " + annualSaleryP1);


            //Create "Person 2" profile with hourly rate and hours worked per week. 
            string person2 = "Person 2:";
            Console.WriteLine(person2);

            string hourlyRateP2 = "What is your hourly rate?";
            Console.WriteLine(hourlyRateP2);
            string currentHourlyRateP2 = Console.ReadLine();


            string hoursPerWeekP2 = "What is your hours worked per week?";
            Console.WriteLine(hoursPerWeekP2);
            string currentWeeklyHoursP2 = Console.ReadLine();
            

            //Calculating Person 2 rate and printing the results. 
            int currentHourlyRateP2number = Convert.ToInt32(currentHourlyRateP2);
            int currentWeeklyHoursP2number = Convert.ToInt32(currentWeeklyHoursP2);
            int weeksInYearP2 = 52;
            int annualSaleryP2 = (currentHourlyRateP2number * currentWeeklyHoursP2number) * weeksInYearP2;
            Console.WriteLine("This is person 2's annual salary: " + annualSaleryP2);


            bool whoIsRich = (annualSaleryP1 > annualSaleryP2);
            Console.WriteLine("Does Person 1 make more money than Person 2: " + whoIsRich);
            Console.ReadLine();

        }
    }
}
