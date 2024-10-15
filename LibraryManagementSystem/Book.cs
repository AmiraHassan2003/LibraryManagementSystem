using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public string Title{ get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Book))
                return false;

            Book other = (Book)obj;
            return Title == other.Title && Author == other.Author && Year == other.Year;
        }

        public override int GetHashCode()
        {
            return (Title, Author, Year).GetHashCode();
        }

    }
}
