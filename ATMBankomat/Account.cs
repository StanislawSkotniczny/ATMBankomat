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
        public Customer Customer { get; set; }
        
        public Account(Customer customer  )
        {    
            this.Customer = customer;
        }


        public int Ballance { get; set; }
        bool PremiumAccount { get; set; }


        public  void Deposit()
        {
            Console.Write("enter the amount of money:");
            int x = int.Parse(Console.ReadLine());
            Ballance += x;
        }


        public void Withdraw()
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
            Console.WriteLine($"Ballance :{Ballance}");
        }


       


    }
}
