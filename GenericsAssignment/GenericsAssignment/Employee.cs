using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    public class Employee<T>
    {
        List<T> things;
        public static void displayElements<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }

    }
    
}
