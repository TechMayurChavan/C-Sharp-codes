using System;
namespace MyProgram
{
    public delegate void MyDelegate(int a);
    public delegate int MyDelegate1(int a,int b);

    class MyProgram
    {
        static void Main(string [] args)
        {
            MyDelegate obj = delegate(int a)
            {
                a += 10;
                Console.WriteLine(a);
            };
            obj.Invoke(20);
            MyDelegate1 obj1 = delegate(int a,int b)
            {
                int Mul = a*b;
                return Mul;
            };
            Console.WriteLine(obj1(10,50));
       
            
        }

    }
}