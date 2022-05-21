using System;
namespace MyProgram
{
    class Animal
    {
        public virtual void  Sound()
        {
            Console.WriteLine("All Animals makes a sound");
        }
    }
    class Pig : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Pig says : Wee Wee Wee Wee Wee");
        }
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog says : BHO BHO BHO BHO BHO");
        }

    }
    class Program 
    {
        static void Main(string [] args)
        {
            Animal A=new Animal();
            Pig P=new Pig();
            Dog D=new Dog();

            A.Sound();
            P.Sound();
            D.Sound();


        }
    }
}