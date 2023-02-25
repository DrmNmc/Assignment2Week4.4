using System;

namespace NerdStuff
{
    interface ITech
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void TurnOn();
    }

    class Laptop : ITech
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Laptop()
        {
            Brand = "Unknown";
            Model = "Unknown";
        }

        public Laptop(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turning on {Brand} {Model}...");
        }

        public string GetInfo()
        {
            return $"{Brand} {Model}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("Dell", "XPS 13");
            laptop.TurnOn();
            Console.WriteLine($"Laptop Model: {laptop.GetInfo()}");
        }
    }
}
