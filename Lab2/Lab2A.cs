/*
Class:       CSE 1321L
Section:     W2
Term:        Spring 2023
Instructor:  Joe Tierno
Name:        Andrew McDaniel
Lab#:        2A
*/


/*

Lab2A: MadLibs. For this assignment, we’re going to code a MadLib. Your program should ask
the user for two names, a verb and an adverb. These responses will get plugged into a prewritten sentence. An example output is shown below. User input is denoted in bold. Both the class
and filename should be called Lab2A (.java, .cs, .cpp).

Sample run:
Enter a name: Tiffany
Enter another name: Bubba
Enter a verb: eat
Enter an adverb: wickedly
Once upon a time, there was a person named Tiffany who had a child named
Bubba. This child would eat wickedly while singing to strangers. 

*/
using System;

class Lab2A
{
    static void Main(string[] args)
    {
        string name1, name2, aVerb, anAdverb;

        Console.Write("Enter a name: ");
        name1 = Console.ReadLine();
        Console.Write("Enter another name: ");
        name2 = Console.ReadLine();
        Console.Write("Enter a verb: ");
        aVerb = Console.ReadLine();
        Console.Write("Enter an adverb: ");
        anAdverb = Console.ReadLine();

        Console.WriteLine("Once upon a time, there was a person named " + name1 + " who had a child named " + name2 + ". This child would " + aVerb + " " + anAdverb + " while singing to strangers.");
    }
}
