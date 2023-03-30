using System;

class QuestionC
{
    static void Main(string[] args)
    {
        Console.WriteLine("[Vending Machine Simulation]");
        Console.Write("Put your money in the machine! ");
        float moneyBalance = float.Parse(Console.ReadLine());
        char loop = 'Y';
        while (loop.Equals('Y')){
            Console.WriteLine("\nHere's what you can buy:");
            Console.WriteLine("A) Bag of Computer Chips($2)");
            Console.WriteLine("B) Infinite Loop Bar($1.50)");
            Console.Write("Selection: ");
            char choice = char.Parse(Console.ReadLine());

            while (!choice.Equals('A') && !choice.Equals('B'))
            {
                Console.WriteLine("Sorry, that's not a valid option!");
                Console.Write("Selection: ");
                choice = char.Parse(Console.ReadLine());
            }

            if (choice.Equals('A') && moneyBalance >= 2.0f)
            {
                Console.WriteLine("\nOkay, you bought a Bag of Computer Chips!");
                moneyBalance -= 2f;
            }else if(choice.Equals('B') && moneyBalance >= 1.5f)
            {
                Console.WriteLine("\nOkay, you bought an Infinite Loop Bar!");
                moneyBalance -= 1.5f;
            }else
            {
                Console.WriteLine("Sorry, you only have ${0:0.00} left", moneyBalance);
            }

            Console.Write("\nDo you want to buy anything else? ");
            loop = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nEnding the Vending Machine simulation...");
    }
}