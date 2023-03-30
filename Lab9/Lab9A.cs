/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               9A
*/


using System;

class Lab9A
{
    static void Main(string[] args)
    {
        int[] theInts_arr = new int[10];

        Console.WriteLine("Please enter 10 numbers:");

        for(int i = 0; i < theInts_arr.Length; i++)
        {
            Console.Write("Integer {0}: ", i + 1);
            theInts_arr[i] = int.Parse(Console.ReadLine());
            
            while(theInts_arr[i] > 100 || theInts_arr[i] < -100)
            {
                Console.WriteLine("Out of range! -100 to 100, please.");
                Console.Write("Integer {0}: ", i + 1);
                theInts_arr[i] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.Write("What is the target number: ");
        int target = int.Parse(Console.ReadLine());

        bool found = false;

        for(int i = 0; i < theInts_arr.Length; i++)
        {
            if (target == theInts_arr[i])
            {
                found = true;
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine("The target is " + (found ? "" : "not ") + "in the set.");


    }
}