using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What walks on the 4 legs in the morning, 2 legs in the day and 3 legs at night");
            string ans = Console.ReadLine();

            while (ans == "person")
            {
                Console.WriteLine("You are correct!");
                Console.ReadLine();
            }
           


        }
    }
}
