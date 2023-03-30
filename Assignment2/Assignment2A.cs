/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Assignment#:        2A
*/


/*

Assignment 2A:
Remainder Across Operations. We’ve learned that in programming, there is a special operator
for getting the whole number remainder of division: The Modulo Operator!
There are many uses for this operator which we will learn throughout the semester. In this
assignment, we will use it to figure out the remainder of two numbers after adding, subtracting,
multiplying, and dividing them. The basic steps are as follows:
a) Ask the user to enter two numbers (as integers)
b) Read those values in
c) Create four variables – one for the sum, difference, product, and quotient
Note: You must use integer division for the quotient.
d) Calculate those four values
e) Ask the user for the number they want to use to find the remainder
f) Read that value in as well
g) Use the Modulo Operator find out the remainder for the four mathematical operations
h) Display the relevant information to the user
The algorithm output is as shown below, with user input in bold. Follow the output format
exactly. Save your source code in a file called Assignment2A (with a file extension of .cpp, .cs
or .java)

Sample Output:
First number: 20
Second Number: 7
Number for Modulo Operation: 5

20 + 7 = 27. The remainder if divided by 5 is 2.
20 – 7 = 13. The remainder if divided by 5 is 3.
20 * 7 = 140. The remainder if divided by 5 is 0.
20 / 7 = 2 (Approximately). The remainder if divided by 5 is 2.
 
*/


using System;

class Assignment2A
{
    static void Main(string[] args)
    {
        int firstNum, secondNum, modNum;
        
        Console.Write("First Number: ");
        firstNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second Number: ");
        secondNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number for Modulo Operations: ");
        modNum = Convert.ToInt32(Console.ReadLine());

        int sum = firstNum + secondNum;
        int diff = firstNum - secondNum;
        int prod = firstNum * secondNum;
        int quot = firstNum / secondNum;

        Console.WriteLine("\r\n" + firstNum + " + " + secondNum + " = " + sum + ". The remainder if divided by " + modNum + " is " + (sum % modNum));
        Console.WriteLine(firstNum + " - " + secondNum + " = " + diff + ". The remainder if divided by " + modNum + " is " + (diff % modNum));
        Console.WriteLine(firstNum + " * " + secondNum + " = " + prod + ". The remainder if divided by " + modNum + " is " + (prod % modNum));
        Console.WriteLine(firstNum + " / " + secondNum + " = " + quot + " (Approximately). The remainder if divided by " + modNum + " is " + (quot % modNum));
    }
}

