/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               9B
*/


using System;

class Lab9B
{
    static void Main(string[] args)
    {
        int[] theInts_arr = new int[11];

        Console.WriteLine("Please enter 11 numbers:");

        for (int i = 0; i < theInts_arr.Length; i++)
        {
            Console.Write("Integer {0}: ", i + 1);
            theInts_arr[i] = int.Parse(Console.ReadLine());

            while (theInts_arr[i] > 100 || theInts_arr[i] < -100)
            {
                Console.WriteLine("Out of range! -100 to 100, please.");
                Console.Write("Integer {0}: ", i + 1);
                theInts_arr[i] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.Write("What is the target number: ");
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < theInts_arr.Length - 1; i++)
        {
            for (int j = 0; j < theInts_arr.Length - i - 1; j++)
            {
                if (theInts_arr[j] > theInts_arr[j + 1])
                {// swap temp and arr[i]
                    int temp = theInts_arr[j];
                    theInts_arr[j] = theInts_arr[j + 1];
                    theInts_arr[j + 1] = temp;
                }
            }
        }

        Console.Write("The sorted set is: ");
        foreach(int el in theInts_arr) Console.Write("{0} ", el);
        Console.WriteLine();
        Console.WriteLine();

        int low = 0, mid = 0, high = theInts_arr.Length - 1;
        bool found = false;

        while (high >= low)
        {
            mid = (low + high) / 2;

            Console.WriteLine("Low is {0}", low);
            Console.WriteLine();
            Console.WriteLine("High is {0}", high);
            Console.WriteLine();
            Console.WriteLine("Mid is {0}", mid);
            Console.WriteLine();
            Console.WriteLine("Searching");
            Console.WriteLine();
            if (target < theInts_arr[mid])
            {
                high = mid - 1;
            }
            else if (target == theInts_arr[mid])
            {
                found = true;
                break;
            }
            else low = mid + 1;
        }

        Console.WriteLine("The target is " + (found ? "" : "not ") + "in the set.");
    }
}