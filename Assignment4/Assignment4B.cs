
/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        4B
*/


using System;

class Assignment4B
{
    static void Main(string[] args)
    {

        /// The logic here assumes that the square must be at least 1x1 and the border can be 0 or more.

        Console.Write("Enter the size of the square: ");
        int squareSize = int.Parse(Console.ReadLine());
        while (squareSize < 1)
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter the size of the square: ");
            squareSize = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the size of the border: ");
        int borderSize = int.Parse(Console.ReadLine());
        while (borderSize < 0)
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter the size of the border: ");
            borderSize = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the color of the square: ");
        int squareColor = int.Parse(Console.ReadLine());
        while (squareColor > 1 ||  squareColor < 0)
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter the color of the square: ");
            squareColor = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the color of the border: ");
        int borderColor = int.Parse(Console.ReadLine());
        while (borderColor < 0 || borderColor > 1)
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter the color of the border: ");
            borderColor = int.Parse(Console.ReadLine());
        }

        int totalSize = borderSize * 2 + squareSize;

        Console.WriteLine("PBM File Contents:");
        Console.WriteLine("P1");
        Console.WriteLine("{0} {0}", totalSize);


        // first print the top border
        for(int i = 0; i < borderSize; i++)
        {
            for(int j = 0; j < totalSize; j++)
            {
                Console.Write("{0}", borderColor);
            }
            Console.WriteLine("");
        }

        // now print the middle lines
        for(int i = 0; i < squareSize; i++)
        {
            // print the border
            for(int j = 0; j < borderSize; j++)
            {
                Console.Write("{0}", borderColor);
            }
            // print the square
            for (int j = 0; j < squareSize; j++)
            {
                Console.Write("{0}", squareColor);
            }
            // print the border
            for (int j = 0; j < borderSize; j++)
            {
                Console.Write("{0}", borderColor);
            }
            Console.WriteLine("");
        }

        // last print the bottom border
        for (int i = 0; i < borderSize; i++)
        {
            for (int j = 0; j < totalSize; j++)
            {
                Console.Write("{0}", borderColor);
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");


    }
}

