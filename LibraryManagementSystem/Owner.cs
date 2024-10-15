using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Owner
    {
        //private string password = "2244";
        //public Owner(string password) 
        //{

        //}

        public List<Librarian> getAllLibrarians(Library library)
        {
            return library.getAllLibrarians();
        }

        public List<LibraryUser> getAllUsers(Library library)
        {
            return library.getAllUsers();
        }

        public List<Book> getCurrentBooks(Library library)
        {
            return library.getCurrentBooks();
        }

        public List<Book> getBorrowedBooks(Library library)
        {
            return library.getBorrowedBooks();
        }
        public int getUserCount(Library library)
        {
            return library.getAllUsers().Count;
        }

        public int getLibrarianCount(Library library)
        {
            return library.getAllLibrarians().Count;
        }

        public int getCurrentBooksCount(Library library)
        {
            return library.getCurrentBooks().Count;
        }

        public int getBorrowedBooksCount(Library library)
        {
            return library.getBorrowedBooks().Count;    
        }

        public int getEmptyBookCount(Library library) 
        {
            return library.getEmptyBookCount();
        }

        public void displayLibrariansInfo(Library library)
        {
            Console.WriteLine($" - Librarians : {this.getLibrarianCount(library)}");
            foreach (var libraryUser in getAllLibrarians(library))
            {
                Console.Write($"\t  {libraryUser}, ");
            }
            Console.WriteLine();
        }

        public void displayUsersInfo(Library library)
        {
            Console.WriteLine($" - Users : {this.getUserCount(library)}");
            foreach (var user in getAllUsers(library))
            {
                Console.Write($"\t  {user}, ");
            }
            Console.WriteLine();
        }

        public void displayCurrentBooksInfo(Library library) 
        {

            Console.WriteLine($" - Current Books : {this.getCurrentBooksCount(library)}");
            foreach (var currentBook in getCurrentBooks(library))
            {
                Console.Write($"\t  {currentBook.Title}, ");
            }
            Console.WriteLine();
        }

        public void displayBorrowedBooksInfo(Library library)
        {
            Console.WriteLine($" - Borrowed Books : {this.getBorrowedBooksCount(library)}");
            foreach (var borrowedBook in getCurrentBooks(library))
            {
                Console.Write($"\t  {borrowedBook.Title}, ");
            }
            Console.WriteLine();
        }

        public void displayAllInformation(Library library)
        {
            this.displayLibrariansInfo(library);
            this.displayUsersInfo(library);
            this.displayCurrentBooksInfo(library);
            this.displayBorrowedBooksInfo(library);
        }
    }
}
