using System;
namespace MyProgram
{
    class Program 
    {
        enum TimeTable
        {
            Monday,
            Wednesday,
            Sunday

        }
        public static void Main(string []args)
        {
            TimeTable D= TimeTable.Sunday;
            switch(D)
            {
                case TimeTable.Monday:
                Console.WriteLine("Today is Monday,So I should go to school");
                break;
                case TimeTable.Wednesday:
                Console.WriteLine("Today is Wednesday,I should go to play cricket :");
                break;
                case TimeTable.Sunday:
                Console.WriteLine("Today is Sunday,So its a holiday :");
                break;
                
            }
        }
    }
}