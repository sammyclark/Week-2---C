using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = new decimal[5];

            try
            {
                for (int i = -1; i < numbers.Length; i++)

                //breaks because arrays start at 0 so -1 wouldn't be in an array

                {
                    Console.WriteLine("Please enter a number");
                    numbers[i] = Convert.ToDecimal(Console.ReadLine());
                }
            }

            //tries the code that might cause an exception
            
                catch (IndexOutOfRangeException problem)

                {
                    Console.WriteLine(problem.Message);
                }

            //outputs message that describes the problem

                finally
                {
                    try
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            Console.WriteLine("Please enter a number");
                            numbers[i] = Convert.ToDecimal(Console.ReadLine());
                        }
                    }
                        catch (System.FormatException problem)
                        {
                            Console.WriteLine(problem.Message);
                        }
                }


         

        }
    }
}
