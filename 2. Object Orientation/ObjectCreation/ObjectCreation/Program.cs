using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCreation
{

    class Car
    {
        public string make;
        public string model;
        public int price;
        public Boolean sold;
        public int wheels;
        public int passengers;

        public static int numberOfCars;

        //AddCar method changed to a constructor by changing its name to Car (same as the class)
        //and removing its return type
        public Car(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            this.wheels = 4;
            this.passengers = 5;

            Car.numberOfCars++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            string make;
            string model;
            int price;

            List<Car> carsList = new List<Car>();

            do
            {
                Console.WriteLine("Please type A to add a car to the list or X to exit:");
                response = Console.ReadLine().ToUpper();

                if (response == "A")
                {
                    Console.WriteLine("Please enter a make:");
                    make = Console.ReadLine();
                    Console.WriteLine("Please enter a model:");
                    model = Console.ReadLine();
                    Console.WriteLine("Please enter a price:");
                    price = Convert.ToInt32(Console.ReadLine());

                    Car myCar = new Car(make, model, price);
                    carsList.Add(myCar);

                    Console.WriteLine("\nHere is the current list of cars:\n");
                    foreach (Car car in carsList)
                    {
                        Console.WriteLine("Make: {0}", car.make);
                        Console.WriteLine("Model: {0}", car.model);
                        Console.WriteLine("Price: {0} \n", car.price);
                    }
                }
            }
            while (response != "X");

        }
    }
