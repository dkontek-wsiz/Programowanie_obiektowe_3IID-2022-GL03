using System;
using System.Collections.Generic;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    public class MockPersonRepository : IPersonRepository
    {
        private List<Person> data = new List<Person>();

        public void Create(Person input)
        {
            input.Id = data.Count + 1;
            data.Add(input);
        }

        public void Delete(long id)
        {
            data.RemoveAll(x => x.Id == id);
        }

        public Person Get(long id)
        {
            return data.Find(x => x.Id == id);
        }

        public List<Person> GetAll()
        {
            return data;
        }

        public void Update(Person input)
        {
            var index = data.FindIndex(x => x.Id == input.Id);
            if (index > -1)
                data[index] = input;
        }

        public void BorrowBook(long id, Book book)
        {
            var person = Get(id);
            if (person == null)
                return;

            person.BorrowedBooks.Add(book);
        }

        public List<Book> GetBorrowedBook(long id)
        {
            return Get(id)?.BorrowedBooks ?? new List<Book>();
        }
    }
}
