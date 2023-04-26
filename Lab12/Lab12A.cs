/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               12A
*/

using System;

class Lab12A
{
    static void Main(string[] args)
    {
        Console.WriteLine("You are about to create a chair.");
        Console.Write("How many legs does your chair have: ");
        int legs = int.Parse(Console.ReadLine());
        Console.Write("Is your chair rolling (true/false): ");
        bool roller = Console.ReadLine().ToLower().Equals("true");
        Console.Write("What is your chair made of: ");
        String material = Console.ReadLine();

        Chair myChair = new Chair(legs, roller, material);

        Console.WriteLine();
        Console.WriteLine("Your chair has {0} legs, is " + (myChair.rolling ? "" : "not ") + "rolling, and is made of {1}.", myChair.numOfLegs, myChair.material);
        Console.WriteLine();
        Console.WriteLine("This program is going to change that.");
        Console.WriteLine();
        myChair.numOfLegs = 4;
        myChair.rolling = false;
        myChair.material = "wood";
        Console.WriteLine("Your chair has {0} legs, is " + (myChair.rolling ? "" : "not ") + "rolling, and is made of {1}.", myChair.numOfLegs, myChair.material);
    }
}

class Chair
{
    public int numOfLegs;        //how many legs are on the chair
    public bool rolling;         //does it roll or not
    public String material;      //what is the chair made of 

    public Chair(int legs, bool roll, String mat)
    {
        this.numOfLegs = legs;
        this.rolling = roll;
        this.material = mat;
    }
}