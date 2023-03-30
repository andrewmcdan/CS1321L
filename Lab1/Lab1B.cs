/*
Class:      CSE 1321L
Section:    W2
Term:       Spring 2023
Instructor: Joe Tierno
Name:       Andrew McDaniel
Lab#:       1B
*/

using System;
// Program Lab1B.cs
// Demonstrate reading a string from the user.
public class Lab1B
{
    // Reads a character string from the user and prints it.
    public static void Main(String[] args)
    {
        String message;
        Console.Write("Enter a line of text: ");
        message = Console.ReadLine();
        Console.WriteLine("You wrote '" + message + "'");
    }
}