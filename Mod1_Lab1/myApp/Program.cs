using System;

namespace Mod1_Lab1
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

    //Declaring the Car() class
    // This class has 3 properties
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // adding a constructor
        //this constructor instantiates a Car() object while only having the color and year info
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            // every time the constructor runs, increment "instances"
            instances++;
        }

        // another constructor that will accept only a year and mileage
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            // every time the constructor runs, increment "instances"
            instances++;
        }

        //creates int variable called "Instances and assigns value to 0
        private static int instances = 0;

        public Car()
        {
            //every time the constructor runs, increment "Instances"
            instances++;
        }
        //declare static member
        public static int CountCars()
        {
            return instances;
        }
    }
}
