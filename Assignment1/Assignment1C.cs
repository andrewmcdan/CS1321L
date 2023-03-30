/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        1C
*/


/*

Enter the day (number): 9
Enter the month (number): 1
Enter the month (String): January
Enter the year (number): 2023
Here are some ways to represent the date:
1/9/2023
2023/9/1
9/1/2023
January 1, 2023
1 January 2023


*/

using System;

class Assignment1C
{
    static void Main(string[] args)
    {
        // some variables to hold user input
        int dayNum;
        int monthNum;
        String monthString;
        int yearNum;

        // Start getting user input
        Console.Write("Enter the day (number): ");
        dayNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enther the month (number): ");
        monthNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the month (String):");
        monthString = Console.ReadLine();
        Console.Write("Enter the year (number):");
        yearNum = Convert.ToInt32(Console.ReadLine());

        // Print some useful formatted strings to the user
        Console.WriteLine("Here are some ways to represent the date:");
        Console.WriteLine(monthNum + "/" + dayNum + "/" + yearNum);
        Console.WriteLine(yearNum + "/" + monthNum + "/" + dayNum);
        Console.WriteLine(dayNum + "/" + monthNum + "/" + yearNum);
        Console.WriteLine(monthString + " " + dayNum + ", " + yearNum);
        Console.WriteLine(dayNum + " " + monthString + " " + yearNum);

    }

}