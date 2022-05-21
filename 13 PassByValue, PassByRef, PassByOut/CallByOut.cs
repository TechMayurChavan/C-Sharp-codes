using System;
namespace MyProgram
{
    class Name2
    {
    public static void PassByOut( out int x)
    {
        x =20;
        Console.WriteLine(x);
    }
    static void Main(string [] args)
    {
       int value;
       PassByOut( out value);
       Console.WriteLine(value);

    }
}
}