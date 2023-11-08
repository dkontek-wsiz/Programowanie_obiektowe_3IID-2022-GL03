using Lab2.Models;
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad1();

            Zad2();
        }

        private static void Zad2()
        {
            var sumator = new Sumator(new int[] { 1, 5, 6, 2, 7 });

            Console.WriteLine(sumator.Suma());
            Console.WriteLine(sumator.SumaPodziel3());

          
            sumator.DisplayLiczby();
            Console.WriteLine("========");
            sumator.DisplayLiczby(-2, 2);
            Console.WriteLine("========");
            sumator.DisplayLiczby(-2, 16);
        }

        static void Zad1()
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
