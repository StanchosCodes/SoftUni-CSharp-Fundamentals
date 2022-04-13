using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            double balance = 0;
            double coins = 0;

            while (comand != "Start")
            {
                coins = double.Parse(comand);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    balance += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                comand = Console.ReadLine();
            }

                bool isEnd = false;

            if (comand == "Start")
            {
                while (comand != "End")
                {
                    comand = Console.ReadLine();
                    if (comand == "End")
                    {
                        isEnd = true;
                        break;
                    }

                    switch (comand)
                    {
                        case "Nuts":
                            if (balance - 2 >= 0)
                            {
                            balance -= 2;
                                Console.WriteLine($"Purchased nuts");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Water":
                            if (balance - 0.7 >= 0)
                            {
                                balance -= 0.7;
                                Console.WriteLine($"Purchased water");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            
                            break;
                        case "Crisps":
                            if (balance - 1.5 >= 0)
                            {
                                balance -= 1.5;
                                Console.WriteLine($"Purchased crisps");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            
                            break;
                        case "Soda":
                            if (balance - 0.8 >= 0)
                            {
                                balance -= 0.8;
                                Console.WriteLine($"Purchased soda");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            
                            break;
                        case "Coke":
                            if (balance - 1 >= 0)
                            {
                                balance -= 1;
                                Console.WriteLine($"Purchased coke");
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }
                }
            }
            if (isEnd)
            {
                Console.WriteLine($"Change: {balance:f2}");
            }
        }
    }
}
