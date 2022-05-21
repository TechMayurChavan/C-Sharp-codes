using System;
namespace MyProgram
{
    class Program
    {
        static void MainWindow(string [] args)
        {
             try
        {
        int [] age ={21,22,23,24,25};
        Console.WriteLine(age[10]);
        }
        catch(Exception e)
        {
            Console.WriteLine("Something is Wrong");
        }
        finally
        {
            Console.WriteLine("The try catch is finished");
        }
        }      
       
    }
}