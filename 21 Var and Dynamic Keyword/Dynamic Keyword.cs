using System;
namespace Dynamic
{
    class Var1
    {
         public static dynamic Show(dynamic a) 
         {
             return a + 5;
         }
        static void Main(string []args)
    {
        dynamic d =Show(10);
        Console.WriteLine(d);
        
        dynamic v=10;
        Console.WriteLine($"The dynamic is now int type : {v}");
        v="Manoj";
        Console.WriteLine($"The dynamic is now string type : {v}"); 
        Console.WriteLine($"Lowercase : {v.ToLower()}, Uppercase : {v.ToUpper()}, Length of the string : {v.Length}");
       

    }
    }
}
