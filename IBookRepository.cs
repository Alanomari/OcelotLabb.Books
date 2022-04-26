using System.Collections.Generic;
using System.Threading.Tasks;

namespace OcelotLabb.Books
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetAllBooks();

        public Task<Book> AddBook(Book book);
       
       
    }
}
