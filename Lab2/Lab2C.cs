/*
Class:       CSE 1321L
Section:     W2
Term:        Spring 2023
Instructor:  Joe Tierno
Name:        Andrew McDaniel
Lab#:        2C
*/


/*

Lab2C: For this assignment, create a program that will read in a width and height from the user and
calculates the area and perimeter of a rectangle. The formula for perimeter is P = 2*(height+width)
and the formula for area is A = (height*width). Format the outputs following this sample run. User
input is in bold. Both the class and filename should be called Lab2C (.java, .cs,
.cpp).
Sample run:
Enter a width: 4
Enter a height: 8
The area is 32
The perimeter is 24 

*/


using System;

class Lab2C
{
    static void Main(string[] args)
    {
        int width, height;
        
        Console.Write("Enter a width: ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a height: ");
        height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The area is " + (width * height));
        Console.WriteLine("The perimeter is " + (2 * (height + width)));
    }
}
