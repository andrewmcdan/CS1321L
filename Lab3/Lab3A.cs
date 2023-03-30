/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               3A
*/

/*

Lab3A: Credit Cards. Financial advisors will almost always tell you that you should pay for things
in cash and avoid credit card debt. Further, they tell you that you should have a small emergency
fund that you keep stocked for emergencies like flat tires, dead refrigerators and so on. However,
life doesn’t always work that way and sometimes we need to charge things. So, for this part of the
lab, we’re going to write a calculator that calculates your minimum monthly payment on your card.

To create this calculator, we will ask the user for 
1) the current balance on their credit card and 
2) the APR (Annual Percentage Rate) of the card. 

To calculate the minimum payment, you will multiply the current
balance on the credit card (also called the amount owed) times APR and divide this number by 12 since there
are 12 months in a year. The formula is Amount Owed × APR ÷ 12 = Minimum Payment . The input APR is a
percent, so make sure the APR is in decimal form when you are doing the calculations. The Monthly
Percentage Rate is calculated by taking the decimal form of the APR and dividing it by 12 since there are 12
months in a year.
Below is an example run. The user input is in bold. 

Amount owed: $2000
APR: 19.75
Monthly percentage rate: 1.646
Minimum payment: $32.92

*/


using System;

class Lab3A
{
    public static void Main(string[] args)
    {
        // Get some data from the user
        Console.Write("Amount owed: $");
        float balance = float.Parse(Console.ReadLine());
        Console.Write("APR: ");
        float percentRate = float.Parse(Console.ReadLine());

        // Calcate the monthly rate
        float mothlyRate = percentRate / 12.0f;

        // Report some calculations to the user
        Console.WriteLine("Monthly percentage rate: {0:0.000}", mothlyRate);
        float payment = balance * mothlyRate / 100.0f;
        Console.WriteLine("Minimum payment: ${0:0.00}", payment);
    }
}