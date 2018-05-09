using System;

namespace Mod1_Lab3
{
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