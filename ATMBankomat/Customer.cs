using ATM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ATMBankomat
{
     public  class Customer: Person
    {
        public  string Password { get; set; }
        public static Random random = new Random();
        public int Id = random.Next();
     

        public Customer(string password ,string name , string surname ) : base(Name, Surname)
        {
            Password = password;
            Name = name;
            Surname = surname;
        }


        public void DisplayUserInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"Id: {Id}");
        }


        

    }
}
