/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               8B
*/



using System;

class Lab8B
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the number of rows: ");
        int numRows = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of columns: ");
        int numCols = int.Parse(Console.ReadLine());

        Console.WriteLine("\nI have {0} rows and {1} columns. I need to fill-up {2} spaces.\n", numRows, numCols, numRows * numCols);
        Console.WriteLine("");
        Console.WriteLine("The {0}x{1} array:", numRows, numCols);

        int[,] userArray = new int[numRows, numCols];

        for (int counter = 1, row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                userArray[row, col] = counter++;
            }
        }

        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                Console.Write("{0}|", userArray[row, col]);
            }
            Console.WriteLine("");
        }
    }
}