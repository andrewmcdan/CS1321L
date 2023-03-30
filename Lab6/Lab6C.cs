/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               6C
*/

using System;

class Lab6C
{
    static void Main(string[] args)
    {
        int balance = 1000;
        Console.WriteLine("Welcome!");
        Console.WriteLine("You have ${0} in your account.", balance);

        string returnUserRes = "Y";
        do
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("0 - Make a deposit");
            Console.WriteLine("1 - Make a withdrawal");
            Console.WriteLine("2 - Display account value");
            Console.Write("\nPlease make a selection: ");
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 0:
                    Console.Write("How much would you like to deposit? : ");
                    int deposit = int.Parse(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine("Your current balance is ${0}", balance);
                    break;
                case 1:
                    Console.Write("How much would you like to withdraw? : ");
                    int withdraw = int.Parse(Console.ReadLine());
                    balance -= withdraw;
                    Console.WriteLine("Your current balance is ${0}", balance);
                    break;
                case 2:
                    Console.WriteLine("Your current balance is ${0}", balance);
                    break;
                default:
                    Console.WriteLine("Invalid entry, please try again.");
                    break;
            }
            Console.Write("Would you like to return to the main menu (Y/N)? : ");
            returnUserRes = Console.ReadLine();
        } while (returnUserRes.Equals("Y") || returnUserRes.Equals("y"));

        Console.WriteLine("\nThank you for banking with us!");
    }
}

