using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurancePreQualConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAge = "What is your age?";
            Console.WriteLine(userAge);
            string userAgeInput = Console.ReadLine();

            string userDUIStatus = "Have you ever had a DUI?";
            Console.WriteLine(userDUIStatus);
            string userDUIStatusInput = Console.ReadLine();

            string userTicketNumberStatus = "How many speeding tickets do you have?";
            Console.WriteLine(userTicketNumberStatus);
            string userTicketNumberStatusInput = Console.ReadLine();

            int applicantAge = Convert.ToInt32(userAgeInput);
            int applicantTicketNumberStatus = Convert.ToInt32(userTicketNumberStatusInput);

            bool preQualAge = applicantAge > 15;
            bool PreQualDUI = userDUIStatusInput == "Yes";



            //The results of the application survey. 
            bool qualifiedStatus = (preQualAge && PreQualDUI != true && applicantTicketNumberStatus == 0);
            Console.WriteLine("Do you qualify for Car Insurance? " + qualifiedStatus);
            Console.ReadLine(); 

        }
    }
}
