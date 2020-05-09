using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    abstract public class Person
    {
        private string name;
        private string addr;
        private string dob;
       

        public string Name
        {
            get
            { 
                return name; 
            }
            set
            {
                name = value;
            }

        }
        public string Addr
        {
            get
            {
                return addr;
            }
            set
            {
                addr = value;
            }

        }
        public string DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }

        }



        public abstract void perform_func();

        public void display()
        {
            Console.WriteLine($"Name of the Person :{Name}");
            Console.WriteLine($"Address of the Person :{addr}");
            Console.WriteLine($"Date of Birth: {dob}");
        }

    }
}
