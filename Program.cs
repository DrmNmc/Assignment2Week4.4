using System;

namespace SealedClass
{
    interface IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Fullname();
        public double Pay();
    }

    class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Fullname()
        {
            return FirstName + " " + LastName;
        }

        public virtual double Pay()
        {
            double salary;
            Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
            salary = double.Parse(Console.ReadLine());
            return salary;
        }
    }

    sealed class Executive : Employee
    {
        public string Title { get; set; }
        public double Salary { get; set; }

        public Executive() : base()
        {
            Title = string.Empty;
            Salary = 0;
        }

        public Executive(int id, string firstName, string lastName, string title, double salary) : base(id, firstName, lastName)
        {
            Title = title;
            Salary = salary;
        }

        public override double Pay()
        {
            Console.WriteLine($"What is {this.Fullname()}'s weekly bonus?");
            double bonus = double.Parse(Console.ReadLine());
            return Salary + bonus;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Scary", "Terri");
            Console.WriteLine($"Employee: {employee.Fullname()}");
            Console.WriteLine($"Salary: {employee.Pay()}");

            Executive executive = new Executive(2, "Cruella", "DeVil", "CEO", 10000000);
            Console.WriteLine($"Executive: {executive.Fullname()}");
            Console.WriteLine($"Title: {executive.Title}");
            Console.WriteLine($"Salary: {executive.Pay()}");
        }
    }
}
