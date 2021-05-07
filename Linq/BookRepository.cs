using System;
using System.Collections.Generic;

namespace Linq
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book> {
                new Book() { Title = "Abc", Price = 10 },
                new Book() { Title = "Gyc", Price = 18 },
                new Book() { Title = "Bab", Price = 15 },
                new Book() { Title = "AcD", Price = 25 },
            };
        }
    }
}
