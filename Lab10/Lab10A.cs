/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               10A
*/

using System;

class Lab10A
{
    static void Main(string[] args)
    {
        Console.Write("Enter number 1: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("Min is {0}", min(numberOne, numberTwo));
        Console.WriteLine("Max is {0}", max(numberOne, numberTwo));
        Console.WriteLine("Average is {0}", average(numberOne, numberTwo));
    }

    public static int max(int x, int y)
    {
        return x > y ? x : y;
    }

    public static int min(int x, int y)
    {
        return x < y ? x : y;
    }

    public static float average(int x, int y)
    {
        return (x + y) / 2f;
    }
}
