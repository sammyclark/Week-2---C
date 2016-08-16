using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What would you like to eat?");
            string dinDins = Console.ReadLine();

            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Dopey", "Bashful", "Grumpy" };
            string[] food = new string[7];
            string[] drink = new string[7];

            //create arrays for dwarves, food and drink

            for (int f = 0; f < food.Length; f++)
            {
                food[f] = Console.ReadLine();
            }

            //create for loop to push inputted food into food array

            Console.WriteLine("What would you like to drink");

            for (int b = 0; b < drink.Length; b++)
            {
                drink[b] = Console.ReadLine();
            }
            
            //create for loop to push inputted beverage into beverage array

            for (int d = 0; d < sevenDwarves.Length; d++)
            {
                Console.WriteLine(sevenDwarves [d] + ", your " + food [d] + " is ready");
            }

            //create for loop to call dwarves for food

            for (int d = 0; d < sevenDwarves.Length; d++)
            {
                Console.WriteLine(sevenDwarves[d] + ", your " + drink[d] + " is ready");
            }

            // create for loop to call dwarves for a drink

        }
    }
}
