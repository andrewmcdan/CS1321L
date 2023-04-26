/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               11A
*/

using System;

class Lab11A
{
    static void Main(string[] args)
    {
        string answer = "no";
        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("0) Hello World");
            Console.WriteLine("1) Goodbye Moon");
            Console.WriteLine("2) Walking on Sunshine");
            Console.WriteLine();
            Console.Write("What would you like to do: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Hello!");
                    break;
                case 1:
                    Console.WriteLine("Ok, bye.");
                    break;
                case 2:
                    Console.WriteLine("WHOA!");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.WriteLine();
            Console.Write("Type YES to rerun. ");
            answer = Console.ReadLine();
            Console.WriteLine();
        } while (isYes(answer));
        Console.WriteLine("Program Ends");
    }

    public static bool isYes(string s)
    {
        return s.ToLower().Equals("yes");
    }
}


