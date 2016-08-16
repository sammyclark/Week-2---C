using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Collections_Dictionaires
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> langDict = new Dictionary<string, string>()
                {
                    {"C#", "The best"},
                    {"Java", "Meh"},
                    {"Python", "Noel thinks it's nice..."},
                    {"Ruby", "Nopenopenope"}
                };

            //created dictionary

            string ans;
            string dict;
            string result;

            //created variables

            do
            {
                Console.WriteLine("Welcome to the dictionary. Check if a key is present = k, check if a value is present = v, use a key to look up a value = l, count the items = c, exit the menu = x");
                ans = Console.ReadLine().ToLower();

                //Runs the switch statement when ans is input

                switch (ans)
                {
                    case "k":
                        Console.WriteLine("What key would you like to search");
                        dict = Console.ReadLine();
                        if (langDict.ContainsKey(dict))
                        {
                            Console.WriteLine("That key is present");
                        }
                        else
                        {
                            Console.WriteLine("That key is not present");
                        }
                        break;

                    //checks if a key is in the dictionary

                    case "v":
                        Console.WriteLine("What value would you like to search");
                        dict = Console.ReadLine();
                        if (langDict.ContainsValue(dict))
                        {
                            Console.WriteLine("That value is present");
                        }
                        else
                        {
                            Console.WriteLine("That value is not present");
                        }
                        break;

                    //checks if a value is in the dictionary

                    case "l":
                        Console.WriteLine("Input the name of the key");
                        dict = Console.ReadLine();
                        langDict.TryGetValue(dict, out result);
                        Console.WriteLine(result);
                        break;

                    //uses a key to look up a value

                    case "c":
                        int num = langDict.Count;
                        Console.WriteLine(num);
                        break;      
                        
                    //Count the list and output the number
                                        
                    default:
                        break;
                }
            }
            while (ans != "x");

            //exits the menu

        }
    }
}
