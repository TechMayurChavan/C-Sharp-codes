using System;
namespace MyProgram
{
    interface I1
    {
        void myMethode();
    }
    interface I2
    {
        void myMethode();
    }
    class Program : I1, I2
    {
        void I1.myMethode()
        {
            Console.WriteLine("This is I1 Mymethode");
        }
        void I2.myMethode()
        {
            Console.WriteLine("This is I2 MyMethode");
        }

    }
    class Program1
    {
        static void Main(string [] args)
        {
             Program P=new Program();
        ((I1)P).myMethode();
        ((I2)P).myMethode();

        }
    }
}