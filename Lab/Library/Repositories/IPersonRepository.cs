using Library.Models;
using System.Collections.Generic;

namespace Library.Repositories
{
    public interface IPersonRepository : IBaseRepository<Person, long>
    {
        List<Book> GetBorrowedBook(long id);
        void BorrowBook(long id, Book book);
    }
}
