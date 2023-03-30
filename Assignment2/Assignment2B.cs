/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        2B
*/


/*

Assignment 2B:
Fast-forwarding. A trick for getting through video lectures faster (especially if your instructor’s
voice is not the most entertaining) is to increase the playback speed. Common factors are 1.25,
1.50, and 2 times faster playback speeds. How much time could you save this way? In this
assignment, you’ll write a program to help you find out.
Prompt the user to enter the original video time as a floating point value (e.g. a two minute,
thirty second video should be entered as 2.30). Next, have the user enter the playback speed
factor, again as a floating point value (e.g. 1.25). You can assume the user will never enter a
value less than or equal to 0.
Once you have this information, you will need to convert the original time into seconds – in the
above example, two minutes and thirty seconds would be 150 seconds. Then use the factor to
determine what the new video time would be. Display the results in seconds. Note that you
*must* use an integer data type to store the new video time.
Hint: Remember casting. Also, what happens to the decimals when you convert a floating point
value to an integer? How could that help you with this assignment?
The algorithm output is as shown below, with user input in bold. Follow the output format
exactly. Save your source code in a file called Assignment2B (with a file extension of .cpp, .cs
or .java)
Sample Output #1:
[Fast-Forward]
What is the original video time? 2.30
What is the playback speed factor? 2

The new video time would be 75 second(s).
That saves you 75 second(s) from the original video speed.
Sample Output #2:
[Fast-Forward]
What is the original video time? 3.59
What is the playback speed factor? 1.75

The new video time would be 136 second(s).
That saves you 103 second(s) from the original video speed. 

*/

using System;

class Assignment2B
{
    static void Main(string[] args)
    {
        // Get some data from the user
        float origTime, speedFactor;
        
        Console.Write("[Fast-Forward]\r\nWhat is the original video time? ");
        origTime = float.Parse(Console.ReadLine());
        Console.Write("What is the playback speed factor? ");
        speedFactor = float.Parse(Console.ReadLine());

        int origTimeInSeconds = (int)origTime * 60; // this cast truncates the decimal portion and converts minutes to seconds
        origTime *= 100; // shift left by two places
        origTime %= 100; // get only the far right two places
        origTimeInSeconds += (int)origTime; // add original time seconds to timeInSeconds

        // implicitly cast origTimeInSeconds to float and divide. Then cast quotient to int, truncating decimal.
        int newTimeInSeconds = (int)(origTimeInSeconds / speedFactor);

        Console.WriteLine("\r\nThe new video time would be " + newTimeInSeconds + " second(s).");
        Console.WriteLine("That saves you " + (origTimeInSeconds - newTimeInSeconds) + " second(s) from the original video speed.");

    }
}

