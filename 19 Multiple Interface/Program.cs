using System;
namespace MyProgram
{
    interface IA 
    {
        void Amethode(); 
    }
    class M : IA
    {
        public void Amethode()
        {
            Console.WriteLine("This is Amethode");
        }
    }
    interface IB
    {
        void Bmethode();
    }
    class K : IB
    {
        public void Bmethode()
        {
            Console.WriteLine("This is Bmethode");
        }
    }
    class AB :IA , IB
    {
         M m =new M();
         K k =new K();
            public void Amethode()
        { 
            m.Amethode();  
        }
        public void Bmethode()
        {   
              k.Bmethode();
        }

    }
        class P 
        {
            static void Main(string [] args)
            {
                AB myObj= new AB();
                myObj.Amethode();  
                myObj.Bmethode();

            }
        }
        
    }
    
