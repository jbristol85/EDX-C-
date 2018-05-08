using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine("Kitchen", "Bonavita", "bv1900");
            myMachine.Location = "Kitchen";
            myMachine.Model = "Dm1000";

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);
            myMachine.MakeCappuccino();
        }

    }

    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }
        // declare private member variables
        private string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        private string _make;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        private string _model;        

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        // declaring public methods
        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino is made.");
        }
        public void MakeEspresso()
        {
            Console.WriteLine("Espresso is made.");
        }

    }
}
