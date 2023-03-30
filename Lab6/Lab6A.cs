/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               6A
*/

using System;

class Lab6A
{
    static void Main(string[] args)
    {
        int largest = 0;
        Console.WriteLine("Please enter 10 numbers and this program will display the largest.\n");
        for(int i = 1; i <= 10; i++)
        {
            Console.Write("Please enter number {0}:", i);
            int userInput = int.Parse(Console.ReadLine());
            if (userInput > largest) largest = userInput;
        }
        Console.WriteLine("\nThe largest number was {0}", largest);
    }
}

