using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Shapes
{
    public class Square : Shape
    {
        public double X { get; set; }

        public Square(double x)
        {
            X = x;
        }

        public override double CalulateArea()
        {
            return X * X;
        }
    }
}
