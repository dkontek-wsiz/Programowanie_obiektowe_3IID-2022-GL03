using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    public class MockBookRepository : IBookRepository
    {
        private List<Book> data = new List<Book>();

        public void Create(Book input)
        {
            data.Add(input);
        }

        public Book Get(int id)
        {
            return data.Find(x => x.Id == id);
        }

        public List<Book> GetAll()
        {
            return data;
        }

        public void Delete(int id)
        {
            data.RemoveAll(x => x.Id == id);
        }

        public void Update(Book input)
        {
            var index = data.FindIndex(x => x.Id == input.Id);
            if(index > -1)
                data[index] = input;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return data.Where(x => x.Author == author).ToList();
        }

        public List<Book> GetBooksByPublishYear(int year)
        {
            return data.Where(x => x.PublishYear == year).ToList();
        }
    }
}
