using Lab5.Bank;
using Lab5.Shapes;
using System;

namespace Lab5
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
            var account = new Account();

            account.ProcessTransaction(new IncomeTransaction() { Amount = 1500 });
            account.ProcessTransaction(new ExpenseTransaction() { Amount = 1000 });

            account.DisplaySummary();
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
