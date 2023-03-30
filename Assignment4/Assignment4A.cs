
/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        4A
*/


using System;

class Assignment4A
{
    static void Main(string[] args)
    {
        Console.WriteLine("What loop do you want to use?");
        Console.WriteLine("1) A loop that might run zero or more times");
        Console.WriteLine("2) A loop that will always run at least once");
        Console.WriteLine("3) A loop with a predetermined start and end");
        Console.Write("Your choice: ");
        int userChoice = int.Parse(Console.ReadLine());
        
        // The spec deosn't call for a bounds check on the user's input, but I implemented it anyways. ;)
        while(userChoice < 1 || userChoice > 3)
        {
            Console.WriteLine("Invalid choice.");
            Console.Write("Your choice: ");
            userChoice = int.Parse(Console.ReadLine());
        }

        Console.Write("What's your start number? ");
        int startNum = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                // while loop
                Console.Write("Counting: ");
                while(startNum >= 0)
                {
                    Console.Write("{0}, ", startNum--);
                }
                break;
            case 2:
                // do while loop
                Console.Write("Counting: ");
                do
                {
                    Console.Write("{0}, ", startNum--);
                } while (startNum >= 0);
                break;
            case 3:
                // for loop
                Console.Write("What's your end number? ");
                int endNum = int.Parse(Console.ReadLine());
                Console.Write("Counting: ");
                for (; startNum >= endNum; startNum--) 
                {
                    Console.Write("{0}, ", startNum);
                }
                break;
        }
        Console.WriteLine("");
    }
}

