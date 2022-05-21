using System;
namespace Myprogram
{
    class Example <T>   // Generic Class
    {
        T name;
        public T Name 
        {
            get{return name;}
            set{name=value;}
        }
    }
    class Program
    {
         public static void MainWindow(string []args)
        {
         Example <string> E=new Example<string>();
         E.Name ="Mayur"; 
         Console.WriteLine(E.Name);

        }
    }
}
