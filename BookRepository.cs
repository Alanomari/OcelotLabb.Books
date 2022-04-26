using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OcelotLabb.Books
{
    public class BookRepository : IBookRepository
    {

        private readonly List<Book> _books;
        public static BookRepository Instance;

        public BookRepository()
        {

            if (Instance == null)
            {
                Instance = this;
                _books = new List<Book>();

                _books.Add(new Book
                {
                    Id = Guid.NewGuid(),
                    AuthorName = "Astrid Lindgren",
                    BookName = "Emil i Lönneberga",
                    DatePublished = DateTime.Now,
                    Price = 199
                });

                _books.Add(new Book
                {
                    Id = Guid.NewGuid(),
                    AuthorName = "Astrid Lindgren",
                    BookName = "Karlsson på taket",
                    DatePublished = DateTime.Now,
                    Price = 149
                });
            }
        }

        public Task<Book> AddBook(Book book)
        {

            Instance._books.Add(new Book
            {
                Id = book.Id,
                BookName = book.BookName,
                AuthorName = book.AuthorName,
                DatePublished = DateTime.Now,
                Price = book.Price
            });
            return Task.FromResult(book);
        }

        public Task<List<Book>> GetAllBooks()
        {
            return Task.FromResult(Instance._books);
        }


    }
}
