using System;
namespace Myprogram
{
    class Program
    {
        private string name="Mayur Chavan";
        private int age = 21;
        public string Name
        {
            get{return name;}
            set{name = value;}
        }
        public int Age
        {
            get{return age;}
            set{age = value;}
        }
    }
    class Program1
    {
        static void Main(string [] args)
        {
            Program P = new Program();
            Console.WriteLine($"My name is :{P.Name} and I am {P.Age} years old");


        }
    }
    
}