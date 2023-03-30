/*
Class:              CSE 1321L
Section:            W#2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        5A
*/

using System;

class Assignment5A
{
    static void Main(string[] args)
    {
        const int numElems = 5;
        String[] firstNames_arr = new string[numElems] { "Mark", "Amanda", "Norman", "Steve", "Jesse" };
        String[] lastNames_arr = new string[numElems] { "Sloan", "Bentley", "Briggs", "Sloan", "Travis" };
        int[] ages_arr = new int[numElems] { 67, 33, 47, 35, 24 };
        String[] occupations_arr = new string[numElems] { "Chief of Internal Medicine", "Pathologist", "Administrator", "Hospital Security", "Surgeon Intern" };
        bool[] hasMedLic_arr = new bool[numElems] { true, true, false, false, true };

        int mainMenuChoice = 0;

        Console.WriteLine("[Community General Hospital Directory]");

        while (mainMenuChoice != 4)
        {    
            Console.WriteLine("1) List all employees");
            Console.WriteLine("2) Search employee records by ID");
            Console.WriteLine("3) Search employee records by Last Name");
            Console.WriteLine("4) Quit");
            Console.Write("Choice: ");
            mainMenuChoice = int.Parse(Console.ReadLine());
            while(mainMenuChoice > 4 || mainMenuChoice < 1)
            {
                Console.WriteLine("No option {0}", mainMenuChoice);
                Console.Write("Choice: ");
                mainMenuChoice = int.Parse(Console.ReadLine());
            }
            switch (mainMenuChoice)
            {
                case 1:
                    {
                        for(int i = 0; i < numElems; i++)
                            Console.WriteLine("#{0}: {1} {2}, Age {3}, {4}, Medical License: {5}", i, firstNames_arr[i], lastNames_arr[i], ages_arr[i], occupations_arr[i], hasMedLic_arr[i] ? "TRUE" : "FALSE");
                        Console.WriteLine("");
                        break;
                    }
                case 2:
                    {
                        Console.Write("ID: ");
                        int id_ = int.Parse(Console.ReadLine());
                        while (id_ < 0 || id_ > 5)
                        {
                            Console.WriteLine("Invalid ID!");
                            Console.Write("ID: ");
                            id_ = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("#{0}: {1} {2}, Age {3}, {4}, Medical License: {5}", id_, firstNames_arr[id_], lastNames_arr[id_], ages_arr[id_], occupations_arr[id_], hasMedLic_arr[id_] ? "TRUE" : "FALSE");
                        Console.WriteLine("");
                        break;
                    }
                case 3:
                    {
                        Console.Write("Last Name: ");
                        String name = Console.ReadLine();
                        bool found = false;
                        for(int i = 0; i < numElems; i++)
                        {
                            if (name.Equals(lastNames_arr[i]))
                            {
                                Console.WriteLine("#{0}: {1} {2}, Age {3}, {4}, Medical License: {5}", i, firstNames_arr[i], lastNames_arr[i], ages_arr[i], occupations_arr[i], hasMedLic_arr[i] ? "TRUE" : "FALSE");
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("No Records Found!");
                        }
                        Console.WriteLine("");
                        break;
                    }
            }
        }
        Console.WriteLine("[Closing Directory...]");
    }
}