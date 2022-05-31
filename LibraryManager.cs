using System;
using System.Collections.Generic;


namespace Library
{
    public class LibraryManager
    {
        public string Name { get; set; }
        private List<Book> _books = new List<Book>();

        public LibraryManager(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            string str = "";
            foreach (Book book in _books)
            {
                str += $"{book.Title}, by {book.Author}\n";
            }
            return str;
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }
    }
}