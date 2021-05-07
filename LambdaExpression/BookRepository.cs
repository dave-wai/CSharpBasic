using System;
using System.Collections.Generic;

namespace LambdaExpression
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Title = "Book1", Price= 13 },
                new Book { Title = "Book2", Price= 17 },
                new Book { Title = "Book3", Price= 25 },
            };
        }
    }
}
