using System;
namespace MyProgram 
{
    class Program
    {
static void Main(string [] args)
{
    Console.WriteLine("Enter Your Target");
    int Target = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The Even Numbers upto Target....");
    for(int i=0; i<=Target; i++)
    {
        if(i%2==1)
        {
            
             Console.WriteLine(i);
        }
       
    }
}
    }
}
