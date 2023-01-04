using ATMBankomat;
using System;
using System.Runtime;
using System.Security.Principal;

namespace ATM
{

    class Program
    {
        public static List<Account> accounts = new List<Account>();
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to bank ");
            Console.WriteLine("Press 1 to create an account");
            Console.WriteLine("Press 2 to log in ");
            Console.WriteLine("Press 3 to exit");
            
            var input = Console.ReadLine();
            bool work = true;
            while (work) {

                switch (input)
                {

                    case "1":
                        
                        Console.WriteLine("create account");
                        Console.Write("enter ur Name: ");
                        string name = Console.ReadLine();
                        Console.Write("enter ur surname: ");
                        string surname = Console.ReadLine();
                        Console.Write("create ur password: ");
                        string password = Console.ReadLine();


                        Customer customer = new Customer(password, name, surname);
                        customer.CreateAcc();
                        customer.DisplayUserInfo();

                        Console.WriteLine("Account was succesfully created");
                        Console.WriteLine("Press 1 to deposit money");
                        Console.WriteLine("Press 2 to withdraw money");
                        Console.WriteLine("Press 3 to exit");
                        string userInput = Console.ReadLine();

                        if (userInput == "1")
                        {
                            accounts[].Deposit(100);
                        }
                        else if (userInput == "2")
                        {
                            accounts[].Withdraw(200);
                        }
                        else
                        {
                            work = false;
                        }
                        accounts[].DisplayInfo();
                       
                        break;

                    case "2":

                        Console.Write("enter your id: ");
                        int id_check = int.Parse(Console.ReadLine());
                        for(int i= 0; i < accounts.Count; i++)
                        {
                            if (accounts[i].Id == (id_check))
                            {
                                Console.Write("Enter your password:");
                                string password_check = Console.ReadLine();
                                for(int j=0; j < accounts.Count; j++)
                                {
                                    if (accounts[j].Password == (password_check))
                                    {
                                        Console.WriteLine("Welcome to your account ");
                                        Console.WriteLine("Press 1 to deposit money");
                                        Console.WriteLine("Press 2 to withdraw money");
                                        Console.WriteLine("Press 3 to exit");
                                        string userInput1 = Console.ReadLine();

                                        if (userInput1 == "1")
                                        {
                                            accounts[j].Deposit(100);
                                        }
                                        else if (userInput1 == "2")
                                        {
                                            accounts[j].Withdraw(200);
                                        }
                                        else
                                        {
                                            work = false;
                                        }
                                        accounts[j].DisplayInfo();
                                    }
                                    else
                                        Console.WriteLine("wrong Password");
                                }

                            }
                            else
                            {
                                Console.WriteLine("user not found");
                            }


                        }


                        break;

                    case "3":
                         
                        
                        break;

                    default:
                        Console.WriteLine("select option");
                        break;

                }


                Console.WriteLine("Select function");
                work = true;
                input = Console.ReadLine();

            }



        }

       
    }
}