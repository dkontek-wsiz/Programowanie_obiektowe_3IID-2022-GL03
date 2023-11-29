using Library.Models;
using System.Collections.Generic;

namespace Library.Repositories
{
    public interface IBookRepository: IBaseRepository<Book, int>
    {
        List<Book> GetBooksByAuthor(string author);
        List<Book> GetBooksByPublishYear(int year);
    }
}
