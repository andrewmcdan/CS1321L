/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        6A
*/

using System;

class Assignment6A
{
    static void Main(string[] args)
    {
        int[] bigArray = new int[1000019];

        for (int c = 0, i = bigArray.Length - 1; i >= 0; i--, c++)
        {
            bigArray[i] = c;
        }

        Random randy = new Random();
        int aRandomNum = randy.Next(bigArray.Length - 1);

        int linearCount = 0;
        int binaryCount = 0;

        Console.WriteLine("[Linear Vs. Binary Search]");
        Console.WriteLine("The target value is {0}", aRandomNum);

        bool found = false;

        for (int i = bigArray.Length - 1; i >= 0; i--)
        {
            linearCount++;
            if (bigArray[i] == aRandomNum)
            {
                found = true;
                break;
            }
        }

        if (found) Console.WriteLine("Linear Search: {0} loop(s)", linearCount);

        found = false;
        int low = bigArray.Length - 1, mid, high = 0;

        while (high <= low)
        {
            binaryCount++;
            mid = (low + high) / 2;
            if (aRandomNum < bigArray[mid])
            {
                high = mid + 1;
            }
            else if (aRandomNum == bigArray[mid])
            {
                found = true;
                break;
            }
            else low = mid - 1;
        }

        if (found) Console.WriteLine("Binary Search: {0} guess(es)", binaryCount);

        if (linearCount < binaryCount)
        {
            Console.WriteLine("Linear Search is faster this time!");
        }
        else if (binaryCount < linearCount)
        {
            Console.WriteLine("Binary Search is faster this time!");
        }
        else
        {
            Console.WriteLine("It was a tie this time!");
        }
    }
}