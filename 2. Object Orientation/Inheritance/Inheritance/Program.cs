using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public string make;
        public string model;
        public int price;
        public bool sold;

        public int sellPrice;

        public static int vehSold;
        public static int vehNo;

        public static string type;

        public Vehicle(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            vehNo++;
        }

        public void sellVehicle(bool sold, int sellPrice)
        {
            this.sold = sold;
            this.sellPrice = sellPrice;
            Vehicle.vehSold++;
            Vehicle.vehNo--;
        }

        //instance method for selling 

        public static void displayVehicles(List<Vehicle> allVeh)
        {
            int valueSold = 0;
            int valueIn = 0;
            Console.WriteLine("in display vehicles");
            //variables for the total value of sold cars and total value of cars still in stock

            foreach (Vehicle item in allVeh)
            {
                if (item is Car)
                {
                    Console.WriteLine("Car details: {0} {1} priced at £{2}.", item.make, item.model, item.price);
                    if (item.sold)
                    {
                        Console.WriteLine("This car has been sold.");
                        valueSold += item.sellPrice;
                    }
                    else
                    {
                        Console.WriteLine("This car is unsold.");
                        valueIn += item.price;
                    }
                }
                else
                    {
                        Console.WriteLine("Motorcycle details: {0} {1} priced at £{2}.", item.make, item.model, item.price);
                    if (item.sold)
                    {
                        Console.WriteLine("This motorcycle has been sold.");
                        valueSold += item.sellPrice;
                    }
                    else
                    {
                        Console.WriteLine("This motorcycle is unsold.");
                        valueIn += item.price;
                    }

                }
            }


            //displays the details of the cars including whether they have been sold

            Console.WriteLine("The total value of vehicles sold is: £{0:N0}.", valueSold);
            Console.WriteLine("The total value of vehicles still in stock is: £{0:N0}.", valueIn);
            Console.WriteLine();
        }
        //displays the total value of sold cars and total value of cars still in stock
    }
        //created base class vehicle

        class Car : Vehicle
        {
            public static int carNo;
            
            public Car(string make, string model, int price, string type = "car") : base (make, model, price)
            {
                carNo++;
            }

            public void sellCar (bool sold, int sellPrice)
            {
                sellVehicle(sold, sellPrice);
               carNo--;
            }

        }
        class Motorcycle : Vehicle
        {
            public static int bikeNo;

            public Motorcycle(string make, string model, int price, string type = "bike") : base (make, model, price)
            {
                bikeNo++;
            }
        public void sellBike(bool sold, int sellPrice)
        {
            sellVehicle(sold, sellPrice);
            bikeNo--;
        }
    }

        //created derived classes Car and Motorcycle

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> allVeh = new List<Vehicle>();

            Car car1 = new Car("Volvo", "XC90", 40000);
            Car car2 = new Car("BMW", "Z4", 350000);
            Car car3 = new Car("Landrover", "Vogue", 50000);
            Car car4 = new Car("Aston Martin", "Vanquish", 60000);
            allVeh.Add(car1);
            allVeh.Add(car2);
            allVeh.Add(car3);
            allVeh.Add(car4);

            //instantiate objects into class Car

            Motorcycle bike1 = new Motorcycle("Yamaha", "Apex", 8000);
            Motorcycle bike2 = new Motorcycle("Suzuki", "GSX R1000", 10000);
            Motorcycle bike3 = new Motorcycle("Triumph", "Scrambler", 6000);
            allVeh.Add(bike1);
            allVeh.Add(bike2);
            allVeh.Add(bike3);

            //instantiate objects into class Motorcycle

            Console.WriteLine("Vehicles in stock: {0}. Vehicles sold: {1}", Vehicle.vehNo, Vehicle.vehSold);
            Console.WriteLine("Cars in stock: {0}. Motorcycles in stock {1}", Car.carNo, Motorcycle.bikeNo);

            //displays the number of vehicles in stock and sold

            Vehicle.displayVehicles(allVeh);

            //displays the details of all cars

            car3.sellCar(true, 45000);
            bike2.sellBike(true, 8000);


            Console.WriteLine("Vehicles in stock: {0}. Vehicles sold: {1}", Vehicle.vehNo, Vehicle.vehSold);
            Console.WriteLine("Cars in stock: {0}. Motorcycles in stock {1}", Car.carNo, Motorcycle.bikeNo);
            Vehicle.displayVehicles(allVeh);

            //displays the number of cars in stock, number of cars sold and car details after car3 has been sold
        }
    }
}
