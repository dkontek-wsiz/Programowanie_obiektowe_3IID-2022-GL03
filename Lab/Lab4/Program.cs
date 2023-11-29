using Lab5.Shapes;
using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad1();
        }

        static void Zad1()
        {
            Shape shape = new Circle(5);

            Console.WriteLine(shape.CalulateArea());

            shape = new Square(3);
            Console.WriteLine(shape.CalulateArea());
        }
    }
}
