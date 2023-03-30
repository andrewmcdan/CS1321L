/*
Class:              CSE 1321L
Section:            W#2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        5B
*/

using System;

class Assignment5B
{
    static void Main(string[] args)
    {
        int imageWidth = 0, imageHeight = 0, fillColor = 0, userChoice = -1;

        Console.WriteLine("[KSU Image Manipulation Program]");
        Console.Write("Enter an image width: ");
        imageWidth = int.Parse(Console.ReadLine());
        Console.Write("Enter an image height: ");
        imageHeight = int.Parse(Console.ReadLine());
        Console.Write("Enter the fill color: ");
        fillColor = int.Parse(Console.ReadLine());

        int[,] theImage = new int[imageWidth, imageHeight];

        for(int w = 0; w < imageWidth; w++)
        {
            for(int h = 0; h < imageHeight; h++)
            {
                theImage[w, h] = fillColor;
            }
        }

        while (userChoice != 4)
        {
            Console.WriteLine();
            Console.WriteLine("What will you do?");
            Console.WriteLine("1) Fill in a pixel");
            Console.WriteLine("2) Fill in a line");
            Console.WriteLine("3) Print the image");
            Console.WriteLine("4) Quit");

            Console.Write("Choice ? ");
            userChoice = int.Parse(Console.ReadLine());
            
            while(userChoice > 4 || userChoice < 1)
            {
                Console.WriteLine("Invalid Choice!");
                Console.Write("Choice ? ");
                userChoice = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            switch (userChoice)
            {
                case 1: // Fill in a pixel
                    {
                        bool validInfo = false;
                        int pixelRow = 0, pixelCol = 0, pixelColor = 0;
                        while (!validInfo)
                        {
                            Console.Write("Row: ");
                            pixelRow = int.Parse(Console.ReadLine());

                            Console.Write("Column: ");
                            pixelCol = int.Parse(Console.ReadLine());

                            Console.Write("New Color: ");
                            pixelColor = int.Parse(Console.ReadLine());
                            
                            if (pixelRow >= theImage.GetLength(1) || pixelCol >= theImage.GetLength(0) || pixelColor > 255) Console.WriteLine("Invalid information!");
                            else if (pixelRow < 0 || pixelCol < 0 || pixelColor < 0) Console.WriteLine("Invalid information!");
                            else validInfo = true;
                        }
                        theImage[pixelCol, pixelRow] = pixelColor;
                        break;
                    }
                case 2: // Fill in a line
                    {
                        bool validInfo = false;
                        int lineStartRow = 0, lineStartCol = 0, lineLength = 0, LineColor = 0;
                        String lineDir = "";
                        while (!validInfo)
                        {
                            Console.Write("Row: ");
                            lineStartRow = int.Parse(Console.ReadLine());

                            Console.Write("Column: ");
                            lineStartCol = int.Parse(Console.ReadLine());

                            Console.Write("New Color: ");
                            LineColor = int.Parse(Console.ReadLine());

                            Console.Write("Length: ");
                            lineLength = int.Parse(Console.ReadLine());

                            Console.Write("Direction: ");
                            lineDir = Console.ReadLine();

                            if (lineStartRow >= theImage.GetLength(1) || lineStartCol >= theImage.GetLength(0) || LineColor > 255) Console.WriteLine("Invalid information!");
                            else if(lineLength < 0 || lineStartRow < 0 || lineStartCol < 0 || LineColor < 0) Console.WriteLine("Invalid information!");
                            else
                            {
                                switch (lineDir)
                                {
                                    case "up":
                                        if (lineStartRow - lineLength < 0) lineLength = lineStartRow + 1;
                                        validInfo = true;
                                        break;
                                    case "down":
                                        if (lineStartRow + lineLength >= theImage.GetLength(1)) lineLength = theImage.GetLength(1) - lineStartRow;
                                        validInfo = true;
                                        break;
                                    case "left":
                                        if (lineStartCol - lineLength < 0) lineLength = lineStartCol + 1;
                                        validInfo = true;
                                        break;
                                    case "right":
                                        if (lineStartCol + lineLength >= theImage.GetLength(0)) lineLength = theImage.GetLength(0) - lineStartCol;
                                        validInfo = true;
                                        break;
                                    default:
                                        Console.WriteLine("Invalid information!");
                                        break;
                                }
                            }
                        }
                        switch (lineDir)
                        {
                            case "up":
                                for (int r = lineStartRow; r > lineStartRow - lineLength; r--)
                                {
                                    theImage[lineStartCol, r] = LineColor;
                                }
                                break;
                            case "down":
                                for (int r = lineStartRow; r < lineStartRow + lineLength; r++)
                                {
                                    theImage[lineStartCol, r] = LineColor;
                                }
                                break;
                            case "right":
                                for (int c = lineStartCol; c < lineStartCol + lineLength; c++)
                                {
                                    theImage[c, lineStartRow] = LineColor;
                                }
                                break;
                            case "left":
                                for (int c = lineStartCol; c > lineStartCol - lineLength; c--)
                                {
                                    theImage[c, lineStartRow] = LineColor;
                                }
                                break;
                            default:
                                Console.WriteLine("Error");
                                break;
                        }
                        break;
                    }
                case 3: // Print the image
                    {
                        Console.WriteLine("PGM Image Contents");
                        Console.WriteLine("P2");
                        Console.WriteLine("{0} {1}", imageWidth, imageHeight);
                        Console.WriteLine("255");
                        for(int r = 0; r < imageHeight; r++, Console.WriteLine())
                            for (int c = 0; c < imageWidth; c++)
                                Console.Write("{0} ", theImage[c, r]);
                        Console.WriteLine();
                        break;
                    }
            }


        }

        Console.WriteLine("[Exiting KSU Image Manipulation Program]");
    }
}