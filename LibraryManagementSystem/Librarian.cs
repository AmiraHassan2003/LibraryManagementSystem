using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Librarian : User
    {
        private static int LibrarianNumber = 0;
        //private Library Library;
        private List<Book> Books;

        public Librarian(string name)
        {
            //Library = new Library();
            Name = name;
            LibrarianNumber++;
        }

        public void AddBook(Book book, Library library)
        {
            library.AddBook(book);
        }

        public void RemoveBook(Book book, Library library)
        {
            library.RemoveBook(book);
        }

        public void DisplayCurrentBooks(Library library)
        {
            library.DisplayCurrentBooks();
        }

        public void DisplayBorrowedBooks(Library library)
        {
            library.DisplayBorrowedBooks();
        }

    }
}
