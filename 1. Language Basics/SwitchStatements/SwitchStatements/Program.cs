using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Who will get their round of tuck first? Sarah or Sean?");

            string reply = Console.ReadLine();

            switch (reply)
                {
                    case "Sarah":
                    case "sarah":
                    reply = "Obviously. She's the best. At everything.";
                    break;
                    case "Sean":
                    case "sean":
                    reply = "Ludicrous. I have nothing to say to you";
                    break;
                default:
                    reply = "Who's going to win?";
                    break;
                }
            Console.WriteLine(reply);
        }
    }
}
