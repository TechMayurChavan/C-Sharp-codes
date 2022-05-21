using System;
namespace MyApplication
{
    class Example1
    {
        public static void Check <T>(T a,T b)  // Generic Methode
        {
            bool check1 = a.Equals(b);
            Console.WriteLine(check1);
        }
        public static void Main(string []args)
        {
           Example1.Check(10,10);
           Example1.Check("Mayur","Mayur");
           Example1.Check('M','M');

        }
    }
}