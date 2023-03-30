/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               6B
*/

using System;

class Lab6B
{
    static void Main(string[] args)
    {
        Random randy = new Random();
        int userNumber = 0;

        while (userNumber < 1 || userNumber > 1000)
        {
            Console.Write("Enter a number between 1 and 1000: ");
            userNumber = int.Parse(Console.ReadLine());
        }

        int  myRand = 0, guessCount = 0;
        while (myRand != userNumber)
        {
            myRand = randy.Next(1000) + 1;
            Console.WriteLine("My guess was {0}", myRand);
            guessCount++;
        }

        Console.WriteLine("\nI guessed the number was {0} and it only took me {1} guesses", userNumber, guessCount);
        

    }
}

