using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    class Employee
    {
        private string employeeName;
        private double employeebasesalary;
        private int employeeID;
        private static int employeeCount = 1;
        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
        public double Salary
        {
            get
            {
                return employeebasesalary;
            }
            set
            {
                employeebasesalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }

        public Employee(string Name,double salary)
        {
            this.employeeName = Name;
            this.employeebasesalary = salary;
            this.employeeID = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.employeebasesalary;
        }

        public string getName()
        {
            return this.employeeName;

        }

        public int getEmployeeID()
        {
            return this.employeeID;
        }

        public string toString()
        {
            return this.employeeID + "  " + this.employeeName;
        }

        public virtual string  employeeStatus()
        {
            return toString() + " is in the company system";
        }
    }
}
