using System;
using System.Threading;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cardInside = false, done = false;

            int balance = 0, ammount = 0, rangeOfYears = 0;

            string stringOptions = "1. Deposit money\n2. Withdraw money\n3. Check balance\n4. Collect intrest\n5. Exit";
            string intOptions = "12345", rangeOfIntrest = "245";
            string choise = "";

            while (true)
            {
                Console.WriteLine("Welcome!\nWhat do you want to do?");
                Console.WriteLine(stringOptions);
                choise = Console.ReadLine();
                if (intOptions.Contains(choise) && choise.Length == 1)
                {
                    done = false;

                    int theChoise = Convert.ToInt32(choise);

                    switch (theChoise)
                    {
                        case 1:
                            while (!done)
                            {
                                Console.WriteLine("How much?");
                                try
                                {
                                    ammount = int.Parse(Console.ReadLine());
                                    if (ammount == 0)
                                        Console.WriteLine("You cant deposit 0 money.");
                                    else if (ammount > 0)
                                    {
                                        balance += ammount;
                                        done = !done;
                                        Console.WriteLine($"Your total balance is {balance}");
                                        Thread.Sleep(2000);
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Only digits is allowed");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                }
                            }
                            break;
                        case 2:
                            while (!done)
                            {
                                Console.WriteLine("How much?");
                                try
                                {
                                    ammount = int.Parse(Console.ReadLine());
                                    if (ammount == 0)
                                        Console.WriteLine("You cant wuithdraw 0 money.");
                                    else if (ammount < balance)
                                    {
                                        balance -= ammount;
                                        done = !done;
                                        Console.WriteLine($"Your total balance is {balance} and {ammount} will be withdrawn in a moment.");
                                        Thread.Sleep(2000);
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Only digits is allowed");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine($"Your balance is {balance}");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            while (!done)
                            {
                                Console.WriteLine("How many years would you like to skip?");
                                try
                                {
                                    ammount = int.Parse(Console.ReadLine());
                                    for (int i = 0; i < ammount; i++)
                                    {
                                        if (balance < 1001)
                                            balance *= 2;
                                        else if (balance < 5001)
                                            balance *= 3;
                                        else if (balance < 10001)
                                            balance *= 4;
                                        else
                                            balance *= 5;
                                        Thread.Sleep(1000);
                                    }
                                    Console.WriteLine($"Your total balance is {balance}");
                                    
                                }
                                catch
                                {
                                    Console.WriteLine("Only digits is allowed");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                }
                            }
                            break;
                        case 5:

                            break;
                        default:
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid option!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

            }
        }
    }
}
