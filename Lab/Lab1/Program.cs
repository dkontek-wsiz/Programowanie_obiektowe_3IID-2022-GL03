using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            while (true)
            {
                Console.WriteLine("Wybierz funkcje:");
                Console.WriteLine("1. Liczba przysta");
                Console.WriteLine("2. N liczb parzystych");
                Console.WriteLine("4. Silnia");
                var input = Console.ReadLine();

                switch (int.Parse(input))
                {
                    case 1:
                        DisplayNumberIsEven();
                        break;
                    case 2:
                        DisplayNEvenNumber();
                        break;
                    case 4:
                        DisplaySilnia();
                        break;
                    case 5:
                        Game();
                        break;
                    case 0:
                        return;
                }

            }
        }

        private static void DisplayNEvenNumber()
        {
            Console.WriteLine("Podaj N");
            var input = Console.ReadLine();

            for(int i = 0; i <= int.Parse(input); i++)
            {
                if(IsEven(i))
                    Console.WriteLine(i);
            }
        }

     
        
        
        
        
        
        
        private static void Game()
        {
            var random = new Random();

            var number = random.Next(1, 101);

            int count = 0;
            int shoot;
            do
            {
                count++;
                Console.WriteLine("podaj liczbe");
                var input = Console.ReadLine();

                shoot = int.Parse(input);

                if (shoot > number)
                    Console.WriteLine("Za duża");
                else if(shoot < number)
                    Console.WriteLine("Za mała");

            }
            while (shoot != number);

            Console.WriteLine($"Zgadłeś za {count}");
        }

        private static void DisplaySilnia()
        {
            throw new NotImplementedException();
        }

        static void DisplayNumberIsEven()
        {
            Console.WriteLine("Podaj liczbę:");
            var input = Console.ReadLine();
            var number = int.Parse(input);
            /*if (number % 2 == 0)
                Console.WriteLine("Liczba parzysta");
            else
                Console.WriteLine("Nieparzysta");*/

            Console.WriteLine(IsEven(number) ? "Liczba parzysta" : "Nieparzysta");
        }


        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
