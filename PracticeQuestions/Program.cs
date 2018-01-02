using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {


            //IEnumerable<int> result = from value in Enumerable
            //                          .Range(0,2)
            //                          select value;

            //var books = new BookRepository().GetBooks();

            ////var book = books.SingleorDefault(b => b.Title == "ASP.NET MVC");
            ////var book = books.SingleOrDefault(b => b.Title == "ASP.NET");

            //var aveBookPrice = books.Average(b => b.Price);
            //var lessThanAve = books
            //                    .Where(b => b.Price < aveBookPrice)
            //                    .OrderBy(b => b.Title)
            //                    .Select(b => b.Title);

            //foreach(var b in lessThanAve)                    
            //    Console.WriteLine(b);

            //Console.WriteLine(lessThanAve);

            //Console.WriteLine(book.Price);
            ////LINQ QUERY Operator
            //var cheaperBooks = from b in books
            //                   where b.Price < 10
            //                   orderby b.Price
            //                   select b.Title;

            ////LINQ extension methods
            //var cheapBooks = books
            //    .Where(b => b.Price < 10)
            //    .OrderBy(b => b.Price)
            //    .Select(b => b.Title);
            //foreach (var book in cheapBooks)
            //    Console.WriteLine(book);

        }

    }
}
