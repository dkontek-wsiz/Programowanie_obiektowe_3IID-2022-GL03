using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab7.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        [HttpGet]
        public List<Book> GetBooksByAuthor(string author)
        {
            return _bookRepository.GetBooksByAuthor(author);
        }

        [HttpGet]
        public List<Book> GetBooksByPublishYear(int year)
        {
            return _bookRepository.GetBooksByPublishYear(year);
        }

        [HttpGet]
        public Book Get(int id)
        {
            return _bookRepository.Get(id);
        }

        [HttpPost]
        public void Create(Book book)
        {
            _bookRepository.Create(book);
        }

        [HttpPut]
        public void Update(Book book)
        {
            _bookRepository.Update(book);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }
    }
}