using System;
namespace MyProgram
{
    class Program
    {
        string _firstName;
        string _lastName;

       // Constructor Without Parameter
        public Program() :this("No firstname provided", "No lastName provided")
        {

        }

        //Constructor With Parameters
       public Program(string firstName , string lastName) 
       {
           this._firstName=firstName ;
           this._lastName=lastName;
           Console.WriteLine($"Full Name : {_firstName} {_lastName}");

       }
    }
    class MyClass
    {
       static void Main(string [] args)
       {
           Program p=new Program("Mayur","Chavan");
           Program p1=new Program();
       }
        
    }
       
    }
