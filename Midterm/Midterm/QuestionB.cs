using System;

class QuestionB
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which famous card hand do you want to guess?");
        Console.WriteLine("1) Dead Man's Hand");
        Console.WriteLine("2) Maverick Hand");
        Console.Write("Hand: ");

        int selection = int.Parse(Console.ReadLine());

        if(selection == 1)
        {
            Console.WriteLine("\nWe have Ace of Clubs, 8 of Spades, and 8 of Clubs. Which card is missing?");
            Console.Write("Value: ");
            int card = int.Parse(Console.ReadLine());
            Console.Write("Suite: ");
            string suite = Console.ReadLine();

            string card_string = "";

            switch (card)
            {
                case 10:
                    card_string = "Jack";
                    break;
                case 11:
                    card_string = "Queen";
                    break;
                case 12:
                    card_string = "King";
                    break;
                case 13:
                    card_string = "Ace";
                    break;
                default:
                    card_string = Convert.ToString(card);
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("You guessed " + card_string + " of " + suite);

            if(card == 13 && string.Compare(suite,"Spades", true) == 0)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect...");
            }
        }else if(selection == 2)
        {
            Console.WriteLine("\nWe have Queen of Spades, Jack of Hearts, Jack of Spades, and Jack of Clubs. Which card is missing?");
            Console.Write("Value: ");
            int card = int.Parse(Console.ReadLine());
            Console.Write("Suite: ");
            string suite = Console.ReadLine();

            string card_string = "";

            switch (card)
            {
                case 10:
                    card_string = "Jack";
                    break;
                case 11:
                    card_string = "Queen";
                    break;
                case 12:
                    card_string = "King";
                    break;
                case 13:
                    card_string = "Ace";
                    break;
                default:
                    card_string = Convert.ToString(card);
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("You guessed " + card_string + " of " + suite);

            if (card == 11 && string.Compare(suite, "Hearts", true) == 0)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect...");
            }
        }

    }
}