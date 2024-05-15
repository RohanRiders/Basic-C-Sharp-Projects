using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class MathOperations
    {
        public int AddTwoNumbers(int num)
        {
           int myNumber = num + 2;
            return myNumber;
        }

        public int MultiplyTwoNumbers(int num)
        {
            int mySolution = num * 2;
            return mySolution;
        }

        public int DivideTwoNumbers(int num)
        {
            int myQuotient = num / 2;
            return myQuotient;
        }
    }
}
