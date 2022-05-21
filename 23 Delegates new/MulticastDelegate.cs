using System;
namespace Myprogram
{
    public delegate void Calculation(int a,int b);
    //delegate is used as Function Pointer. We can creat object of delegate and pass the reference of methode
    // to call our methode or methodes ,So we can achieve the encapsulation of methode by using delegate.

    class Delegate
    {
        public static void Sum(int a,int b)
        {
            Console.WriteLine($" The Sum of two numbers : {a + b}");
        }
        public static void Substraction(int a,int b)
        {
            Console.WriteLine ($" The Substraction of two numbers : {a - b}");
        }
        public static void Multiplication(int a,int b)
        {
            Console.WriteLine($" The Multiplication of two numbers : {a * b}");
        }
        public static void Division(int a,int b)
        {
            Console.WriteLine($" The Division of two numbers : {a / b}");
        }
         static void Main(string []args)
    {
        Calculation Obj =new Calculation(Delegate.Sum);
        Obj.Invoke(10,20);
        Obj = Substraction;
        Obj(50,23);
        Obj = Multiplication;
        Obj(23,34);
        Obj = Division;
        Obj(20,2);
        Console.WriteLine(" ");

        Obj += Substraction;
        Obj += Multiplication;
        Obj(20,10);
    }

    }
    
}
