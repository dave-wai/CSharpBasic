using System;

namespace LambdaExpression
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // var cheapBooks = books.FindAll(GetCheapBook);

            // Good to use with List and Linq

            // Lambda
            // args "goes to" expression
            // args => expression


            var cheapBooks = books.FindAll(b => b.Price > 20);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        //static bool GetCheapBook(Book book)
        //{
        //    return book.Price < 20;
        //}

    }
}
