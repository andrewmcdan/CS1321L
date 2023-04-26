/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               11B
*/

using System;

class Lab11B
{
    static void Main(string[] args)
    {
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();
        
        bool hasUpper = !password.Equals(password.ToLower());
        bool is8orLonger = password.Length >= 8;
                
        bool hasDigit = false;
        foreach(char character in password)
            if (character >= 48 && character <= 57) 
                hasDigit = true;

        if (hasUpper && is8orLonger && hasDigit)
        {
            Console.WriteLine("Valid password");
        }
        else
        {
            Console.WriteLine("Invalid password");
        }
        Console.WriteLine();
        Console.WriteLine("Program Ends");
    }        
}
