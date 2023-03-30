/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        2C
*/


/*

Assignment 2C:
Useful Conversions: We are familiar with converting information from one format to another.
For example, in lecture we learned how to convert temperature from Fahrenheit to Celsius. For
this assignment, you will use constants to develop equally useful conversion tools.
You will build a program that asks users for a number in meters. You will then calculate how
far that is in the following units of measure:
• Distance to the Moon
• Animal Crackers
Refer to the sample output to see the conversion rates. You will use constants to store the
conversion rate – points will be deducted if you do not use those constants in the program
calculations.
The algorithm output is as shown below, with user input in bold. Follow the output format
exactly. Save your source code in a file called Assignment2C (with a file extension of .cpp, .cs
or .java)
Sample Output #1:
[Distance Calculator]
How many meters? 1

1 meter(s) is...
...0.0000000026 distance from the Moon
...40 Animal Crackers long
Sample Output #2:
[Distance Calculator]
How many meters? 30.2

30.2 meter(s) is...
...0.000000079 distance from the Moon
...1208 Animal Crackers long

 
*/

using System;

class Assignment2C
{
    static void Main(string[] args)
    {
        const float MOON_CONVERSION = 0.0000000026f;
        const float ANIMAL_CRACKER_CONVERSION = 40.0f;

        Console.Write("[Distance Calculator]\r\nHow many meters? ");
        float meters = float.Parse(Console.ReadLine());

        float distanceFromMoon = meters * MOON_CONVERSION;
        float numberOfAnimalCrackers = meters * ANIMAL_CRACKER_CONVERSION;

        Console.WriteLine("\r\n" + meters + " meter(s) is...");
        Console.WriteLine("..." + (decimal)distanceFromMoon + " distance from the Moon"); // cast distanceFromMoon to decimal to make it print 0.00000....
        Console.WriteLine("..." + numberOfAnimalCrackers + " Animal Crackers long");
    }
}

