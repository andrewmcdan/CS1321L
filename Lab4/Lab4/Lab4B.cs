/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               4B
*/


using System;


public class Lab4B
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the day: ");
        string theDay = Console.ReadLine();

        if(theDay.Equals("Monday") || theDay.Equals("monday") || theDay.Equals("Wednesday") || theDay.Equals("wednesday"))
        {
            Console.WriteLine("I have class today!");
        }
        else if(theDay.Equals("Friday") || theDay.Equals("friday"))
        {
            Console.WriteLine("It's Friday! Friday! Gotta get down on Friday!");
        }
        else
        {
            Console.WriteLine("I should use this time to do my homework.");
        }
    }
}
