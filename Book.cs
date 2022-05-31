using System;


namespace Library
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Genre { get; set; }

        public override string ToString()
        {
            return ($"{Title}, by {Author}");
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}