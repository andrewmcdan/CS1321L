/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               5B
*/



using System;

class Lab5B
{
    public static void Main(string[] args)
    {
        // get an integer from the user
        int inputInt;
        Console.Write("Enter an integer: ");
        inputInt = int.Parse(Console.ReadLine());

        // cascade the divisibilty so that the lowest possible number gets used.
        int divisibleBy = inputInt % 5 == 0 ? 5 : 0;
        divisibleBy = inputInt % 3 == 0 ? 3 : divisibleBy;
        divisibleBy = inputInt % 2 == 0 ? 2 : divisibleBy;

        // inform the user
        switch (divisibleBy)
        {
            case 2:
                Console.WriteLine("This number is divisible by 2");
                break;
            case 3:
                Console.WriteLine("This number is divisible by 3");
                break;
            case 5:
                Console.WriteLine("This number is divisible by 5");
                break;
            default:
                Console.WriteLine("This number is undetermined");
                break;

        }
    }
}