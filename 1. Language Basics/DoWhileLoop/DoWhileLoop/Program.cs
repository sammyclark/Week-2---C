using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string ans;

            do 

            {
                Console.WriteLine("Feed me and I live. Give me a drink and I die. What am I?");
                ans = Console.ReadLine().ToLower();
            }
            while (ans != "fire");
            Console.WriteLine("You are correct!");
        }
    }
}
