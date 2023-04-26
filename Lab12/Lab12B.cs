/*
Class:              CSE 1321L
Section:            W2
Term:               Spring 2023
Instructor:         Joe Tierno
Name:               Andrew McDaniel
Lab#:               12B
*/

using System;

class Lab12B
{
    static void Main(string[] args)
    {
        Console.WriteLine("You are about to create a dog");
        Dog myDog = new Dog();
        Console.Write("How old is the dog: ");
        myDog.age = int.Parse(Console.ReadLine());
        Console.Write("How much does the dog weigh: ");
        myDog.weight = double.Parse(Console.ReadLine());
        Console.Write("What is the dog's name: ");
        myDog.name = Console.ReadLine();
        Console.Write("What color is the dog: ");
        myDog.furColor = Console.ReadLine();
        Console.Write("What breed is the dog: ");
        myDog.breed = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine(myDog.name + " is a " + myDog.age + " year old " + myDog.furColor + " " + myDog.breed + " that weighs " + myDog.weight + " lbs.");

        Console.WriteLine();
        myDog.bark();
        Console.Write(myDog.name + " is hungry, how much should he eat: ");
        myDog.eat(double.Parse(Console.ReadLine()));
        Console.Write(myDog.name + " isn't a very good name. What should they be renamed to: ");
        myDog.rename(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine(myDog.name + " is a " + myDog.age + " year old " + myDog.furColor + " " + myDog.breed + " that weighs " + myDog.weight + " lbs.");

    }
}

class Dog
{
    public int age;          //current age of the dog
    public double weight;    //how much does it weight in lbs
    public String name;      //what is the name of the dog
    public String furColor;  //color of the dog’s fur/hair
    public String breed;     //what breed is the dog

    public void bark()
    {
        //prints “Woof! Woof!”
        Console.WriteLine("Woof! Woof!");
    }
    public String rename(String newName)
    {
        //take a string and change the name of the dog
        name = newName;
        return name;
    }
    public double eat(double food)
    {
        //take a double and add that number to weight
        weight += food;
        return weight;
    }

    public Dog()
    {
    }
}