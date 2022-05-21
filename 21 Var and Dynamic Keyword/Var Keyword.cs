using System;
namespace MyProgram
{
    class Var1
    {
        // public static var Show(var a)  ->We can not declare var as a return type and as a parameter in methode.
        // {
        // }
        static void MainWindow(string []args)
    {
        //By using var keyword we can stoar any data type in it.
        var v=10;
        // v="Manoj"; -> We can't do like this.
        Console.WriteLine($"The var is now int type : {v}");
        var v1="Mayur";
        Console.WriteLine($"The var is now string type : {v1}"); 
        Console.WriteLine(v1.ToUpper());
        Console.WriteLine($"Lowercase : {v1.ToLower()}, Uppercase : {v1.ToUpper()}, Length of the string : {v1.Length}");
       

    }
    }
}
