using Lab2.Models;
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var licz = new Licz();


            licz.DisplayValue();

            licz.Add(5);

            licz.DisplayValue();

            licz.Add(7);

            licz.Substract(2);

            licz.DisplayValue();
        }
    }
}
