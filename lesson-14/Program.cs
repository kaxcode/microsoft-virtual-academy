using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2010;
            myCar.Color = "Black";

            Console.WriteLine(myCar);

        }

        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
            
            public override string ToString()
            {
                return $"{Model} {Make} {Year} {Color} ";
            }
        }
    }
}
