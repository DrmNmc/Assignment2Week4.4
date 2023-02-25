using System;

namespace ClubInterface
{
    interface IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Fullname();
    }

    class ClubMember : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ClubMember()
        {

        }

        public ClubMember(int id, string firstName, string lastName, string email, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string Fullname()
        {
            return FirstName + " " + LastName;
        }

        public void DisplayPersonalInfo()
        {
            Console.WriteLine("Name: {0}", Fullname());
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine("Phone Number: {0}", PhoneNumber);
        }

        public void DisplayId()
        {
            Console.WriteLine("ID: {0}", Id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClubMember member = new ClubMember(1, "Scary", "Terri", "scaryT@email.com", "2315551212");
            member.DisplayId();
            member.DisplayPersonalInfo();
        }
    }
}
