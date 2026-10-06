using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            set 
            {
                if (!value.Any(char.IsDigit))
                {
                    _title = value;
                }
                else 
                {
                    Console.WriteLine("Title cannot contain numbers.");
                }
            
            }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        // Make ISBN an int property
        public int ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        //Constructors 
        public Book(string booktitle, string bookauthor, int bookISBN)
        {
            Title = booktitle;
            Author = bookauthor;
            _isbn = bookISBN;    // ← changed: assign backing field (int) directly
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
