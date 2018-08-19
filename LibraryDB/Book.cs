using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDB
{
    class Book
    {
        private int ID;
        private string Title;
        private string Author;
        private int Year;
        private string Genre;

        public Book(string title, string author, int year, string genre)
        {
            Title = title;
           Author = author;
            Year = year;
            Genre = genre;
        }
    }
}
