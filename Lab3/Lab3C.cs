/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               3C
*/

/*

Lab3C: Coins. We are going to design a program that determines the values of coins in a jar. The program will
prompt the user to enter the number coins (i.e. quarters, dimes, nickels, and pennies). It will then print out the
number of coins entered for each coin type on separate lines and calculates the total amount of money in the
jar. An example run is shown below. The user input is in bold. 

Enter the number of quarters: 2
Enter the number of dimes: 2
Enter the number of nickels: 2
Enter the number of pennies: 2
You entered 2 quarters.
You entered 2 dimes.
You entered 2 nickels.
You entered 2 pennies.
Your total is 0 dollars and 82 cents.

*/


using System;

class Lab3C
{
    public static void Main(string[] args)
    {
        // create some variables for the data
        int quarters, dimes, nickels, pennies;

        // get data from the user
        Console.Write("Enter the number of quarters: ");
        quarters = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of dimes: ");
        dimes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of nickels: ");
        nickels = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of pennies: ");
        pennies = Convert.ToInt32(Console.ReadLine());

        // parrot the data back to the user because the specification ask us to
        Console.WriteLine("You entered " + quarters + " quarters.");
        Console.WriteLine("You entered " + dimes + " dimes.");
        Console.WriteLine("You entered " + nickels + " nickels.");
        Console.WriteLine("You entered " + pennies + " pennies.");

        // calculate some stuff
        int totalCents = quarters * 25 + dimes * 10 + nickels * 5 + pennies;
        int dollars = totalCents / 100; // this will truncate the decimal portion leaving only whole dollars
        int remainingCents = totalCents % 100;

        // tell the user their total
        Console.WriteLine("Your total is " + dollars + " dollars and " + remainingCents + " cents.");
    }
}