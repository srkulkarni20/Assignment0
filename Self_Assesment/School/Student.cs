using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Student : Person
    {
        
        public int id { get; set; }

        public Student(string name, int num,string addr,string dob)
        {
            this.Name = name;
            this.id = num;
            this.Addr = addr;
            this.DOB = dob;
        }

        public override void perform_func()
        {
            Console.WriteLine($"\n{this.Name} is a student ");
        }

        public void Take_test()
        {
            Console.WriteLine("Specific to student class");
        }

       
    }
}
