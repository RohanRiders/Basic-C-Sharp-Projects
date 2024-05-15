using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathOperations
    {
        public int AddNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int AddNumbers(float num1, float num2)
        {
            int sum = Convert.ToInt32(num1 + num2);
            return sum;
        }

        public int AddNumbers(string num1, string num2)
        {
           int sum = Int32.Parse(num1 + num2);
            return sum;
        }
    }
}
