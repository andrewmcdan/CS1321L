using System;

class QuestionA
{
    static void Main(string[] args)
    {
        /*
         * 1) Ask the user for a floating point value in Fahrenheit

2) Convert the value to Kelvin and print it to the user

The formula is K = (F − 32) × 5/9 + 273.15

3) Cast it to an integer and print the new value to the user

4) Prompt the user to enter another floating point value

5) Add that value to the number you created in Step 3, then convert back to Fahrenheit and
display to the user

The formula is F = (K − 273.15) × 9/5 + 32

        [Multi-Converter]
Enter a value in Fahrenheit: 132.3is approximately

132.3F is approximately 328.8722 in Kelvin
If we cast it to an int, it becomes 328K.

What would you like to change this by? -5

We now have 323K.
323K is approximately 121.73 in Fahrenheit
         */
        Console.WriteLine("[Multi-Converter]");
        Console.Write("Enter a value in Fahrenheit: ");
        float fVal = 0;
        fVal = float.Parse(Console.ReadLine());

        float kVal = (fVal - 32.0f) * (5.0f / 9.0f) + 273.15f;

        Console.WriteLine("\n{0}F is approximately {1} in Kelvin",fVal, kVal);

        int kVal_int = (int)(kVal);

        Console.WriteLine("If we cast it to an int, it becomes: {0}K", kVal_int);

        Console.Write("\nWhat would you like to change this by? ");

        float anotherVal = float.Parse(Console.ReadLine());

        anotherVal += (float)(kVal_int);

        Console.WriteLine("\nWe now have: {0}K", anotherVal);

        float new_fVal = (anotherVal - 273.15f) * (9.0f / 5.0f) + 32f;

        Console.WriteLine("{0}K is approximately {1} in Fahrenheit", anotherVal, new_fVal);

    }
}