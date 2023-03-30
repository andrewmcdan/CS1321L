
/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               7C
*/


using System;

class Lab7C
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a value for the size: ");
        int sizeVal = int.Parse(Console.ReadLine());
        Console.WriteLine("This is the requested {0}x{0} right-triangle:", sizeVal);
        for (int i = 0; i < sizeVal; i++)
        {
            for(int k = 0; k < sizeVal - i - 1; k++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}