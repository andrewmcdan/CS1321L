/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        7A
*/

using System;

class Assignment7A
{
    static void Main(string[] args)
    {
        RoShamBoPlayer p1 = new RoShamBoPlayer("Dorothy", 30, 60);
        RoShamBoPlayer p2 = new RoShamBoPlayer("Steve", 40, 85);
        RoShamBoPlayer[] players = { p1, p2 };

        Console.WriteLine("[Ro-Sham-Bo Player]");
        Console.WriteLine("Who do you want to face?");
        Console.WriteLine("1) " + p1.getName());
        Console.WriteLine("2) " + p2.getName());
        Console.Write("Opponent: ");
        int oponent = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Your opponent is " + players[oponent - 1].getName());

        int playingChoice = 0;

        while(playingChoice != 2)
        {
            Console.WriteLine("1) Play a round?");
            Console.WriteLine("2) Quit?");
            Console.Write("Choice: ");
            playingChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (playingChoice == 1)
            {
                Console.Write("Enter an attack: ");
                string attack = Console.ReadLine();
                while(!attack.ToLower().Equals("ro") && !attack.ToLower().Equals("sham") && !attack.ToLower().Equals("bo"))
                {
                    Console.WriteLine("Invalid attack!");
                    Console.Write("Enter an attack: ");
                    attack = Console.ReadLine();
                }

                Console.WriteLine(players[oponent - 1].playRound(attack) ? " You win!" : " You lose...");
                Console.WriteLine();
            }
        }
    }
}

class RoShamBoPlayer
{
    private string playerName;
    private int roLimit;
    private int shamBoLimit;

    public RoShamBoPlayer() { }

    public RoShamBoPlayer(String name, int ro, int shamBo)
    {
        playerName = name;
        roLimit = ro;
        shamBoLimit = shamBo;
    }

    public bool playRound(string play)
    {
        Random randy = new Random();
        int rsb = randy.Next(100);
        Console.Write(playerName + " chose " + (rsb <= roLimit ? "Ro" : (rsb <= shamBoLimit ? "Sham" : "Bo")) + "!");
        switch (play.ToLower())
        {
            case "ro":
                if(rsb <= shamBoLimit)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                break;
            case "sham":
                if(rsb <= roLimit)
                {
                    return true;
                }else
                {
                    return false;
                }
                break;
            case "bo":
                if(rsb <= roLimit)
                {
                    return false;
                }else if(rsb <= shamBoLimit)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                break;
            default:
                return false;
                break;
        }
    }

    public string getName()
    {
        return playerName;
    }
}