using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    class TechnicalEmployee : Employee
    {
        public int successfulCheckin = 5;
        public TechnicalEmployee(string name) : base(name,750000)
        {

        }

        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckin + " succesfulCheckins";
        }
    }
}
