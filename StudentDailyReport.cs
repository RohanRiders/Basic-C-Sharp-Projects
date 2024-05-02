using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            string mySchool = "The Tech Academy\nStudent Daily Report";
            Console.WriteLine(mySchool);

            //A question asking for the name of the student.
            string nameQuestion = "What is your name?";
            Console.WriteLine(nameQuestion);
            string myName = Console.ReadLine();

            //A question asking what course the student is on
            string courseQuestion = "What course are you on?";
            Console.WriteLine(courseQuestion);
            string myCourse = Console.ReadLine();

            //A question about the page number the student is on.
            string pageQuestion = "What page are you on?";
            Console.WriteLine(pageQuestion);
            string myPageNumber = Console.ReadLine();
            int currentPageNumber = Convert.ToInt32(myPageNumber);

            //Asking if help is needed. 
            string helpQuestion = "Do you need help with anything? Please answer \"true\" or \"false\". ";
            Console.WriteLine(helpQuestion);
            string helpInput = Console.ReadLine();
            bool helpResponse = Convert.ToBoolean(helpInput);

            //Question seeking feedback.  
            string testimonyQuestion = "Where there any positive experiences you'd like to share? Please be specific" ;
            Console.WriteLine(testimonyQuestion);
            string testimonyInput = Console.ReadLine();

            //Question seeking feedback.  
            string feedBackQuestion = "Is ther any other feedback you'd like to provide? Please be specific.";
            Console.WriteLine(feedBackQuestion);
            string feedBackInput = Console.ReadLine();
            //Question for number of hours studied
            string hoursStudiedQuestion = "How many hours did you study today?";
            Console.WriteLine(hoursStudiedQuestion);
            string studiedHoursInput = Console.ReadLine();

            //End of the survey
            string farewellSignOff = "Thank you for your answers. An instructor will respond to this shortly. Have a great day! ";
            Console.WriteLine(farewellSignOff);
            Console.ReadLine();



        }
    }
}
