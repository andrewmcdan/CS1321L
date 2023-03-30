/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               5C
*/



using System;

class Lab5C
{
    public static void Main(string[] args)
    {
        int x_coord = 0, y_coord = 0;
        Console.Write("Enter x: ");
        x_coord = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        y_coord = int.Parse(Console.ReadLine());

        if(x_coord == 0 && y_coord == 0)
        {
            Console.WriteLine("This point is the origin.");
        }
        else if(x_coord == 0)
        {
            Console.WriteLine("This point is on the y axis.");
        }
        else if (y_coord == 0)
        {
            Console.WriteLine("This point is on the x axis.");
        }
        else if(x_coord > 0 && y_coord > 0)
        {
            Console.WriteLine("This point is in the first quadrant.");
        }
        else if (x_coord < 0 && y_coord > 0)
        {
            Console.WriteLine("This point is in the second quadrant.");
        }
        else if (x_coord < 0 && y_coord < 0)
        {
            Console.WriteLine("This point is in the third quadrant.");
        }
        else if (x_coord > 0 && y_coord < 0)
        {
            Console.WriteLine("This point is in the fourth quadrant.");
        }
    }
}