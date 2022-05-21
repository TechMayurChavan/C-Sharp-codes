using System;
namespace MyProgram
{
    abstract class Students
    {
        public abstract void Name();
        public abstract void RollNumber();
        public void TotalStudents(int x)
        {
            Console.WriteLine($"Total number of students are {x}");
        }
    }
    class Student1 : Students {
        public override void Name()
        {
            Console.WriteLine("Student name is Mayur");
        }
         public override void RollNumber()
         {
             Console.WriteLine("Mayur roll number is 101");
         }

    }
    class Student2 : Students 
    {
        public override void Name()
        {
            Console.WriteLine("Student name is Manoj");
        }
         public override void RollNumber()
         {
             Console.WriteLine("Mayur roll number is 102");
         }
    }
    class MyProgram
    {
        static void Main(string [] args)
        {
        Student1 A=new Student1();
        Student2 B=new Student2();
        A.TotalStudents(100);
        A.Name();
        A.RollNumber();
        B.Name();
        B.RollNumber();

        }       

    }

}
