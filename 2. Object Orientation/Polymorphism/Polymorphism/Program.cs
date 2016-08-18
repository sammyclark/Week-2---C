using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car
    {
        public virtual void Wheels()
            {
               Console.WriteLine("This is a car"); 
            }
    }

    class threeWheel: Car
    {
        public override void Wheels()
        {
            Console.WriteLine("This is a three wheeled car");
        }
    }

    class fourWheel : Car
    {
        public new void Wheels()
        {
            Console.WriteLine("This is a four wheel car");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car());
            cars.Add(new threeWheel());
            cars.Add(new fourWheel());

            foreach (Car c in cars)
            {
                c.Wheels();
            }

            fourWheel Honda = new fourWheel();
            Honda.Wheels();
        }
    }
}
