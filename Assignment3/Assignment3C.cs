/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        3C
*/

using System;

class Assignment3C
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Cretaceous Park Dialog]");
        Console.WriteLine("Oh no, the power has gone out at Cretaceous Park!");
        Console.WriteLine("1) What does that mean?");
        Console.WriteLine("2) No, I just turned the light off.");

        string response = Console.ReadLine();

        if(response.Equals("No, I just turned the light off."))
        {
            Console.WriteLine("Oh thank goodness!");
        }
        else if(response.Equals("What does that mean?"))
        {
            Console.WriteLine("\nThe dinosaurs will get loose... again...");
            Console.WriteLine("1) Life finds a way...");
            Console.WriteLine("2) What do we do?");

            response = Console.ReadLine();
            Console.WriteLine("\n");
            if (response.Equals("Life finds a way..."))
            {
                Console.WriteLine("That's not helpful right now!");
            }
            // the specification states that we don't need to worry about
            // invalid input (implying that user input will ALWAYS be valid),
            // and so no ELSE statemment is needed. 
            Console.WriteLine("We have to evacuate the park!");
        }
    }
}

