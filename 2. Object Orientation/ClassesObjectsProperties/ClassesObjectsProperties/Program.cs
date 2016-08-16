using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsProperties
{
    class Car
    {
        public string name;
        public string model;
        public int price;
        public bool sold;

        public static int carsSold;
        public static int carNo;

        //Created car class

    }
    class Program
    {
        static void Main(string[] args)
        {            

            Car car1 = new Car();

            car1.name = "Volvo";
            car1.model = "XC90";
            car1.price = 40000;
            car1.sold = false;
            Car.carNo++;

            Car car2 = new Car();

            car2.name = "BMW";
            car2.model = "Z4";
            car2.price = 35000;
            car2.sold = false;
            Car.carNo++;

            Car car3 = new Car();
            
            car3.name = "Land Rover";
            car3.model = "Vogue";
            car3.price = 50000;
            car3.sold = false;
            Car.carNo++;

            Car.carsSold = 0;

            //instantiate 3 objects into class Car

            Console.WriteLine("The number of available cars is: " + Car.carsSold + ". There are " + Car.carNo + " available cars.");
            Console.WriteLine("Car 1 is a " + car1.name + " " + car1.model + " priced at " + car1.price);
            Console.WriteLine("Car 2 is a " + car2.name + " " + car2.model + " priced at " + car2.price);
            Console.WriteLine("Car 3 is a " + car3.name + " " + car3.model + " priced at " + car3.price);

        }
    }

}
