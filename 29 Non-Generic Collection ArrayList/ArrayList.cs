using System;
using System.Collections;
namespace MyArrayList
{
    class Program
    {
        public static void Main(string []args)
        {
           ArrayList RollNumbers = new ArrayList();
           RollNumbers.Add(20);
           RollNumbers.Add(21);
           RollNumbers.Add(22);
           RollNumbers.Add(23);
           RollNumbers.Add(24);
           RollNumbers.Add(25);

          foreach(object obj in RollNumbers)
          {
              Console.Write(obj + " "); 
          }
          Console.WriteLine();

          Console.WriteLine("Add Element in ArrayList");
          RollNumbers.Insert(6,26);
          foreach(object obj in RollNumbers)
          {
              Console.Write(obj + " "); 
          }
          System.Console.WriteLine();

           Console.WriteLine("Remove Element from ArrayList");
           RollNumbers.Remove(21);  //We can directly remove the element by putting elemnet in remove methode
           RollNumbers.RemoveAt(3); //We can remove the element by putting elemnet index number in remove methode
            foreach(object obj in RollNumbers)
          {
              Console.Write(obj + " "); 
          }







    




        }
    }
    
}