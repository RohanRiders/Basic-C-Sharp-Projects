using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAssignmentConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> stringList = new List<string>();
            stringList.Add("USA");
            stringList.Add("China");
            stringList.Add("England");
            stringList.Add("Germany");
            stringList.Add("France");

            Console.WriteLine("Give me a country name?");
            string userInput = Console.ReadLine();

            for (int i = 0; i < stringList.Count; i++)
            {
                if(userInput == "USA")
                {
                    int stringIndex = stringList.IndexOf("USA");
                    Console.WriteLine("USA, USA, USA! The index is: " + stringIndex);
                    Console.ReadLine();
                    return;
                }
                else if (userInput == "Russia")
                {
                    int stringIndex = stringList.IndexOf("Russia");
                    Console.WriteLine("For the mother land! The index is: " + stringIndex);
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("You didn't provide a country on the list");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine(stringList);
            Console.ReadLine(); 

            //List<int> outSideTemp = new List<int>();
            //outSideTemp.Add(100);
            //outSideTemp.Add(85);
            //outSideTemp.Add(75);
            //outSideTemp.Add(31); 

            //foreach( int temp in outSideTemp)
            //{
            //    if (temp <= 75)
            //    {
            //        Console.WriteLine("You need a jacket");
            //    }
            //}

            //Console.ReadLine();

            //int[] patientTemp = new int[3] { 98, 101, 103 };

            //for (int i = 0; i < patientTemp.Length; i++)
            //{
            //    if (patientTemp[i] > 100)
            //    {
            //        Console.WriteLine("You need to stay home from work!");
            //    }
            //}
            //Console.ReadLine(); 

            //Console.WriteLine("Go ahead and tell me what your favorite car is");

            //string[] myStringArray = new string[5];


            //for (int i = 0; i < myStringArray.Length; i++)
            //{

            //    myStringArray[i] = Console.ReadLine();
            //}

            //Console.WriteLine(myStringArray);
            //Console.ReadLine();

            //foreach(string item in myStringArray)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            //int myNum1 = 1; //This is an infinate loop!!!!!!!!!!!!
            //bool isTrue = Convert.ToBoolean(myNum1);

            //while (isTrue)
            //{
            //    Console.WriteLine("This is an infinate loop and you can't stop me!!!!");
            //}
        } 
    }
}
