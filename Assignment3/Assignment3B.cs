/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        3B
*/

using System;

class Assignment3B
{
    static void Main(string[] args)
    {
        // introduce program to user and get some data
        Console.WriteLine("[Image Encoding Checker]");
        Console.Write("What is the image width? ");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the image height? ");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the file size (in bytes)? ");
        int numBytes = Convert.ToInt32(Console.ReadLine());

        // bounds check
        if (width < 1 || height < 1 || numBytes < 1)
        {
            Console.WriteLine("The information is invalid - please re-enter it.");
        }
        else
        {
            int bytesPerPixel = numBytes / (width * height);
            switch (bytesPerPixel)
            {
                case 3:
                    Console.WriteLine("\r\nThe RGB image is encoded with 8 bits per channel.");
                    break;
                case 6:
                    Console.WriteLine("\r\nThe RGB image is encoded with 16 bits per channel.");
                    break;
                /* 
                // Uncomment to enable 24bpc detection
                case 9:
                    Console.WriteLine("\r\nThe RGB image is encoded with 24 bits per channel.");
                    break;
                */
                case 12:
                    Console.WriteLine("\r\nThe RGB image is encoded with 32 bits per channel.");
                    break;
                default:
                    Console.WriteLine("The information is invalid - please re-enter it.");
                    break;
            }
        }
    }
}

