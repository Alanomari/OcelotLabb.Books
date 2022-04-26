using System;

namespace OcelotLabb.Books
{
    public class Book
    {
        public Guid Id { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public DateTime DatePublished { get; set; }
        public int Price { get; set; }
    }
}
