/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:        8A
*/



using System;

class Lab8A
{
    static void Main(string[] args)
    {
        int[] firstArray = new int[5];
        int[] secondArray = new int[5];
        int[] sumArray = new int[5];

        Console.WriteLine("Please enter 5 integers for the first array:");

        for(int i = 0; i < 5; i++)
        {
            Console.Write("Integer {0}: ", i + 1);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nPlease enter 5 integers for the second array:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Integer {0}: ", i + 1);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < 5; i++)
        {
            sumArray[i] = firstArray[i] + secondArray[i];
        }

        Console.Write("\nThe resulting sums are ");
        for(int i = 0; i < 5; i++)
        {
            Console.Write("{0}|", sumArray[i]);
        }
        Console.WriteLine("");
    }
}