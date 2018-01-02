﻿using System.Collections.Generic;

namespace Lambda_Expressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "ADO.Net step by step", Price = 5 },
                new Book() { Title = "ASP.NET MVC", Price = 9.99f },
                new Book() { Title = "ASP.NET Web API", Price = 12 },
                new Book() { Title = "C# advanced Topics", Price = 7 },
                new Book() { Title = "C# Advanced Topics", Price = 9 }
            };
        }
    }
}