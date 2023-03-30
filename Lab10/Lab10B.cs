/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               10B
*/

using System;

class Lab10B
{
    static void Main(string[] args)
    {
        String rerun = "Y";
        double width = 0, height = 0;
        while (rerun.Equals("Y"))
        {
            Console.Write("Enter width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = double.Parse(Console.ReadLine());
            if (isValid(width, height))
            {
                Console.WriteLine("This is a valid rectangle");
                //Console.WriteLine("The area is: {0:0.0}", area(width, height));
                Console.WriteLine("The area is: " + area(width, height));
                //Console.WriteLine("The perimeter is: {0:0.0}", perimeter(width, height));
                Console.WriteLine("The perimeter is: " + perimeter(width, height));
            }
            else
            {
                Console.WriteLine("This is an invalid rectangle");
            }
            Console.WriteLine();
            Console.Write("Do you want to enter another width and height (Y/N)? : ");
            rerun = Console.ReadLine().ToUpper();
            Console.WriteLine();
        }
        Console.WriteLine("Program Ends");
    }

    public static bool isValid(double width, double height)
    {
        return width + height > 30;
    }

    public static double area(double width, double height)
    {
        return width * height;
    }

    public static double perimeter(double width, double height)
    {
        return width * 2 + height * 2;
    }

}
