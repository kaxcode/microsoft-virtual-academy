﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            // myCar.Make = "Oldmobile";
            // myCar.Model = "Cutlas Supreme";
            // myCar.Year = 1986;
            // myCar.Color = "Silver";

            // Car myOtherCar;
            // myOtherCar = myCar;

            // Console.WriteLine("{0} {1} {2} {3}",
            //     myCar.Make,
            //     myCar.Model,
            //     myCar.Year,
            //     myCar.Color);

            // myOtherCar.Model = "98";

            // myOtherCar = null;

            // Console.WriteLine("{0} {1} {2} {3}", 
            //     myOtherCar.Make, 
            //     myOtherCar.Model, 
            //     myOtherCar.Year, 
            //     myOtherCar.Color);

            Console.ReadLine();
        }

        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            // public Car()
            // {
            //     // You could load from a configuration file,
            //     // a database, etc.
            //     Make = "Nissan";
            // }

            // public Car(string make, string model, int year, string color)
            // {
            //     Make = make;
            //     Model = model;
            //     Year = year;
            //     Color = color;
            // }

            public static void MyMethod()
            {
                Console.WriteLine("Called the static MyMethod");
            }
        }
    }
}
