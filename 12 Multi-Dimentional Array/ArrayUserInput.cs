using System;
namespace MyProgram
{
    class User
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter size of the Array wather you want");
            int num = int.Parse(Console.ReadLine());
            int [] Numbers = new int[num];

            Console.WriteLine("Enter Data");
            for(int i=0; i<num; i++)
            {
                int data = int.Parse(Console.ReadLine());
                Numbers[i]=data;
            }
            Console.WriteLine("The Array is :");
            foreach(int items in Numbers)
            {
                Console.WriteLine(items);

            }
            
        }
    }

}