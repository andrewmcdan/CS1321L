/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        6C
*/

using System;

class Assignment6C
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Overloaded Surprise Function]");
        Console.Write("What data type do you want to enter? ");
        string type = Console.ReadLine();
        Console.Write("Value #1: ");
        string value1 = Console.ReadLine();
        Console.Write("Value #2: ");
        string value2 = Console.ReadLine();
        Console.WriteLine("Calling surprise_function()...");
        Console.Write("The result is ");
        switch (type)
        {
            case "int":
                int intResult = surprise_function(int.Parse(value1), int.Parse(value2));
                Console.WriteLine("{0}",intResult);
                break;
            case "float":
                float floatResult = surprise_function(float.Parse(value1), float.Parse(value2));
                Console.WriteLine("{0}", floatResult);
                break;
            case "double":
                double doubleResult = surprise_function(double.Parse(value1), double.Parse(value2));
                Console.WriteLine("{0}", doubleResult);
                break;
            case "char":
                string charResult = surprise_function(char.Parse(value1), char.Parse(value2));
                Console.WriteLine(charResult);
                break;
            case "boolean":
                bool boolResult = surprise_function(value1.Equals("true"), value2.Equals("true"));
                Console.WriteLine(boolResult?"true":"false");
                break;
        }

    }

    public static int surprise_function(int x, int y)
    {
        return x + y;
    }

    public static float surprise_function(float x, float y)
    {
        return x / y;
    }

    public static double surprise_function(double x, double y)
    {
        return x % y;
    }

    public static string surprise_function(char x, char y)
    {
        return string.Concat(x,y);
    }

    public static bool surprise_function(bool x, bool y)
    {
        return x && y;
    }
}