using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibraryUser : User
    {
        private LibraryCard Card;

        public LibraryUser(string name) 
        {
            Name = name;
            Card = new LibraryCard();
        }
        public void BorrowedBook(Book book, Library library)
        {
            library.BorrwedBooks(book);
        }
    }
}
