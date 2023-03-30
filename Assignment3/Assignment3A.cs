/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        3A
*/

using System;

class Assignment3A
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Cretaceous Park GIS]");
        Console.Write("X Coordinate: ");
        float x_coord = float.Parse(Console.ReadLine());
        Console.Write("Y Coordinate: ");
        float y_coord = float.Parse(Console.ReadLine());

        // first check to see if coordinate are within bounds
        if(x_coord > 8 || y_coord > 8 || x_coord < 0 || y_coord < 0)
        {
            Console.WriteLine("WARNING: You have left the boundaries of the park.\r\nPlease return immediately.");
        }
        else
        {
            if(x_coord >= 2 && x_coord <= 4 && y_coord >= 2 && y_coord <= 6) // check for T REX Lake
            {
                Console.WriteLine("You are at the T. Rex Lake");
            }
            else if(x_coord >= 5 && x_coord <= 8 && y_coord >=0 && y_coord <= 2) // check for Pterodactyl aviary
            {
                Console.WriteLine("You are at the Pterodactyl Aviary");
            }
            else if(x_coord >= 6 && x_coord <= 8 && y_coord > 2 && y_coord <= 4) // Visitor's center
            {
                Console.WriteLine("You are at the Visitor's Center");
            }
            else if (x_coord >= 6 && x_coord <= 8 && y_coord > 2 && y_coord <= 4) // Deinonychus Pen
            {
                Console.WriteLine("You are at the Deinonychus Pen");
            }
            else
            {
                Console.WriteLine("You are in the Triceratops Grasslands"); // Everywhere else
            }
        }

    }
}

