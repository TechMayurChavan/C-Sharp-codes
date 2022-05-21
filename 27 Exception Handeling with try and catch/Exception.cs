using System;
namespace MyProgram
{
    class Number
    {
        static void Main(string [] args)
        {
        try
        {
             Console.WriteLine("Enter Numerator");
             int A=Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter Denominator");
             int B=Convert.ToInt32(Console.ReadLine());

             Console.WriteLine(A / B);
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter Numbers Only");
        }
        catch(OverflowException)
        {
            Console.WriteLine($"Ony numbers between {Int32.MinValue} {Int32.MaxValue} is allowed");
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("can/'t divided by zero");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    }
    
}