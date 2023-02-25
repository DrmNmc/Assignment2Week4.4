using System;

namespace AbstractAnimalClass
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public string Color { get; set; }
        public int Age { get; set; }

        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Dog : Animal
    {
        public override string Name { get; set; }

        public Dog()
        {
            Name = "Unknown";
            Color = "Unknown";
            Age = 0;
        }

        public Dog(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }

        public override string Describe()
        {
            return $"I am a {Color} dog named {Name} and I am {Age} years old.";
        }
    }

    class Cat : Animal
    {
        public override string Name { get; set; }

        public Cat()
        {
            Name = "Unknown";
            Color = "Unknown";
            Age = 0;
        }

        public Cat(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }

        public override string Describe()
        {
            return $"I am a {Color} cat named {Name} and I am {Age} years old.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            Console.WriteLine(dog1.whatAmI());
            Console.WriteLine(dog1.Describe());

            Cat cat1 = new Cat("Sesame", "tan and orange", 3);
            Console.WriteLine(cat1.whatAmI());
            Console.WriteLine(cat1.Describe());
        }
    }
}
