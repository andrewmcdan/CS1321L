/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        7B
*/

using System;

class Assignment7B
{
    static void Main(string[] args)
    {
        int imageWidth, imageHeight, userChoice = -1, fillRed, fillGreen, fillBlue;
        Console.WriteLine("[Color Art Program]");
        Console.Write("Enter an image width: ");
        imageWidth = int.Parse(Console.ReadLine());
        Console.Write("Enter an image height: ");
        imageHeight = int.Parse(Console.ReadLine());
        Console.Write("Enter the fill color's red value: ");
        fillRed = int.Parse(Console.ReadLine());
        Console.Write("Enter the fill color's green value: ");
        fillGreen = int.Parse(Console.ReadLine());
        Console.Write("Enter the fill color's blue value: ");
        fillBlue = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Pixel[,] theImage = new Pixel[imageWidth, imageHeight];

        for (int w = 0; w < imageWidth; w++)
            for (int h = 0; h < imageHeight; h++)
                theImage[w, h] = new Pixel(fillRed, fillGreen, fillBlue);

        while(userChoice != 4)
        {
            Console.WriteLine();
            Console.WriteLine("What will you do?");
            Console.WriteLine("1) Fill in a pixel");
            Console.WriteLine("2) Fill in a line");
            Console.WriteLine("3) Print the image");
            Console.WriteLine("4) Quit");

            Console.Write("Choice ? ");
            userChoice = int.Parse(Console.ReadLine());

            while (userChoice > 4 || userChoice < 1)
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
                        int pixelRow = 0, pixelCol = 0, pixelColorRed = 0, pixelColorGreen = 0, pixelColorBlue = 0;
                        while (!validInfo)
                        {
                            Console.Write("Row: ");
                            pixelRow = int.Parse(Console.ReadLine());

                            Console.Write("Column: ");
                            pixelCol = int.Parse(Console.ReadLine());

                            Console.Write("New Red Color: ");
                            pixelColorRed = int.Parse(Console.ReadLine());
                            Console.Write("New Green Color: ");
                            pixelColorGreen = int.Parse(Console.ReadLine());
                            Console.Write("New Blue Color: ");
                            pixelColorBlue = int.Parse(Console.ReadLine());

                            if (pixelRow >= theImage.GetLength(1) || pixelCol >= theImage.GetLength(0) || pixelColorRed > 255 || pixelColorGreen > 255 || pixelColorBlue > 255) Console.WriteLine("Invalid information!");
                            else if (pixelRow < 0 || pixelCol < 0 || pixelColorRed < 0 || pixelColorGreen < 0 || pixelColorBlue < 0) Console.WriteLine("Invalid information!");
                            else validInfo = true;
                        }
                        theImage[pixelCol, pixelRow].changeRGB(pixelColorRed,pixelColorGreen,pixelColorBlue);
                        break;
                    }
                case 2: // Fill in a line
                    {
                        bool validInfo = false;
                        int lineStartRow = 0, lineStartCol = 0, lineLength = 0, LineColorRed = 0, LineColorGreen = 0, LineColorBlue = 0;
                        String lineDir = "";
                        while (!validInfo)
                        {
                            Console.Write("Row: ");
                            lineStartRow = int.Parse(Console.ReadLine());

                            Console.Write("Column: ");
                            lineStartCol = int.Parse(Console.ReadLine());

                            Console.Write("New Red Color: ");
                            LineColorRed = int.Parse(Console.ReadLine());
                            Console.Write("New Green Color: ");
                            LineColorGreen = int.Parse(Console.ReadLine());
                            Console.Write("New Blue Color: ");
                            LineColorBlue = int.Parse(Console.ReadLine());

                            Console.Write("Length: ");
                            lineLength = int.Parse(Console.ReadLine());

                            Console.Write("Direction: ");
                            lineDir = Console.ReadLine().ToLower();

                            if (lineStartRow >= theImage.GetLength(1) || lineStartCol >= theImage.GetLength(0) || LineColorRed > 255 || LineColorGreen > 255 || LineColorBlue > 255) Console.WriteLine("Invalid information!");
                            else if (lineLength < 0 || lineStartRow < 0 || lineStartCol < 0 || LineColorRed < 0 || LineColorGreen < 0 || LineColorBlue < 0) Console.WriteLine("Invalid information!");
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
                                    theImage[lineStartCol, r].changeRGB(LineColorRed, LineColorGreen, LineColorBlue);
                                }
                                break;
                            case "down":
                                for (int r = lineStartRow; r < lineStartRow + lineLength; r++)
                                {
                                    theImage[lineStartCol, r].changeRGB(LineColorRed, LineColorGreen, LineColorBlue);
                                }
                                break;
                            case "right":
                                for (int c = lineStartCol; c < lineStartCol + lineLength; c++)
                                {
                                    theImage[c, lineStartRow].changeRGB(LineColorRed, LineColorGreen, LineColorBlue);
                                }
                                break;
                            case "left":
                                for (int c = lineStartCol; c > lineStartCol - lineLength; c--)
                                {
                                    theImage[c, lineStartRow].changeRGB(LineColorRed, LineColorGreen, LineColorBlue);
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
                        Console.WriteLine("PPM Image Contents");
                        Console.WriteLine("P3");
                        Console.WriteLine("{0} {1}", imageWidth, imageHeight);
                        Console.WriteLine("255");
                        for (int r = 0; r < imageHeight; r++, Console.WriteLine())
                        {
                            for (int c = 0; c < imageWidth; c++)
                            {
                                theImage[c, r].printRGB();
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    }
            }
        }
        Console.WriteLine("[Exiting Color Art Program Program]");
    }
}

class Pixel
{
    private int red, green, blue;
    public Pixel()
    {
        red = 255;
        green = 255;
        blue = 255;
    }

    public Pixel(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }

    public void changeRGB(int r, int g, int b)
    {
        this.red = r;
        this.green = g;
        this.blue = b;
    }

    public void printRGB()
    {
        Console.Write("{0} {1} {2}", red, green, blue);
    }
}
