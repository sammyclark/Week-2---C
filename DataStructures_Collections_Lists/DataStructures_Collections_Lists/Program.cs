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
            string book = Console.ReadLine();
            string ans;
            string title;

            do
            {
                Console.Write("Please choose what to do. a = add a book, d = delete a book, l = list the books, s = sort the books, f to search for a book and x to exit");
                ans = Console.ReadLine().ToLower();

                switch (ans)
                {
                    case "a":
                        Console.WriteLine("Please enter a book title to add");
                        title = Console.ReadLine();
                        bookList.Add(title);
                        break;
                    case "d":
                        Console.WriteLine("Please enter a book title to delete");
                        title = Console.ReadLine();
                        bookList.Remove(title);
                        break;
                    case "l":
                        for (int i = 0; i < bookList.Count; i++)
                        {
                            Console.WriteLine(bookList[i]);
                        }
                        break;
                    case "s":
                        bookList.Sort();
                        break;
                    //case "f":
                    //    Console.WriteLine("Please enter a book title to search");
                    //    bookList.Contains(title);
                    //    break;
                    default:
                        break;
                }
            }
            while (ans != "x");
            

        }
    }
}
