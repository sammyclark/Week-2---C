using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (integer)");

            int guess = Convert.ToInt32(Console.ReadLine());

            int num = 3;

            if (guess == num)
                {
                    Console.WriteLine("Well done. You are correct");
                }
                else if (guess < num)
                    {
                        Console.WriteLine("Sorry, your guess was too low");
                    }
                else
                    {
                        Console.WriteLine("Sorry, your guess was too high");
                    }
        }
    }
}
