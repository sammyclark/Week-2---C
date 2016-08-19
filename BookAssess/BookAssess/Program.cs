using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAssess
{
    class Book
    {
        public string title;
        public string author;
        public int ISBN;
        public decimal price;

        //created variables for book attributes. Used ISBN-10 for ISBN number as ISBN has a "-" in it

        public static int bookNo;

        //created static variable for number of books

        public Book(string title, string author, int ISBN, decimal price)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.price = price;
            Book.bookNo++;
        }

        //adds book to catalogue

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
            string ans;
            string title;
            string author;
            int ISBN;
            decimal price;
            int index;

            List<Book> allBooks = new List<Book>();

            //creates a list of books

            do
            {
                Console.WriteLine("Welcome to the catalogue");
                Console.WriteLine("The number of books currently catalogued is: {0}", Book.bookNo);
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Press A to add a book to the catalogue");
                Console.WriteLine("Press D to delete a book from the catalogue");
                Console.WriteLine("Press L to list the books in the catalogue");
                Console.WriteLine("Press X to clear the booklist");            
                Console.WriteLine("Type Goodbye to exit the catalogue");

                ans = Console.ReadLine().ToLower();

                //variable to allow users to input what they want to do - case insensitive

                //Runs the switch statement when ans is input

                switch (ans)
                {
                    case "a":
                        Console.WriteLine("Please enter a book title:");
                        title = Console.ReadLine();
                        Console.WriteLine("Please enter the author of the book:");
                        author = Console.ReadLine();
                        Console.WriteLine("Please enter the book's ISBN-10");
                        ISBN = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter a price:");
                        price = Convert.ToDecimal(Console.ReadLine());

                        Book myBook = new Book(title, author, ISBN,  price);
                        allBooks.Add(myBook);
                        break;

                    //adds a book to the catalogue - This works

                    case "d":
                        Console.WriteLine("Please enter the index number of the book you would like to delete. See the catalogue for the book index ");
                        index = Convert.ToInt32(Console.ReadLine());
                        allBooks.RemoveAt(index - 1);
                        Book.bookNo--;
                        //changes the indexing to normal indexing rather than zero indexing
                        break;

                    //deletes a book using index number - note: This works but could make this more user friendly? Via name not index number?

                    case "x":
                        allBooks.Clear();
                        Book.bookNo = 0;
                        Console.WriteLine("THE CATALOGUE HAS BEEN RESET");                        
                        break;
                        

                    //resets the catalogue by deleting all books in it - This works

                    case "l":
                        Book.displayBooks(allBooks);
                        break;
                    
                    //displays all the books in the catalogue - This works

                    default:
                        break;
                }
            }
            while (ans != "goodbye");

            //exits the loop

            Console.WriteLine("Thank you for visiting.");

            //Exit line
        }
    }
}
