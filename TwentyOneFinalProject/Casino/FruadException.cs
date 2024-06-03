using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FruadException : Exception
    {
        public FruadException() //This is an overloaded method that inherits from the base Exception class
            : base() { }
        public FruadException(string message) //This is using the message parameter from the Exception base class. 
            : base(message) { }
        
    }
}
