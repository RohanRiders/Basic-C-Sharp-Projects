using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethodAssignment
{
    class MathOperations
    {
        public int MultiplyMe(int num1 , int num2 = 5)
        {
            int product = num1 * num2;
            return product;

        }


    }
}
