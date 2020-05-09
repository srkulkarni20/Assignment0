using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Employee("shweta", 67000);
            var emp2 = new TechnicalEmployee("Saanvi");
            var emp3 = new BusinessEmployee("Shrihaan");
            emp1.Name = "Raghav";
            Console.WriteLine(emp1.employeeStatus());
            Console.WriteLine(emp2.employeeStatus());
            Console.WriteLine(emp3.employeeStatus());
        }
    }
}
