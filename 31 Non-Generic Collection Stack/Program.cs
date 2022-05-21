using System;
using System.Collections;
namespace NGStack
{
    class Program
    {
        public static void Main(string []args)
        {
            Stack MyStack = new Stack();
            MyStack.Push("Mayur");
            MyStack.Push(21);
            MyStack.Push("7 August");
            MyStack.Push("Male");
            MyStack.Push("Student");
            foreach(object obj in MyStack)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine(MyStack.Count);

            Console.WriteLine();
            Console.WriteLine(MyStack.Peek());

            Console.WriteLine();
            MyStack.Pop();
             foreach(object obj in MyStack)
            {
                Console.WriteLine(obj);
            }

             Console.WriteLine();
             Console.WriteLine(MyStack.Contains("Male"));
             Console.WriteLine(MyStack.Contains("Female"));




            
        }
    }
}