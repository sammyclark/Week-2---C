using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Book
    {
        public string title;
        public string author;
        public int ISBN;
        public decimal price;

        //created variables for book attributes. Used ISBN-10 for ISBN number

        public static int bookNo;

        //created static variable for number of books

        public Book (string title, string author, int ISBN, decimal price)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.price = price;
            Book.bookNo++;        
        }

        //adds book to catalogue

        public void addBook(string title, string author, int ISBN, decimal price)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.price = price;
            Book.bookNo++;
        }

        public void deleteBook(string title, string author, int ISBN, decimal price)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.price = price;
            Book.bookNo--;
        }

        //instance methods for adding and deleting books

        public static void displayBooks(List<Book> allBooks)
        {

            foreach (Book item in allBooks)
            {
                Console.WriteLine("Book: {0}. Author: {1}. ISBN-10: {2}. Price: £{3}", item.title, item.author, item.ISBN, item.price);
            }

            //displays the details of the books
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Book> allBooks = new List<Book>();

            Book book1 = new Book("Percy Jackson and the Lightning Thief", "Rick Riordan", 0141346809, 6.99M);
            allBooks.Add(book1);
            Book book2 = new Book("The Well of Ascension", "Brandon Sanderson", 0575089938, 9.99M);
            allBooks.Add(book2);
            Book book3 = new Book("The Black Prism", "Brent Weeks", 1841499048, 8.99M);
            allBooks.Add(book3);

            //created a list of pre-included books

            Console.WriteLine("Welcome to the catalogue");
            Console.WriteLine("The number of books currently catalogued is: {0}", Book.bookNo);
            Console.WriteLine("The books currently in the catalogue are:");
            Book.displayBooks(allBooks);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press A to add a book to the catalogue");
            Console.WriteLine("Press D to delete a book from the catalogue");
            Console.WriteLine("Press L to list the books in the catalogue");
            Console.WriteLine("Press S to sort the books in the catalogue");
            Console.WriteLine("Press F to search for a book in the catalogue");
            Console.WriteLine("Press X to exit the catalogue");

            //declares the number of books currently in the catalogue, the books themselves and asks what you would like to do next

            string title;
            string ans;

            //Created variable called ans for users to input books

            do
            {
                Console.WriteLine("Welcome to the catalogue");
                Console.WriteLine("The number of books currently catalogued is: {0}", Book.bookNo);
                Console.WriteLine("The books currently in the catalogue are:");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Press A to add a book to the catalogue");
                Console.WriteLine("Press D to delete a book from the catalogue");
                Console.WriteLine("Press L to list the books in the catalogue");
                Console.WriteLine("Press S to sort the books in the catalogue");
                Console.WriteLine("Press F to search for a book in the catalogue");
                Console.WriteLine("Press X to exit the catalogue");

                ans = Console.ReadLine().ToLower();

                //variable to allow users to input what they want to do

                //Runs the switch statement when ans is input

                switch (ans)
                {
                    case "a":
                        Console.WriteLine("Please enter a book title to add");
                        title = Console.ReadLine();
                        allBooks.Add(title);
                        break;

                    //Adds a book
                    case "d":
                        Console.WriteLine("Please enter a book title to delete");
                        title = Console.ReadLine();
                        allBooks.Remove(title);
                        break;

                    //Deletes a book

                    case "l":
                        Book.displayBooks(allBooks);
                        break;

                    //Lists the books - THIS WORKS

                    case "s":
                        allBooks.Sort();
                        break;

                    //Sorts the books by alphabetical order

                    case "f":
                        Console.WriteLine("Please enter a book title to search");
                        title = Console.ReadLine();
                        if (allBooks.Contains(title))
                        {
                            Console.WriteLine("That book is present");
                        }
                        else
                        {
                            Console.WriteLine("That book is not present");
                        }
                        break;

                    //Searches for book

                    default:
                        break;
                }
            }
            while (ans != "x");

            //when x is pressed, exit do while loop

        }
    }
}
