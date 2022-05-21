using System;
namespace Myprogram 
{
    class Math
    {
        public static void Sum(int a,int b)
        {
            Console.WriteLine("The sum of two numbers :");
            int c=a + b;
            Console.WriteLine(c);
        }
        public void Mul(float d, float e)
        {
            Console.WriteLine("The Multiplication of two numbers :");
            float g = d*e;
            Console.WriteLine(g);
        }
        static void Main ( string [] args)
        {
            Sum(23,45);
            Math M = new Math();
            M.Mul(23.3F,45.6F);
        }
    }
}