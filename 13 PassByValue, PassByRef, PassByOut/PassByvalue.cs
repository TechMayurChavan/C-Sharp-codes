using System;
namespace MyProgram
{
    class MyProgram
    {
    public static void PassByValue(int x)
    {
        x += x;
        Console.WriteLine(x);
    }
    static void MainWindow(string [] args)
    {
        int value =20;
       PassByValue(value);
       Console.WriteLine(value);

    }
}
}