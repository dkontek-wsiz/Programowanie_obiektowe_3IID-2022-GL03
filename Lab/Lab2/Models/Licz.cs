using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Models
{
    public class Licz
    {
        private int value;

        public Licz(int value)
        {
            this.value = value;
        }

        public Licz()
        {
            value = -1;
        }

        public void Add(int x)
        {
            value += x;
        }

        public void Substract(int x)
        {
            value -= x;
        }

       public void DisplayValue()
        {
            Console.WriteLine(value);
        }
    }
}
