
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
        Console.Title = "Lets draw a triangle... for some reason.";
        System.Console.ForegroundColor = ConsoleColor.Black;
        System.Console.BackgroundColor = ConsoleColor.Cyan;
        System.Console.Clear();
        System.Console.SetCursorPosition(0, Console.WindowHeight / 2 - 10);

        
        System.Console.Write("Please enter a value for the size: ");
        int sizeVal = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("This is the requested {0}x{0} right-triangle:", sizeVal);
        for (int i = 0; i < sizeVal; i++, System.Console.WriteLine(""))
        {
            for(int k = 0; k < sizeVal - i - 1; k++, System.Console.Write(" ")){}
            for(int j = 0; j <= i; j++, System.Console.Write("*")){}
        }
    }
}