using System;
namespace MyProgram
{
    class Circle
    {
        static float PI =0.14F;
        float _radius;

        public Circle(float radius)
        {
            this._radius=radius;
            Console.WriteLine("The Area Of the Circle is:");
            Console.WriteLine(Circle.PI * _radius * _radius );
        }
        static void MainWindow(string [] args)
        {
            Circle c=new Circle(4.45F);
            Circle c1=new Circle(5);
        }
    }
}