using System;
namespace MyApplication
{
        interface IBank
    {
        void customerId(int x);
        void customerName(string name);
        
    }  
    class Customer1 : IBank
    {
        public void customerId(int x)
        {
            Console.WriteLine($"The customer Id is :{x}");
        }
        public void customerName(String name)
        {
            Console.WriteLine($"The customer Name is :{name}");
        }
        
    }
    class MyProgram
    {
        static void Main(string [] args)
        {
            Customer1 C = new Customer1();
            C.customerId(123);
            C.customerName("Mayur");
        }
    }
}