using System;
namespace MyProgram
{
    class Program 
    {
        static void Main(string []args)
        {
        //  PRINT 20 TO 30 NUMBERS USING WHILE LOOP
        int i=10;
        while(i<=30) 
        {
            Console.Write(i + " ");
            i++;
        }
         Console.WriteLine();

        //  PRINT 20 TO 30 NUMBERS USING DO-WHILE LOOP
        int a =20;
        do
        {
            Console.Write(a + " ");
            a--;
        }
        while(a>0);    
    }
}
}