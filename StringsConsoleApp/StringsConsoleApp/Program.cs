using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsConsoleApp
{
    class Program
    {
        static void Main()
        {
            string sentence1 = "Hello, what is your name?";
            Console.WriteLine(sentence1);
            string name = Console.ReadLine();
            string botName = "Bot";
            string boldName = botName.ToUpper();
            string sentence2 = "Nice to me you, " + name + "!" + " My name is " + boldName;
            Console.WriteLine(sentence2);

            StringBuilder myStringBuilder = new StringBuilder();

            myStringBuilder.Append("I like bread and butter, I like toast and jam!");

            Console.WriteLine(myStringBuilder);
            Console.ReadLine(); 
        }

    }
}
