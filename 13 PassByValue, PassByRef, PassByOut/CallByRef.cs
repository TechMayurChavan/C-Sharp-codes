using System;
namespace MyProgram
{
    class Name
    {
    public static void PassByRef( ref int x)
    {
        x += x;
        Console.WriteLine(x);
    }
    static void MainWindow(string [] args)
    {
        int value =20;
       PassByRef( ref value);
       Console.WriteLine(value);

    }
}
}