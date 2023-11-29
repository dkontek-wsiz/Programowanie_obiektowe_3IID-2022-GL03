using Lab5.Bank;
using Lab5.Shapes;
using Library.Repositories;
using System;
using Library.Models;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad1();
            Zad2();

            IBookRepository bookRepository = new MockBookRepository();

            bookRepository.Create(new Book() {Id = 1, Title = "Test" });
            bookRepository.Create(new Book() { Id = 2, Title = "Test2" });
            bookRepository.Create(new Book() { Id = 3, Title = "Test3" });

            foreach(var item in bookRepository.GetAll())
            {
                Console.WriteLine(item.Title);
            }

            var book = bookRepository.Get(1);

            book.Title = "Test4";
            bookRepository.Update(book);
            Console.WriteLine(bookRepository.Get(1).Title);
            bookRepository.Delete(2);

            Console.WriteLine(bookRepository.GetAll().Count);
           
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
