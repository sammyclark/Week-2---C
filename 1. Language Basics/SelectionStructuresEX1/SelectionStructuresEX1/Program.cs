using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStructuresEX1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randNo = new Random();
            int num = randNo.Next(1,10);

            do
                {
                    Console.WriteLine("Guess a number between 1 and 10");
                     num = Convert.ToInt32(Console.ReadLine());
                }

                while (num != randNo);
                Console.WriteLine("Well done, you are correct");
        }
    }
}
