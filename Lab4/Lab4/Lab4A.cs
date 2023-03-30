/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               4A
*/


using System;


public class Lab4A
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the score of your exam: ");
        float score = float.Parse(Console.ReadLine());
        string grade;
        
        if (score >= 97.5) grade = "A+";
        else if (score >= 94.5) grade = "A";
        else if (score >= 91.5) grade = "A-";
        else if (score >= 88.5) grade = "B+";
        else if (score >= 85.5) grade = "B";
        else if (score >= 82.5) grade = "B-";
        else if (score >= 79.5) grade = "C+";
        else if (score >= 76.5) grade = "C";
        else if (score >= 73.5) grade = "C-";
        else if (score >= 70.5) grade = "D+";
        else if (score >= 67.5) grade = "D";
        else if (score >= 64.5) grade = "D-";
        else grade = "F";

        Console.WriteLine("Letter grade is: " + grade);
    }
}
