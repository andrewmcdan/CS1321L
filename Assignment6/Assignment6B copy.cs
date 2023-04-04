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
    // make the RNG available to all member functions so that we don't waste time declaring a new one on each shuffle call. This makes for a much speedier program.
    static Random randy = new Random();

    static void Main(string[] args)
    {
        // stopwatch code from https://www.tutorialsteacher.com/articles/how-to-calculate-code-execution-time-in-csharp
        var watch = new System.Diagnostics.Stopwatch();
        
        int[] theArray = new int[13];
        //Random randy = new Random();
        for(int i = 0; i < theArray.Length; i++)
        {
            theArray[i] = randy.Next(1, 360);
        }

        uint attemptsCount = 0;
        uint attemptsCount2 = 0;
        
        Console.WriteLine("[Random Sort]\n");
        
        watch.Start();
        while (!checkIfSorted(theArray))
        {
            attemptsCount++;
            if (attemptsCount == uint.MaxValue)
            {
                attemptsCount2++; // Not that it matters, but lets track how many times attemptsCount maxes out an unsigned Int. Since this is more than 4 billion iterations, I doubt anyone would let this run long enough to get here.
            }
            //Console.WriteLine("Printing array...");
            //PrintArray(theArray);
            //Console.WriteLine("\nNot sorted yet!\n");
            //Console.WriteLine("Shuffling array...\n");
            theArray = shuffleArray(theArray);
        }
        watch.Stop();

        Console.WriteLine("Printing array...");
        PrintArray(theArray);
        
        Console.WriteLine("\n\nHooray, it’s sorted! And it only took {0} attempts and {1} seconds!", attemptsCount, watch.ElapsedMilliseconds / 1000f);
        if (attemptsCount2 > 0) Console.WriteLine("Also, it took so long, the attemptCount variable rolled over {0} time(s)!", attemptsCount2);
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
        
        // Shuffle the array by repeatedly swapping two random values in the array. 
        // Do this arr.Length / 2 times and the array should be sufficiently shuffled
        // since each iteration touches two positions. This may not touch all positions
        // on each iteration, but it's fast.
        //Random randy = new Random();
        
        //var watch = new System.Diagnostics.Stopwatch();
        //watch.Start();
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int randomPosition = randy.Next(arr.Length);
            int randomPosition2 = randy.Next(arr.Length);
            int temp = arr[randomPosition];
            arr[randomPosition] = arr[randomPosition2];
            arr[randomPosition2] = temp;
        }
        //watch.Stop();
        //Console.WriteLine(watch.ElapsedTicks);
        
        return arr; // Use the first algorithm. Ignore the rest of this function.


        // the assignment sheet seemed to suggest doing something like this:

        // create a new array of the same size and fill it with -1
        // this will let us keep track of which positions in the array have been filled
        
        //watch.Reset();
        //watch.Start();
        int[] newArr = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++)
        {
            newArr[i] = -1;
        }

        for(int i = 0; i < arr.Length; i++)
        {
            // first find a random position in the new array that hasn't been assigned a value
            int randomPos = randy.Next(newArr.Length);
            while (newArr[randomPos] != -1)
            {
                randomPos = randy.Next(newArr.Length);
            }
            // then assign that location the next value
            newArr[randomPos] = arr[i];
        }
        //watch.Stop();
        //Console.WriteLine(watch.ElapsedTicks);
        
        return newArr;

        // Advantage of the first algorithm is that it is reasonably fast. And it takes a predictable amount of time to complete.
        // The disadvantage is that is may leave one or more values in their original positions. Technically, that's random for ya.

        // Advantage of the second algorithm is that it definitely touches every position in the original array. Although, it could
        // still put those values in their original position. 
        // The major disadvantage of this one is the fact that it uses an RNG. It could theoretically never finish shuffling if
        // the RNG always picks positions that are taken.
    }

    public static void PrintArray(int[] arr)
    {
        foreach(int i in arr) Console.Write("{0}, ", i);
    }
}