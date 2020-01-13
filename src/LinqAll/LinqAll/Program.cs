using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace LinqAll
{
    class Program
    {
        static void Main(string[] args)
        {
            AllCarsAreRedWhenTrue();
            AllCarsAreRedWhenFalse();
            AllCarsAreRedWhenNoCars();
            AllCarsAreRedAndBlueWhenNoCars();
            NotAnyShouldEqualAllNot();
            AnyAndAllCarsAreRed();
        }

        public static void AllCarsAreRedWhenTrue()
        {
            var cars = new List<Car>
            {
                new Car {Color = Color.Red},
                new Car {Color = Color.Red},
                new Car {Color = Color.Red}
            };

            var allCarsAreRed = cars.All(car => car.Color == Color.Red);

            Console.WriteLine($"All cars are red: {allCarsAreRed}"); //true
        }

        public static void AllCarsAreRedWhenFalse()
        {
            var cars = new List<Car>
            {
                new Car {Color = Color.Red},
                new Car {Color = Color.Blue},
                new Car {Color = Color.Red}
            };

            var allCarsAreRed = cars.All(car => car.Color == Color.Red);

            Console.WriteLine($"All cars are red: {allCarsAreRed}"); //false
        }

        public static void AllCarsAreRedWhenNoCars()
        {
            var cars = new List<Car>(); //Empty list of cars

            var allCarsAreRed = cars.All(car => car.Color == Color.Red);

            Console.WriteLine($"All cars are red: {allCarsAreRed}"); //still true
        }

        public static void AllCarsAreRedAndBlueWhenNoCars()
        {
            var cars = new List<Car>(); //Empty list of cars

            var allCarsAreRed = cars.All(car => car.Color == Color.Red);
            var allCarsAreBlue = cars.All(car => car.Color == Color.Blue);

            var allCarsAreRedAndBlue = allCarsAreRed && allCarsAreBlue;

            Console.WriteLine($"All cars are red and blue: {allCarsAreRedAndBlue}"); //true
        }

        public static void NotAnyShouldEqualAllNot()
        {
            var cars = new List<Car>(); //Empty list of cars

            var thereAreNotAnyCarsThatAreRed = !cars.Any(car => car.Color == Color.Red);

            var allCarsAreNotRed = cars.All(car => car.Color != Color.Red);

            Console.WriteLine($"Not any equals all not: {thereAreNotAnyCarsThatAreRed == allCarsAreNotRed}"); //true
        }

        public static void AnyAndAllCarsAreRed()
        {
            var cars = new List<Car>();

            var allCarsAreRed = cars.Any() && cars.All(car => car.Color == Color.Red);

            Console.WriteLine($"Any and all cars are red: {allCarsAreRed}"); //false
        }
    }

    public class Car
    {
        public Color Color { get; set; }
    }
}
