using System;
using System.Linq;

namespace Lab2.Models
{
    public class Sumator
    {
        private int[] liczby;

        public Sumator(int[] value)
        {
            liczby = value;
        }


        public int Suma()
        {
            var result = 0;

            for(var i = 0; i < liczby.Length; i++)
            {
                result += liczby[i];
            }
           
            return result;
        }

        public int SumaPodziel3()
        {
            var result = 0;

            for (var i = 0; i < liczby.Length; i++)
            {
                var liczba = liczby[i];
                if(liczba % 3 == 0)
                    result += liczba;
            }

            return result;
        }

        public int IleElementów()
        {
            return liczby.Length;
        }

        public void DisplayLiczby()
        {
            for (var i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine(liczby[i]);
            }
        }

        public void DisplayLiczby(int lowIndex, int highIndex)
        {
            lowIndex = lowIndex < 0 ? 0 : lowIndex;
            highIndex = highIndex > liczby.Length ? liczby.Length : highIndex;

            for (var i = lowIndex; i < highIndex; i++)
            {
                Console.WriteLine(liczby[i]);
            }
        }
    }
}
