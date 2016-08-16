using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesInstanceMethods
{
    class Car
    {
        public string name;
        public string model;
        public int price;
        public Boolean sold;
        public int sellPrice;

        public static int carsSold;
        public static int carNo;

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
            
        }

        public static void displayCars(List<Car> allCars)
        {
            int valueSold = 0;
            int valueIn = 0; 
        }
    }

        //Created car class and methods for it (add cars and sell cars)

  
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

            Car car4 = new Car();
            car4.addCar("Honda", "Civic", 10000);
            car4.sellCar(true, 9500);

            //instantiate 3 objects into class Car

            Console.WriteLine("Cars in stock: {0}. Number of cars sold: {1}", Car.carNo, Car.carsSold);

            Console.WriteLine("Car 1 is a {0} {1} priced at £{2}. {3}", car1.name, car1.model, car1.price);
            Console.WriteLine("Car 2 is a {0} {1} priced at £{2}. {3}", car2.name, car2.model, car2.price);
            Console.WriteLine("Car 3 is a {0} {1} priced at £{2}. {3}", car3.name, car3.model, car3.price);
            Console.WriteLine("Car 4 is a {0} {1} priced at £{2}. {3}", car4.name, car4.model, car4.price);
            Console.WriteLine("Sold for: " + car4.sellPrice); 


    }
    }

}
