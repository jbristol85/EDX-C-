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
        }
    }

    //Declaring the Car() class
    // This class has 3 properties
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
