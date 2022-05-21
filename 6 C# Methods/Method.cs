using System;
namespace MyApplication
{
  class Program
  {
    static void MyMethod(string fname) 
    {
      Console.WriteLine(fname + " Chavan");
    }

    static void Main(string[] args)
    {
      MyMethod("Mandar");
      MyMethod("Mahesh");
      MyMethod("Manoj");

      Console.WriteLine();

      Program P=new Program();
      P.EvenNumbers();
    }
    public void EvenNumbers()
    {
        int start =0;
        while(start<=10)
        {
            Console.WriteLine(start);
            start=start+2;
        }
    }  
  }
}