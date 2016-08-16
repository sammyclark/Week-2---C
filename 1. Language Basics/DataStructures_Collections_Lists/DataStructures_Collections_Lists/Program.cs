using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Collections_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> bookList = new List<string>() {"Percy Jackson and the Olympians", "The Well of Ascension", "Warbreaker", "The Black Prism"};

            //Created list of books

            string ans;
            string title;

            //Created variables

            do
            {
                Console.WriteLine("Please choose what to do. a = add a book, d = delete a book, l = list the books, s = sort the books, f to search for a book and x to exit");
                ans = Console.ReadLine().ToLower();

                //Runs the switch statement when ans is input

                switch (ans)
                {
                    case "a":
                        Console.WriteLine("Please enter a book title to add");
                        title = Console.ReadLine();
                        bookList.Add(title);
                        break;

                        //Adds a book
                    case "d":
                        Console.WriteLine("Please enter a book title to delete");
                        title = Console.ReadLine();
                        bookList.Remove(title);
                        break;

                        //Deletes a book

                    case "l":
                        for (int i = 0; i < bookList.Count; i++)
                        {
                            Console.WriteLine(bookList[i]);
                        }
                        break;

                        //Lists the books

                    case "s":
                        bookList.Sort();
                        break;

                        //Sorts the books by alphabetical order

                    case "f":
                        Console.WriteLine("Please enter a book title to search");
                        title = Console.ReadLine();
                            if (bookList.Contains(title))
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
