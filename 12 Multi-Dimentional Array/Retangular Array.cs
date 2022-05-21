using System;
namespace MyProgram
{
    class Program
    {
        static void MainWindow(string [] args)
    {
        int [,] FlatNumbers = new int[3,4]
        {
            {101,102,103,104},
            {201,202,203,204},
            {301,302,303,304}
        };
        Console.WriteLine($"Access an Array element {FlatNumbers[0,1]}");   // Access an Array element
        Console.WriteLine($"Number of element in rows : {FlatNumbers.GetLength(0)}");
        Console.WriteLine($"Number of element in column : {FlatNumbers.GetLength(1)}");
        Console.WriteLine();
        Console.WriteLine("Acccessing the Array using nested for loop");
        for(int i=0; i<FlatNumbers.GetLength(0); i++)
        {
            for(int j=0; j<FlatNumbers.GetLength(1); j++)
            {
                Console.Write(FlatNumbers[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Acccessing the Array using foreach loop");
        foreach(int i in FlatNumbers)
        {
            Console.WriteLine(i);
        }
            
        }

    }
}