using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Title", "Author");
            Book book2 = new Book("Title2", "Author2");
            LibraryManager lib = new LibraryManager("Name");
            Console.WriteLine($"welcome to the {lib.Name} Library Management System");
            lib.AddBook(book1);
            lib.AddBook(book2);
            Console.WriteLine(lib);


        }
    }
}
