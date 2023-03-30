
/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               7A
*/


using System;

class Lab7A
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a value for the size: ");
        int squareSize = int.Parse(Console.ReadLine());
        Console.WriteLine("This is the requested " + squareSize + "x" + squareSize + " box:");

        for(int i = 0; i < squareSize; i++)
        {
            for(int j = 0; j < squareSize; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}