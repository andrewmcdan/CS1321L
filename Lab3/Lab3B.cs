/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               3B
*/

/*

Lab3B: GPA calculator. We’re getting more practice making a calculator! GPA is important. It’s one of the
many things employers look at when recruiting new candidates. You also need a GPA of at least 2.0 to
graduate from KSU. GPA is measured by “quality points” using the following scale:
A = 4 quality points
B = 3 quality points
C = 2 quality points
D = 1 quality point
F = 0 quality points
Each course counts for a certain number of credit hours. For instance, most courses are 3 credit hours. This lab
is a 1 credit hour course. Calculus counts 4 credit hours. To calculate the quality points for one course, multiply
the number of hours of that course times the quality points you earn for that course.
To calculate your GPA for the whole semester, you take the total number of quality points earned that semester
and divide it by the total number of hours taken that semester.
For this lab, write a program that reads from the user the number of hours and quality points earned for four
courses then calculates the total hours, total quality points and GPA. You should only use floats as the data
type for your variables. An example run is shown below. The user input is in bold. 

Sample run 1:
Course 1 hours: 4
Grade for course 1: 4
Course 2 hours: 3
Grade for course 2: 3
Course 3 hours: 3
Grade for course 3: 4
Course 4 hours: 4
Grade for course 4: 4
Total hours is: 14
Total quality points is: 53
Your GPA for this semester is 3.78571 


Sample run 2:
Course 1 hours: 4
Grade for course 1: 1
Course 2 hours: 1
Grade for course 2: 4
Course 3 hours: 3
Grade for course 3: 4
Course 4 hours: 3
Grade for course 4: 3
Total hours is: 11
Total quality points is: 29
Your GPA for this semester is 2.63636

*/


using System;

class Lab3B
{
    public static void Main(string[] args)
    {

        // Make some float and then start getting data from the user
        float hours1, hours2, hours3, hours4, grade1, grade2, grade3, grade4, totalHours, totalQPoints, finalGPA;

        Console.Write("Course 1 hours: ");
        hours1 = float.Parse(Console.ReadLine());
        Console.Write("Grade for course 1: ");
        grade1 = float.Parse(Console.ReadLine());

        Console.Write("Course 2 hours: ");
        hours2 = float.Parse(Console.ReadLine());
        Console.Write("Grade for course 2: ");
        grade2 = float.Parse(Console.ReadLine());

        Console.Write("Course 3 hours: ");
        hours3 = float.Parse(Console.ReadLine());
        Console.Write("Grade for course 3: ");
        grade3 = float.Parse(Console.ReadLine());

        Console.Write("Course 4 hours: ");
        hours4 = float.Parse(Console.ReadLine());
        Console.Write("Grade for course 4: ");
        grade4 = float.Parse(Console.ReadLine());

        // calcualte total hours, total quality points, and final GPA
        totalHours = hours1 + hours2 + hours3 + hours4;
        totalQPoints = hours1 * grade1 + hours2 * grade2 + hours3 * grade3 + hours4 * grade4;
        finalGPA = totalQPoints / totalHours;

        // inform the user
        Console.WriteLine("Total hours is: " + totalHours);
        Console.WriteLine("Total quality points is: " + totalQPoints);
        Console.WriteLine("Your GPA for this semester is " + finalGPA);
    }
}