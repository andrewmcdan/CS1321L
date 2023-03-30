/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        1A
*/



/*

Your task is to:
a) Ask the user to individually enter in three values between 0 to 255
b) Read those three values in
Don’t worry about handling values outside that range – we’ll learn how to do that
later in the semester
c) Invert each number
d) Display the results
e) Convert the inverted colors to floating point numbers
f) Display those results
You do not need to match the number of decimals precisely, as long as the answer is
correct. Again, we’ll learn how to do that later.
The algorithm output is as shown below, with user input in bold. Save your source code in a
file called Assignment1A (with a file extension of .cpp, .cs or .java)
Sample Output:
Enter a red value (0-255): 101
Enter a green value (0-255): 67
Enter a blue value (0-255): 33
The inverted color is red=154, green=188, blue=222
With floating points, that would be red=0.6015, green=0.7344,
blue=0.8672

*/

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

class Assignment1A
{
    static void Main(string[] args)
    {
        // set up some variables
        int redVal = 0;
        int greenVal = 0;
        int blueVal = 0;

        int redInv = 0;
        int greenInv = 0;
        int blueInv = 0;

        // Get values from the user
        Console.Write("Enter a red value (0-255): ");
        redVal = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a green value (0-255): ");
        greenVal = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a blue value (0-255): ");
        blueVal = Convert.ToInt32(Console.ReadLine());

        // calculate uinverted values and store
        redInv = 255 - redVal;
        greenInv = 255 - greenVal;
        blueInv = 255 - blueVal;

        // print inverted values
        Console.Write("The inverted color is red=");
        Console.Write(redInv);
        Console.Write(", green=");
        Console.Write(greenInv);
        Console.Write(", blue=");
        Console.WriteLine(blueInv);

        // calculate and store floats
        double redFloat = redInv / 255.0;
        double greenFloat = greenInv / 255.0;
        double blueFloat = blueInv / 255.0;

        // print floats
        Console.WriteLine("With floating points, that would be red=" + redFloat + ", green=" + greenFloat + ", blue=" + blueFloat);
    }
}