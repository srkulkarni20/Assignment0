using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
   public class teacher:Person
    {
        

        public teacher(string name,string addr,string dob)
        {
            this.Name = name;
            this.Addr = addr;
            this.DOB = dob;
        }

        public override void perform_func()
        {
            Console.WriteLine($"\n{this.Name} is a teacher");
            
        }
        public void Grade_stud()
        {
            Console.WriteLine("Specific to teacher class");
        }
    }
}
