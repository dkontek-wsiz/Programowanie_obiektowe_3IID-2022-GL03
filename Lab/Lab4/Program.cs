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
            bookRepository.Create(new Book() { Id = 3, Title = "Test3", Author="Me", PublishYear = 2000 });

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
            Console.WriteLine(bookRepository.GetBooksByPublishYear(2000).Count);
            Console.WriteLine(bookRepository.GetBooksByAuthor("Me").Count);

            IPersonRepository personRepository = new MockPersonRepository();

            personRepository.Create(new Person() {Id = 1, FirstName = "Test" });
            personRepository.Create(new Person() { Id = 2, FirstName = "Test2" });
            personRepository.Create(new Person() { Id = 3, FirstName = "Test3" });

            foreach(var item in personRepository.GetAll())
            {
                Console.WriteLine(item.FirstName);
            }

            var person = personRepository.Get(1);

            person.FirstName = "Test4";
            personRepository.Update(person);
            Console.WriteLine(personRepository.Get(1).FirstName);
            personRepository.Delete(2);

            Console.WriteLine(personRepository.GetAll().Count);

            personRepository.BorrowBook(person.Id, book);
            foreach (var item in personRepository.GetBorrowedBook(person.Id))
            {
                Console.WriteLine(item.Title);
            }
           
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
