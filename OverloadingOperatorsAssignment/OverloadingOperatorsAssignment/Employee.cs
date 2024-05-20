using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsAssignment
{
    class Employee : Person
    {
        public int ID { get; set; }
        

        public static bool operator== (Employee employee, Employee employee1) //overloaded comparison method. ==
        {
            if (employee.ID == employee1.ID)
                return true;
            else
                return false;
        }

        public static bool operator!= (Employee employee, Employee employee1) //the overloaded method are in pairs so you need to opposit. !=
        {
            if (employee.ID != employee1.ID)
                return false;
            else
                return true;
        }
    }
}
