using System;
using System.Linq;

namespace Linq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();


            // LINQ query operatiors
            var cheaperBook = from b in books
                              where b.Price < 20
                              orderby b.Title
                              select b.Title;

            // LINQ Extension Methods
            var cheapBook = books.Where(b => b.Price < 20)
                                    .OrderBy(b => b.Title)
                                        .Select(b => b.Title);

            foreach (var book in cheapBook)
            {
                //Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(book);
            }


            // Other LINQ extension Methods
            // Must have one to satify, if not exception throw - use singleOrDefault to return null if not found
            var a = books.Single(b => b.Title == "ASP.NET MVC");

            var b = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");

            // Return the first book match the condition
            var c = books.FirstOrDefault(b => b.Title == "C# Advanced Topic");
            var d = books.LastOrDefault(b => b.Title == "C# Advanced Topic");

            // For paging data - Skip the first 2 objects and take the next 3 objects
            var e = books.Skip(2).Take(3);

            var f = books.Count();

            var g = books.Max(b => b.Price);

            var h = books.Min(b => b.Price);

            var i = books.Sum(b => b.Price);

            var j = books.Average(b => b.Price);


        }
    }
}
