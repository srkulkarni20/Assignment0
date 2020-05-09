using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {

            var deg = new Degree("Bachelors", 4);
            var uprog = new Uprogram("Infomation Technology", deg);
            var course1 = new Course("C#");
            var course2 = new Course("C++");
            var stud1 = new Student("Shweta", 1, "Bellevue", "04-05-2000");
            var stud2 = new Student("Sarita", 2, "Bellevue", "14-06-2000");
            var stud3 = new Student("Saanvi", 3, "Bellevue", "14-06-2000");
            var stud4 = new Student("Sumit", 4, "Bellevue", "15-09-2000");
            var stud5 = new Student("Shri", 5, "Redmond", "14-06-2000");
            var stud6 = new Student("Sam", 6, "Bellevue", "14-06-2000");
            var tchr1 = new teacher("Suma","Redmond","14-06-1984");
            var tchr2 = new teacher("Saroj","Redmond","15-06-1985");
            course1.Add_student(stud1);
            course1.Add_student(stud2);
            course1.Add_student(stud3);
            course1.Add_teacher(tchr1);
            course2.Add_student(stud4);
            course2.Add_student(stud5);
            course2.Add_student(stud6);
            course2.Add_teacher(tchr2);
            deg.Add_Course(course1);
            deg.Add_Course(course2);
            
            uprog.display_details();

            //To Display Inheritance and abstract class .Functions implemented differently in sub classes
            stud1.perform_func();
            tchr1.perform_func();
            stud2.display();
            tchr2.display();
            stud1.Take_test();
            tchr1.Grade_stud();
            
            try
            {
               uprog.Dispose();
                
                // Code to use the ManagedWord object.
            }
            catch
            {
                Console.WriteLine("Object not Found");
                // Code to handle any errors.
            }
            finally
            {
                if (course1 != null)
                   uprog.Dispose();
            }

        }
    }
}
