using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesStaticMethods
{
    class Car
    {
        public string name;
        public string model;
        public int price;
        public bool sold;
        public int sellPrice;

        public static int carsSold;
        public static int carNo;

        //created variables for cars (name, model, price, sell price and whether it has been sold) and static variables (number of cars sold and number of cars remaining)
        
        public void addCar(string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
            this.sold = false;
            Car.carNo++;

        }

        public void sellCar(bool sold, int sellPrice)
        {
            this.sold = sold;
            this.sellPrice = sellPrice;
            Car.carsSold++;
            Car.carNo--;

        }

        //instance methods for adding and selling cars

        public static void displayCars(List<Car> allCars)
        {
            int valueSold = 0;
            int valueIn = 0;

            //variables for the total value of sold cars and total value of cars still in stock

            foreach (Car item in allCars)
            {
                Console.WriteLine("Car details: {0} {1} priced at £{2}.", item.name, item.model, item.price);
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

            //displays the details of the cars including whether they have been sold

            Console.WriteLine("The total value of cars sold is: £{0:N0}.", valueSold);
            Console.WriteLine("The total value of cars still in stock is: £{0:N0}.", valueIn);
            Console.WriteLine();

            //displays the total value of sold cars and total value of cars still in stock
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> allCars = new List<Car>();

            Car car1 = new Car();
            car1.addCar("Volvo", "XC90", 40000);
            allCars.Add(car1);

            Car car2 = new Car();
            car2.addCar("BMW", "Z4", 35000);
            allCars.Add(car2);

            Car car3 = new Car();
            car3.addCar("Land Rover", "Vogue", 50000);
            allCars.Add(car3);

            Car car4 = new Car();
            car4.addCar("Aston Martin", "Vanquish", 40000);
            car4.sellCar(true, 37000);
            allCars.Add(car4);

            //Car car1 = new Car("Volvo", "XC90", 40000);
            //Car car2 = new Car("BMW", "Z4", 350000);

            //instantiate objects into class Car

            Console.WriteLine("Cars in stock: {0}. Number of cars sold: {1}", Car.carNo, Car.carsSold);

            //displays the number of cars in stock and the number of cars sold

            Car.displayCars(allCars);

            //displays the details of all cars

            car2.sellCar(true, 45000);
            Console.WriteLine("Cars in stock: {0}. Number of cars sold: {1}", Car.carNo, Car.carsSold);
            Car.displayCars(allCars);

            //displays the number of cars in stock, number of cars sold and car details after car3 has been sold
        }
    }
}
