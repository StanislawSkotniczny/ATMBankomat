using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ATMBankomat
{
    internal class Account
    {
        string Name { get; set; }
        string Surname { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }    


        public Account(string name , string surname , string password , int id)
        {
            this.Name = name;
            this.Surname = surname;
            this.Password = password;
            this.Id = id;

        }
           


        public int Ballance { get; set; }
        bool PremiumAccount { get; set; }


        public  void Deposit(int y)
        {
            Console.Write("enter the amount of money:");
            int x = int.Parse(Console.ReadLine());
            Ballance += x;
        }


        public void Withdraw(int y)
        {
            Console.Write("enter the amount of money:");
            int x = int.Parse(Console.ReadLine());
            if (x <= Ballance)
            Ballance -= x;
            else
                Console.WriteLine("Not enough money");
        }

        public  void DisplayInfo()
        {
            Console.WriteLine(Ballance);
        }


        public void CreateAccount()
        {

        }


    }
}
