/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               4B
*/


using System;


public class Lab4C
{
    public static void Main(string[] args)
    {
        Console.Write("Welcome!\nPlease input a number: ");
        float theNum = float.Parse(Console.ReadLine());

        Console.WriteLine("\nWhat would you like to do to this number:");
        Console.WriteLine("0) Get the additive inverse of the number");
        Console.WriteLine("1) Get the reciprocal of the number");
        Console.WriteLine("2) Square the number");
        Console.WriteLine("3) Cube the number");
        Console.WriteLine("4) Exit the program\n");

        int response = Convert.ToInt32(Console.ReadLine());

        switch (response)
        {
            case 0:
                float inv = -theNum;
                Console.WriteLine("The additive inverse of " + theNum + " is " + inv);
                break;
            case 1:
                float recip = 1 / theNum;
                Console.WriteLine("The reciprocal of " + theNum + " is " + recip);
                break;
            case 2:
                float sq = theNum * theNum;
                Console.WriteLine("The square of {0:0.0} is {1:0.0}",theNum, sq);
                break;
            case 3:
                float cube = theNum * theNum * theNum;
                Console.WriteLine("The cube of {0:0.0} is {1:0.0}",theNum, cube);
                break;
            case 4:
                Console.WriteLine("Thank you, goodbye!");
                break;
            default:
                Console.WriteLine("Invalid input, please try again!");
                break;
        }
    }
}
