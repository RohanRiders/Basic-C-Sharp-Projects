using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {

            //List<int> intList = new List<int>(); //Lists are very dynamic. You can add integers and strings. 

            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);
            //Console.WriteLine(intList[1]);

            //List<string> intList2 = new List<string>();

            //intList2.Add("Hello");
            //intList2.Add("Trason");
            //intList2.Remove("How are you?");
            //Console.WriteLine(intList[1]);

            //You are going to use an array when you have a fixed quantity that you want to group together. 
            //You use them if you need to store large quantities of something. Ex: storing images in a database in binary. 
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 500 }; //This is the same thing as what you see above but just less work. 

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 }; //Even better way of writing an Array. Less work. 

            //numArray2[5] = 650; //Notice how the 5th index in the array above got changed. 

            //Console.WriteLine(numArray[3]); 
            //Console.WriteLine(numArray1[3]);//Notice how you get the same result with this new faster way of writing the array. 
            //Console.WriteLine(numArray2[3]);//Notice how you get the same result but with an even faster way
            //Console.WriteLine(numArray2[5]);//Notice how the initial value that was stored in memory was changed to a new value.
            //

            //string[] myStringArry1 = { "Hello", "My", "name", "is", "Doug" };
            //Console.WriteLine("Enter an index of the Array by giving me a number: ");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(myStringArry1[index]);

            int[] myIntArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Give me a number in the Array and I'll provide the index of that value.");
            int element = Convert.ToInt32(Console.ReadLine());
            bool ArrayValue = Convert.ToBoolean(element);

            myIntArray //See if you can use IndexOF() with the list data type instead of the Array. 
            do
            {
                switch (element)
                {
                    case 1:
                        Console.WriteLine("Here is the value: " + myIntArray[0]);
                        Console.WriteLine("Give me another index");
                        element = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Here is the value: " + myIntArray[1]);
                        Console.WriteLine("Give me another index");
                        element = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Here is the value: " + myIntArray[2]);
                        Console.WriteLine("Give me another index");
                        element = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Here is the value: " + myIntArray[3]);
                        Console.WriteLine("Give me another index");
                        element = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Here is the value: " + myIntArray[4]);
                        Console.WriteLine("Give me another index");
                        element = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Here is the value: " + myIntArray[5]);
                        Console.WriteLine("Give me another index");
                        element = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Here is the value: " + myIntArray[6]);
                        Console.WriteLine("Give me another index");
                        element = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Here is the value: " + myIntArray[7]);
                        Console.WriteLine("Give me another index");
                        element = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("The index you gave was out of bounds.");
                        break;
                }
            } while (ArrayValue);

            Console.ReadLine();

            //List<string> stringList = new List<string>(); //You can create lists of any data type. Arrays are usually used if you have a fixed amount of data. Lists are generally used more often than Arrays. 
            //stringList.Add("Hello");
            //stringList.Add("What");
            //stringList.Add("is");
            //stringList.Add("your");
            //stringList.Add("name?");

            //stringList.Remove("is");

            //Console.WriteLine(stringList[1]);
            //Console.ReadLine();
        }
    }
}
