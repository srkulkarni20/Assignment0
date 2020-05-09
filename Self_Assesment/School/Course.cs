using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
    
namespace School
{
   
    public class Degree
    {
       public string Deg_Name { get; set; }
       public int no_of_yrs { get; set; }
       public Course[] C1 = new Course[10];
       public int course_count = 0;
       
       public Degree(string name,int yrs)
        {
            this.Deg_Name = name;
            this.no_of_yrs = yrs;       
        }

        public void Add_Course(Course C)
        {
            this.C1[course_count] = C;
            course_count++;
        }

        public int Course_Count()
        {
            return course_count;
        }
        
    }


    public class Uprogram: IDisposable
    {
       
        public string prg_name;
        public Degree D1;
        private StringReader _reader;

        public Uprogram(string name,Degree D)
        {
            this.prg_name = name;
            this.D1 = D;
            this._reader = new StringReader("Hello");
           
        }


       public void display_details()
       {
            Console.WriteLine($"Program Name : {this.prg_name}");
            Console.WriteLine($"Degree Name:{this.D1.Deg_Name}\nNo of Yrs :{this.D1.no_of_yrs}\nNo of Courses :{this.D1.course_count}\n");
            for (int i = 0;i<this.D1.course_count;i++)
            {
                Console.WriteLine($"Students in : {this.D1.C1[i].Sub_Name}  Course\n");
                this.D1.C1[i].display_students();
                Console.WriteLine($"\nTeachers in : {this.D1.C1[i].Sub_Name}  Course\n");
                this.D1.C1[i].display_teachers();
            }
       }



        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    this.D1.C1 = null;
                    this.D1 = null;
                    Console.WriteLine("Free managed resource");
                }

                if (_reader != null)
                {
                    this._reader.Dispose();
                    Console.WriteLine("Free unmanaged Resources");
                }
                    // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                    // TODO: set large fields to null.

                    disposedValue = true;
            }
        }


        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
          ~Uprogram()
          {
            //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
               Console.WriteLine("Destructor Called");
               Dispose(false);
                
          }


        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion


    }




    public class Course
    {
        public string Sub_Name { get; set; }
        private int tot_stud;
        private int tot_tch;
        private Student[] st = new Student[100];
        private teacher[] tch = new teacher[10];

        public Course(string name)
        {
            this.Sub_Name = name;

        }

        public void Add_student(Student stud)
        {

            this.st[this.tot_stud++] = stud;

        }

        public void Add_teacher(teacher tchr)
        {
            this.tch[this.tot_tch++] = tchr;

        }

        public void display_students()
        {

            Console.WriteLine($"Total no of Students :{this.tot_stud}\n");
            Console.WriteLine("Student Name \t\t Student Id\n");
            for (int i = 0; i < this.tot_stud; i++)
            {
                Console.WriteLine($"\t{this.st[i].Name} \t\t\t {this.st[i].id}");
            }
        }

        public void display_teachers()
        {
            Console.WriteLine($"\nTotal no of Teachers :{this.tot_tch}\n");
            Console.WriteLine("Teachers Name");
            for (int i = 0; i < this.tot_tch; i++)
            {
                Console.WriteLine($"\t{this.tch[i].Name}");

            }
        }

    }
    
}
