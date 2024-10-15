using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        private List<Book> CurrentBooks;
        private List<Book> BorrowedBooks;

        private List<Librarian> Librarians;
        private List<LibraryUser> LibraryUser;



        private int CurrentBookCount = 0;
        private int MaxBookCount = 100;
        private int BorrowedBookCount = 0;

        public Library()
        {
            CurrentBooks = new List<Book>();
            BorrowedBooks = new List<Book>();
            Librarians = new List<Librarian>();
            LibraryUser = new List<LibraryUser>();  
        }
        public List<Book> getCurrentBooks()
        {
            return CurrentBooks;
        }

        public List<Book> getBorrowedBooks()
        { 
            return BorrowedBooks;
        }
        public void AddBook(Book book)
        {
            if (CurrentBookCount < MaxBookCount)
            {
                if (book != null)
                {
                    CurrentBooks.Add(book);
                    CurrentBookCount++;
                    Console.WriteLine(" - The book has been added successfully");
                }
                else
                {
                    Console.WriteLine(" - Unavailable book");
                }
            }
            else
            {
                Console.WriteLine(" - Not found place to add this book");
            }
        }

        public void BorrwedBooks(Book book)
        {
            if (CurrentBooks.Contains(book))
            {
                BorrowedBooks.Add(book);
                BorrowedBookCount++;

                this.RemoveBook(book);
                Console.WriteLine(" - The book has been borrowed successfully");
            }
            else
            {
                Console.WriteLine(" - Unavailable book");
            }
        }
        public void RemoveBook(Book book)
        {
            if (CurrentBooks.Contains(book))
            {
                CurrentBooks.Remove(book);
                CurrentBookCount--;
                Console.WriteLine(" - The book has been removed successfully");
            }
            else
            {
                Console.WriteLine(" - This book was not found");
            }
        }

        public void DisplayCurrentBooks()
        { 
            if (CurrentBooks.Count > 0)
            {
                Console.Write(" - Current books : ");
                foreach (var book in CurrentBooks)
                {
                    Console.Write($"{book.Title} , ");
                }
            }
            else
            {
                Console.Write(" - There are no books to display");
            }
            Console.WriteLine();
        }

        public void DisplayBorrowedBooks()
        {
            if (BorrowedBooks.Count > 0)
            {
                Console.Write(" - Borrowed books : ");
                foreach (var book in BorrowedBooks)
                {
                    Console.Write($"{book.Title} , ");
                }
            }
            else
            {
                Console.Write(" - There are no books to display");
            }
            Console.WriteLine();
        }

        public int getCurrentBookCount()
        {
            return this.CurrentBookCount;
        }

        public int getBorrowedBookCount()
        {
            return this.BorrowedBookCount;
        }

        public int getEmptyBookCount()
        {
            return (this.MaxBookCount - this.CurrentBookCount);
        }

        public List<Librarian> getAllLibrarians()
        {
            return this.Librarians;
        }

        public List<LibraryUser> getAllUsers()
        {
            return this.LibraryUser;
        }


    }
}
