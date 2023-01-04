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
                        Account account = new Account(customer);
                        customer.DisplayUserInfo();
                        accounts.Add(account);
                        string userInput = null;
                        while (userInput != "3")
                        {
                            Console.WriteLine("Account was succesfully created");
                            Console.WriteLine("Press 1 to deposit money");
                            Console.WriteLine("Press 2 to withdraw money");
                            Console.WriteLine("Press 3 to exit");

                            userInput = Console.ReadLine();

                            if (userInput == "1")
                            {
                                account.Deposit();
                            }
                            else if (userInput == "2")
                            {
                                account.Withdraw();
                            }
                            else
                            {
                                work = false;
                            }
                            account.DisplayInfo();
                        } 
                       
                       
                        break;

                    case "2":

                        
                        try 
                        {
                            Account account1 = null ;
                            do 
                            {
                                Console.Write("enter your id: ");
                                string id_check = (Console.ReadLine());
                                if (!int.TryParse(id_check, out int lol))
                                {
                                    throw new Exception("wrong id");
                                }


                                
                                account1 = Login(lol);
                                if(account1 == null)
                                {
                                    throw new Exception("");
                                }

                                string userInput1 = null;
                                while(userInput1 != "3")
                                {
                                    Console.WriteLine("Press 1 to deposit money");
                                    Console.WriteLine("Press 2 to withdraw money");
                                    Console.WriteLine("Press 3 to exit");
                                    userInput1 = Console.ReadLine();

                                    if (userInput1 == "1")
                                    {
                                        account1.Deposit();
                                    }
                                    else if (userInput1 == "2")
                                    {
                                        account1.Withdraw();
                                    }
                                    else
                                    {
                                        account1 = null;
                                    }
                                   
                                }
                            }
                            while (account1 != null);



                        }
                        catch(Exception ex )
                        {
                            Console.WriteLine(ex.Message);

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

        public static Account Login(int id_check)
        {
            for (int i = 0; i < accounts.Count; i++)
            {

                if (accounts[i].Customer.Id == (id_check))
                {
                    Console.Write("Enter your password:");
                    string password_check = Console.ReadLine();


                    if (accounts[i].Customer.Password == (password_check))
                    {
                        Console.WriteLine("Welcome to your account ");
                        return  accounts[i];


                    }
                }

               
            }
            return null;
        }



    }
}