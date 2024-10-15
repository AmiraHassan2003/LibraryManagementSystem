namespace LibraryManagementSystem;
using System;
class Program{
    private static void Main(string[] args){
        Console.WriteLine(" ---- Welcome In Library Management System ---- ");
        Library library = new Library();
        char choiceAuthorize = ' ';
        
        do
        {
            Console.WriteLine("Are you Librarian (L), User (U) or Owner (O) ?, enter (x) to exit");
            choiceAuthorize = Console.ReadLine().ToUpper()[0];
            if (choiceAuthorize == 'L')
            {
                Console.Write("Enter your name : ");
                string librarianName = Console.ReadLine();
                Librarian librarian = new Librarian(librarianName);
                Console.WriteLine($"Hello, {librarian.Name}");
                char choice = ' ';
                do
                {
                    Console.WriteLine("Please choose to Add Book (A) / Remove Book (R) / Display Current Books (C) / Display Borrowed Books (B) / Exit (E)");
                    choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine(" -- Book Details --");
                            Console.Write("Title : ");
                            string addTitleBook = Console.ReadLine().ToLower().ToLower();
                            Console.Write("Author : ");
                            string addAuthorBook = Console.ReadLine().ToLower();
                            Console.Write("Year : ");
                            int addYearBook = 0;
                            int.TryParse(Console.ReadLine(), out addYearBook);
                            Book addBook = new Book(addTitleBook, addAuthorBook, addYearBook);
                            librarian.AddBook(addBook, library);
                            break;
                        case 'R':
                            Console.WriteLine(" -- Book Details --");
                            Console.Write("Title : ");
                            string removeTitleBook = Console.ReadLine().ToLower();
                            Console.Write("Author : ");
                            string removeAuthorBook = Console.ReadLine().ToLower();
                            Console.Write("Year : ");
                            int removeYearBook = 0;
                            int.TryParse(Console.ReadLine(), out removeYearBook);
                            Book removeBook = new Book(removeTitleBook, removeAuthorBook, removeYearBook);
                            librarian.RemoveBook(removeBook, library);
                            break;
                        case 'C':
                            librarian.DisplayCurrentBooks(library);
                            break;
                        case 'B':
                            librarian.DisplayBorrowedBooks(library);
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("\n\t ------------------------ ");
                } while (choice != 'E');

            }
            else if (choiceAuthorize == 'U')
            {
                Console.Write("Enter your name : ");
                string userName = Console.ReadLine();
                LibraryUser user = new LibraryUser(userName);
                Console.WriteLine($"Hello, {userName}");
                char choice = ' ';
                do
                {
                    Console.WriteLine(" -- Please choose (B) to borrow a book / (E) to exit --");
                    choice = Console.ReadLine().ToUpper()[0];

                    if (choice == 'B')
                    {
                        Console.WriteLine(" -- Details of the book To Borrow --");
                        Console.Write("Title : ");
                        string titleBook = Console.ReadLine().ToLower().ToLower();
                        Console.Write("Author : ");
                        string authorBook = Console.ReadLine().ToLower();
                        Console.Write("Year : ");
                        int yearBook = 0;
                        int.TryParse(Console.ReadLine(), out yearBook);
                        Book book = new Book(titleBook, authorBook, yearBook);
                        user.BorrowedBook(book, library);
                    }

                } while (choice != 'E');
                
            }
            else if(choiceAuthorize == 'O')
            {
                Owner owner = new Owner();
                char choice = ' ';
                do
                {
                    Console.WriteLine("Choose to Display All Information (I) / Information about a book (A) / Users (U) / Librarians (L) / Current Books (C) / Borrowed Books (B) / Exit (E)");
                    choice = Console.ReadLine().ToUpper()[0];

                    switch (choice)
                    {
                        case 'I':
                            owner.displayAllInformation(library);
                            break;
                        case 'A':

                            break;
                        case 'U':
                            owner.displayUsersInfo(library); 
                            break;
                        case 'L':
                            owner.displayLibrariansInfo(library);
                            break;
                        case 'C':
                            owner.displayCurrentBooksInfo(library);
                            break;
                        case 'B':
                            owner.displayBorrowedBooksInfo(library);
                            break;
                        default:
                            break;
                    }

                } while (choice != 'E');

            }
        } while (choiceAuthorize != 'X');
        
    }
}

