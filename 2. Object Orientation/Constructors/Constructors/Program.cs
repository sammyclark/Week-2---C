using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Car
    {
        public string name;
        public string model;
        public int price;
        public bool sold;
        public int passengers;

        public static int carNo;

        //created variables 

        public Car (string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
            this.sold = false;
            Car.carNo++;
        }
    
       //EXTENSION. FINISH THIS public Car (s)
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Volvo", "XC90", 40000);
            Car car2 = new Car("BMW", "Z4", 350000);

            Console.WriteLine("The number of cars in stock is {0}", Car.carNo);
            Console.Write("The cars available are: ");
            Console.WriteLine("{0} {1}, priced at {2}", car1.name, car1.model, car1.price);
            Console.WriteLine("{0} {1}, priced at {2}", car2.name, car2.model, car2.price);
        }
    }
}
