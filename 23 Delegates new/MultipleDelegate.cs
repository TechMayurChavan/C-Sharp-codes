using System;
namespace Myprogram
{
    public delegate void Delegate3(int a,int b);
     public delegate void Delegate4(int a,int b);

    class Delegate2
    {
         public static void Sum(int a,int b)
        {
            Console.WriteLine($" The Sum of two numbers : {a + b}");
        }
        public static void Substraction(int a,int b)
        {
            Console.WriteLine ($" The Substraction of two numbers : {a - b}");
        }
        static void Main(string [] args)
        {
            Delegate3 D1 = new Delegate3(Sum);
            D1.Invoke(67,54);
            Delegate4 D2 = new Delegate4(Substraction);
            D2.Invoke(34,21);
        }
    }
}