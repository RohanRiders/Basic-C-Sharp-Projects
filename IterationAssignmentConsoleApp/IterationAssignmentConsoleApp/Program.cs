using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAssignmentConsoleApp
{
    class Program
    {
        static void Main()
        {
            //Solution Part Six: //reference https://www.tutorialspoint.com/Chash-program-to-print-unique-values-from-a-list

            string[] abcList = { "A", "B", "C", "D", "C", "A" };

            List<string> mylist = new List<string>();
            List<string> duplicateList = new List<string>();

            foreach (var item in abcList)
            {
                if (!mylist.Contains(item))
                {
                    mylist.Add(item);
                }
                else
                {
                    duplicateList.Add(item);
                }
            }

            foreach (var item in mylist)
            {
                Console.WriteLine("Here is an original list memeber: " + item);
               
            }

            foreach (var item in duplicateList)
            {
                Console.WriteLine("Here is a duplicate in the list: " + item);
               
            }

            Console.ReadLine();

            // List<string> abcList = new List<string>();
            //abcList.Add("A");
            //abcList.Add("B");
            //abcList.Add("C");
            //abcList.Add("D");
            //abcList.Add("C");
            //abcList.Add("A");
            // Console.WriteLine("Initial List...");
            // foreach (string item in abcList)
            // {
            //     Console.WriteLine("{0}", item);
            // }

            // List<string> newList = abcList.Distinct().ToList();
            // Console.WriteLine("Unique elements...");            

            // foreach (string uniqueItem in newList)
            // {
            //     Console.WriteLine("{0}", uniqueItem);
            // }

            // Console.WriteLine("Here are the duplicated values...");
            //var myDuplicateValues = abcList.GroupBy(x => x)
            //     .Where(group => group.Count() > 1)
            //     .Select(group => group.Key)
            //     .ToList();
            // Console.WriteLine(myDuplicateValues);

            //Console.ReadLine();




            //Solution Part Five: Here is the solution for finding all elements in an array, even duplicates and printing them to the screen.
           List<string> groceryList = new List<string>();
            groceryList.Add("Cheese");
            groceryList.Add("Bread");
            groceryList.Add("Milk");
            groceryList.Add("Raspberries");
            groceryList.Add("Milk");
            groceryList.Add("eggs");

            Console.WriteLine("Type items to search for on the grocery list. If there is a match I'll display them to the consoel.");
            string userInput = Console.ReadLine();

            var result = Enumerable.Range(0, groceryList.Count)
                   .Where(i => groceryList[i] == userInput)
                   .ToList();

            if (groceryList.Contains(userInput))
            {
                foreach (var item in result) // You got your foreach loop to work first before you placed it in an if statement. Just for future troubleshooting scenarios. 
                {
                    Console.WriteLine("Grocery Item: " + groceryList[item] + "\n" + "Index of that item: " + item);
                }

            }
            else
            {
                Console.WriteLine("your item is not on the list");
            }

            Console.ReadLine();

            //REFERENCES: https://ravindradevrani.medium.com/multiple-ways-to-find-duplicates-in-c-array-with-pros-and-cons-b570142ce506

            //*************************************************************Everything below was an attempt to find a solution to the challenges above. 
            //int[] anArray = { 1, 5, 2, 7, 7, 3 };

            //var duplicateList = anArray.GroupBy(x => x)
            //    .Where(y => y.Count() > 1)
            //    .Select(z => z.Key).ToList();

            //foreach (var item in duplicateList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            //    string[] groceries = { "Cheese", "Bread", "Milk", "Raspberries", "Milk", "eggs" };
            //    for (int i = 0; i < groceries.Length; i++)
            //    {
            //        for (int j = i + 1; j < groceries.Length; i++)
            //        {
            //            if (groceries[i] == groceries[j])
            //            {
            //                Console.WriteLine(groceries[i]);
            //            }
            //        }
            //    }

            //    Console.ReadLine();


            //List<string> groceryList = new List<string>();
            //groceryList.Add("Cheese");
            //groceryList.Add("Bread");
            //groceryList.Add("Milk");
            //groceryList.Add("Raspberries");
            //groceryList.Add("Milk");
            //groceryList.Add("eggs");

            //Enumerable.Range(0, groceryList.Count)
            //    .Where(i => groceryList[i] == "Milk")
            //    .ToList();



            //Console.WriteLine("Type items to search for on the grocery list. If there is a match I'll display them to the consoel.");
            //string userInput = Console.ReadLine();

            //foreach (string item in groceryList)
            //{
            //    if (item == "Milk")
            //    {
            //        Console.WriteLine(groceryList.IndexOf(item));
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Something went wrong");
            //    }
            //}
            //Console.ReadLine();



            //bool found = false;

            //foreach(string groceryItem in groceryList)
            //{
            //    for ()
            //    if (groceryItem == userInput)
            //    {
            //        //Console.WriteLine("Here is the searched item: " + groceryItem.IndexOf(userInput));
            //        found = true;
            //        break;
            //    }

            //    Console.WriteLine("Here is the index of the item you searched: " + groceryList.IndexOf(userInput));

            //}

            //if(!found)
            //{
            //    Console.WriteLine("The item you're searching for is not on the list");
            //}


            //List<string> stringList = new List<string>();
            //stringList.Add("USA");
            //stringList.Add("China");
            //stringList.Add("England");
            //stringList.Add("Germany");
            //stringList.Add("France");

            //Console.WriteLine("Give me a country name?");
            //string userInput = Console.ReadLine();

            //for (int i = 0; i < stringList.Count; i++)
            //{
            //    if(userInput == "USA")
            //    {
            //        int stringIndex = stringList.IndexOf("USA");
            //        Console.WriteLine("USA, USA, USA! The index is: " + stringIndex);
            //        Console.ReadLine();
            //        return;

            //    }
            //    else if (userInput == "Russia")
            //    {
            //        int stringIndex = stringList.IndexOf("Russia");
            //        Console.WriteLine("For the mother land! The index is: " + stringIndex);
            //        Console.ReadLine();
            //        return;                    
            //    }
            //    else
            //    {
            //        Console.WriteLine("You didn't provide a country on the list");
            //        Console.ReadLine();
            //        return;
            //    }
            //}
            //Console.WriteLine(stringList);
            //Console.ReadLine(); 

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
