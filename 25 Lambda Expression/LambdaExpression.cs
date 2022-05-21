using System;
namespace MyProgram
{
    public delegate void MyDelegate(int a);
    public delegate int MyDelegate1(int a,int b);
    public delegate int MyDelegate2(int a);

    class MyProgram
    {
        static void Main(string [] args)
        {
            //Statement Lambda :
            MyDelegate obj = (a) =>
            {
                a += 10;
                Console.WriteLine(a);
            };
            obj.Invoke(20);
            MyDelegate1 obj1 = (int a,int b) =>
            {
               int Mul = a*b;
               return Mul;
            };
            Console.WriteLine( obj1(10,50));

            // Expression Lambda :
            MyDelegate2 obj2 =(a) => a*a;
            Console.WriteLine(obj2(10));          
            
        }

    }
}