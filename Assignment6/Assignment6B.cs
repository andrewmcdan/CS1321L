/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        6B
*/

using System;

class Assignment6B
{
    static void Main(string[] args)
    {
        // stopwatch code from https://www.tutorialsteacher.com/articles/how-to-calculate-code-execution-time-in-csharp
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();


        int[] theArray = new int[17];
        Random randy = new Random();
        for(int i = 0; i < theArray.Length; i++)
        {
            theArray[i] = randy.Next(1, 360);
        }

        int attemptsCount = 0;
        int attemptsCount2 = 0;
        

        Console.WriteLine("[Random Sort]\n");
        while(!checkIfSorted(theArray))
        {
            attemptsCount++;
            if (attemptsCount == int.MaxValue)
            {
                attemptsCount = 0;
                attemptsCount2++;
            }
            //Console.WriteLine("Printing array...");
            //PrintArray(theArray);
            //Console.WriteLine("\nNot sorted yet!\n");
            //Console.WriteLine("Shuffling array...\n");
            theArray = shuffleArray(theArray);
        }

        watch.Stop();
        Console.WriteLine("Hooray, it’s sorted! And it only took {0} attempts ({1}) and {2} seconds!", attemptsCount, attemptsCount2, watch.ElapsedMilliseconds / 1000);

    }

    public static bool checkIfSorted(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1]) return false;
        }
        return true;
    }

    public static int[] shuffleArray(int[] arr)
    {
        // Shuffle the array by swapping each value in the array with a random value in the array. 
        // Do this arr.Length times for good measure
        Random randy = new Random();
        for(int s = 0; s < arr.Length; s++)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int randomPosition = randy.Next(arr.Length);
                int temp = arr[randomPosition];
                arr[randomPosition] = arr[i];
                arr[i] = temp;
            }
        }
        return arr;
    }

    public static void PrintArray(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0}, ", arr[i]);
        }
    }
}