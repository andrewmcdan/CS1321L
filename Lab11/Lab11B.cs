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
        bool hasDigit = containsDigit(password);
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

    public static bool containsDigit(string s)
    {
        bool found = false;
        for(int i = 0; i <= 9; i++)
        {
            if(s.IndexOf(i.ToString()) != -1){
                found = true;
            }
        }
        return found;
    }
        
}
