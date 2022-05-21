using System;
namespace Myprogram{
    public delegate void Delegate1(int x,int y);

    class Math
    {
        public static void Sum1(int x,int y)
        {
            Console.WriteLine($"The sum of {x} and {y} is {x + y}");
        }
        static void MainWindow(string [] args)
        {
            Delegate1 D = new Delegate1(Sum1);
            D.Invoke(43,67);
            D(36,56);          // Second Way 
        }
    }
}