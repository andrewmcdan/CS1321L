/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        1B
*/


/*

What're you buying? Ice Cream
How many? 2
What do they cost? 2.25
What else're you buying? Celery
How many? 5
What do they cost? 1.74
Your list:
----
Ice Cream (2)
$2.25 ($5.50 total)     /// this is poor arithmetic
Celery (5)
$1.74 ($8.7 total)
Total Cost: $14.2       /// incorrect
----

*/

using System;

class Assignment1B
{
    static void Main(string[] args)
    {
        // set up some variables to hold data from user
        String itemOneName;
        String itemTwoName;
        int numItemOne = 0;
        int numItemTwo = 0;
        float costItemOne = 0.0f;
        float costItemTwo = 0.0f;

        // Get data about the first item from the user
        Console.Write("What're you buying? ");
        itemOneName = Console.ReadLine();
        Console.Write("How many? ");
        numItemOne = Convert.ToInt32(Console.ReadLine());
        Console.Write("What do they cost? ");
        costItemOne = (float)Convert.ToDouble(Console.ReadLine());

        // Get data about the second item from the user
        Console.Write("What else're you buying? ");
        itemTwoName = Console.ReadLine();
        Console.Write("How many? ");
        numItemTwo = Convert.ToInt32(Console.ReadLine());
        Console.Write("What do they cost? ");
        costItemTwo = (float)Convert.ToDouble(Console.ReadLine());


        // print the list
        Console.WriteLine("Your list:");
        Console.WriteLine("---");
        Console.WriteLine(itemOneName + " (" + numItemOne + ")");
        Console.WriteLine("$" + costItemOne + " ($" + (costItemOne * numItemOne) + " total)");
        Console.WriteLine(itemTwoName + " (" + numItemTwo + ")");
        Console.WriteLine("$" + costItemTwo + " ($" + (costItemTwo * numItemTwo) + " total)");
        Console.WriteLine("Total Cost: $" + ((costItemOne * numItemOne) + (costItemTwo * numItemTwo)));
        Console.WriteLine("---");
    }

}