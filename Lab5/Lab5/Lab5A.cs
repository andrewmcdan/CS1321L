/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               5A
*/



using System;

class Lab5A
{
    public static void Main(string[] args)
    {
        char response;
        Console.Write("Do you have a driving permit (Y/N)? ");
        response = char.Parse(Console.ReadLine());
        if(response.Equals('Y') || response.Equals('y'))
        {
            Console.Write("Do you have a commercial driving license (Y/N)? ");
            response = char.Parse(Console.ReadLine());
            if(response.Equals('Y') || response.Equals('y'))
            {
                Console.WriteLine("Congratulations! You can purchase a vehicle, let’s start talking options!");
            }
            else if (response.Equals('N') || response.Equals('n'))
            {
                Console.WriteLine("Commercial driving license is a prerequisite to purchase a vehicle!");
            }
            else
            {
                Console.WriteLine("Invalid input. ");
            }
        }
        else if (response.Equals('N') || response.Equals('n'))
        {
            Console.WriteLine("Driving permit is a prerequisite to purchase a vehicle!");
        }
        else
        {
            Console.WriteLine("Invalid input. ");
        }
    }
}