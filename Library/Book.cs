using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {

        //Private fields
        private string _title;
        private string _author;
        private int _isbn;

        //Public Properties
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string ISBN
        {
            get { return _isbn.ToString(); }
            set { _isbn = int.Parse(value); }
        }
        //Constructors 
        public Book(string booktitle, string bookauthor, int bookISBN)
        {
            Title = booktitle;
            Author = bookauthor;
            ISBN = bookISBN;

        }

        //Methods

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

    }
}
