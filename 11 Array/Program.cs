using System;
using System.Linq;
namespace MyProgram
{
    class MyProgram{
        static void Main(string [] args)
        {
            string [] cars={"Toyota","volvo","Indiga","Alto","indogo","Creata"};
            Console.WriteLine("Accessing Array Element....!");
            Console.WriteLine(cars[2]); // Access Array Element
            Console.WriteLine(" ");
            Console.WriteLine("Print All Element from Array");
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Array Element Changed");
            cars[0]="Ford";    //Changing Array element
            Console.WriteLine(cars[0]);

            Console.WriteLine("");
            Console.WriteLine("Length of the Array is :");
            Console.WriteLine(cars.Length);   // We can print Array Length

            Console.WriteLine("");
            Console.WriteLine("Sorting the array by Alphabatically  :");
            Array.Sort(cars);     // Sorting the array by Alphabatically 
             foreach(string i in cars)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");

             int [] age = {2,3,4,2,1,4,5,6,1};  //array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:
             Console.WriteLine(age.Max());
             Console.WriteLine(age.Min());
             Console.WriteLine(age.Sum());

        }
    }
    
}