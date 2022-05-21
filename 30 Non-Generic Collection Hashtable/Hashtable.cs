using System;
using System.Collections;
namespace HashTable
{
    class Emplyee
    {
        static void Main(string []args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("ID", 1);
            ht.Add("Name", "Manoj");
            ht.Add("Gender", "Male");
            ht.Add("Age", 21);
            ht.Add("DOJ", "3 January");

            //Accessing the element from Hastable
            Console.WriteLine(ht["ID"]);
            Console.WriteLine(ht["Name"]);
            Console.WriteLine();

            //Print all element

            foreach(object key in ht.Keys)     
            {
                Console.WriteLine( key+ ": "+ ht[key]);

            }

              Console.WriteLine();
            //Remove element from hashtable
            ht.Remove("Name");
            foreach(object key in ht.Keys)     
            {
                Console.WriteLine( key+ ": "+ ht[key]);

            }

            Console.WriteLine();
            //clear elements from hashtable
            ht.Clear();
            foreach(object key in ht.Keys)     
            {
                Console.WriteLine( key+ ": "+ ht[key]);

            }
        
            Console.WriteLine();

            // Another Way to add element in Hashtable 

             Hashtable ht1 = new Hashtable()
             {
                 {"ID",2},
                 {"Name","Suyash"},
                 {"Gender","Male"},
                 {"Age",23},
                 {"DOJ","17 January"}
             };
            Console.WriteLine(ht1["Age"]);
            Console.WriteLine(ht1["DOJ"]);
             // Use of Contains Methode
             Console.WriteLine(ht1.Contains("Gender"));
             Console.WriteLine(ht1.ContainsKey("Gender"));  //We can use this methode like this also
             Console.WriteLine(ht1.ContainsValue("Male"));
             Console.WriteLine();

              foreach(object key in ht1.Keys)     
            {
                Console.WriteLine(key);   //we can print Keys only from Hastable

            }
              Console.WriteLine();

             foreach(object value in ht1.Values)     
            {
                Console.WriteLine(value);   //We can print Values only from Hastable

            }
              Console.WriteLine();

            Console.WriteLine("Suyash".GetHashCode());
            Console.WriteLine();
            Console.WriteLine(ht1.Count);

        }
    }

}