using System;
namespace Myprogram
{    class Animal
    {
        public string legs="All animals have 4 legs";
        public void Sleep()
        {
            Console.WriteLine("All animals slpee like : Z z z z z z");
        }
    }
    class Dog : Animal 
    {
        public string eat = "Dog Eat Chicken";
        public void DogVoice()
        {
            Console.WriteLine("Dog Voice is : BHO BHO BHO BHO BHO");
        }    
    }

    class Goat : Animal
    {
        public string eat="Goat eat grass ";
        public string goatVoice="goat voice is : maaa, maa, maa";
    }
    class Program 
    {
         static void Main(string [] args)
    {
        Dog D=new Dog();
        D.Sleep();
        Console.WriteLine(D.legs);
        Console.WriteLine(D.eat);
        D.DogVoice();

        Goat G=new Goat();
        Console.WriteLine(G.eat);
        Console.WriteLine(G.goatVoice);
    }
    }   
}
