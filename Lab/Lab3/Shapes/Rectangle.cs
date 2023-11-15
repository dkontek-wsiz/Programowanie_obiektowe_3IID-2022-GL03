using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int x) : base(x)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
