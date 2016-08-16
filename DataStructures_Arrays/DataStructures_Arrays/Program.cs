using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = new decimal[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                numbers[i] = Convert.ToDecimal(Console.ReadLine());
            }

            //Collects the numbers

    
            Console.WriteLine("The average of your numbers is" + (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) / 5);

            //calculates and displays the average 
        }
    }
}
