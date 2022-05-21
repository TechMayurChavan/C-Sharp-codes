using System;
namespace MyProgram
{
 class Voter
 {
   static void CheckAge()
   {
       Console.WriteLine("Enter your age");
       int age = Convert.ToInt32(Console.ReadLine());
       if(age<18)
       {
           throw new ArithmeticException ("Access denied - You must be at least 18 years old.");
       }
       else
       {
           Console.WriteLine("Access granted - You are old enough!");
       }
   }
   static void Main(string[] args)
   {
       CheckAge();
   }
 }
}