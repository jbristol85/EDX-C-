using System;

namespace Mod1_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating an object of car() class by using type inference called Car1
            var Car1 = new Car();

            // use dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            //output to the console window
            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");
            var Car2 = new Car("Red", 2008);

            //access static members
            int carCount = Car.CountCars();

            //output to the console
            Console.WriteLine($"There are {carCount} cars in inventory right now.");
        }
    }

    
}
