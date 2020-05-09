using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    
    class BusinessEmployee : Employee
    {

        public double bonusBudget = 1000;
        public BusinessEmployee(string name) : base(name,50000)
        {

        }
        public override string employeeStatus()
        {
            return toString() + " with a budget of " + bonusBudget;

        }
          
    }
}
