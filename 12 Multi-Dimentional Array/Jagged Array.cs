using System;
namespace MyProgram
{
    class Array
    {
        static void MainWindow(string [] args)
        {
            int [][] RollNumbers =  new int[3][];
            RollNumbers [0]=new[]{1,2,3,4,5,6,7,8};
            RollNumbers [1]=new[]{9,10,11,12,14};
            RollNumbers [2]=new[]{13,14,15};

            Console.WriteLine(RollNumbers[0][1]);
             for(int i=0; i<RollNumbers.GetLength(0); i++)
        {
            for(int j=0; j<RollNumbers[i].Length; j++)
            {
                Console.Write(RollNumbers[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
         foreach(int[] items in RollNumbers)
        {
            foreach(int i in items)
            Console.WriteLine(i);
        }

        }
    }
}
